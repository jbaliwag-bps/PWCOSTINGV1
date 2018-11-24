using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using MetroFramework.Forms;
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._000;

namespace PWCOSTINGV1.Forms
{
    public partial class frmMT_AssyList : MetroForm
    {
        AssymblyBAL assybal;
        tbl_000_H_ASSY assy;
        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 18;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            rowcount = mgridListAssy.RowCount;
            PageManager(1);
        }
        private void RefreshGrid()
        {
            try
            {
                var assylist = assybal.GetByYear(UserSettings.LogInYear);
                DataTable assyTable = new DataTable();
                using (var reader = ObjectReader.Create(assylist, 
                    "DocID", 
                    "PartNo", 
                    "PartName", 
                    "HC",
                    "Qty",
                    "RATEPERHOUR", 
                    "UpdatedDate", 
                    "UpdatedBy"))
                {
                    assyTable.Load(reader);
                    mgridListAssy.DataSource = assyTable;
                }
                dgvorig.DataSource = mgridListAssy.DataSource;
                tslblRowCount.Text = "Number of Records:    " + assylist.Count + "       ";
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void PageManager(int pagenum)
        {
            currentpage = pagenum;
            if (rowcount > 0)
            {
                pagetotal = rowcount / minrowcount;
                if (pagetotal == 0)
                    pagetotal = 1;
                tstxtRowRange.Text = currentpage.ToString() + "/" + pagetotal.ToString();
                if (rowcount > minrowcount)
                {
                    mgridListAssy.DataSource = Grid.Pager(dgvorig, minrowcount, currentpage);
                }
            }
        }
        public frmMT_AssyList()
        {
            InitializeComponent();
            assybal = new AssymblyBAL();
            assy = new tbl_000_H_ASSY();
        }

        private void frmMT_AssyList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                FormHelpers.CursorWait(true);
                var frmassy = new frmMT_Assy();
                switch (MyState)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        frmassy.yearused = UserSettings.LogInYear;
                        var pno = mgridListAssy.SelectedRows[0].Cells["colPartNoAssy"].Value.ToString();
                        frmassy.partno = pno;
                        break;
                }
                frmassy.MyState = MyState;
                frmassy.MyCaller = this;
                FormHelpers.ShowForm(frmassy, (MetroForm)this.MdiParent);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
            finally
            {
                FormHelpers.CursorWait(false);
            }
        }
        private void listTS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
               var strtag = e.ClickedItem.Tag;
               if (BPSolutionsTools.BPSUtilitiesV1.NZ(strtag, "").ToString() != "")
               {
                   switch (strtag.ToString().ToLower())
                   {
                       case "new":
                           ShowEntryForm(FormState.Add);
                           break;
                       case "edit":
                           ShowEntryForm(FormState.Edit);
                           break;
                       case "delete":
                           Delete();
                           break;
                       case "view":
                           ShowEntryForm(FormState.View);
                           break;
                       case "refresh":
                           RefreshGrid();
                           PageManager(1);
                           break;
                       case "copy":
                         var frm = new frm_YearHelper();
                         frm.MyCaller_mtassy = this ;
                         frm.YearSource = YearsOf.MaintainanceTable;
                         frm.YearofMaintenanceTable_Sub = MaintainanceTableSub.Assembly;
                         frm.Text = "Copy Previous Assy";
                         FormHelpers.ShowDialog(frm);
                           break;
                       case "import":
                           var form = new frm_Importer();
                           form.Text = "Import From Excel File";
                           form.MyCaller_mtassy = this;
                           form.YearSource = YearsOf.MaintainanceTable;
                           form.YearofMaintenanceTable_Sub = MaintainanceTableSub.Assembly;
                           FormHelpers.ShowDialog(form);
                           break;
                   }
               }
        }
        private void Delete()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var DeletingisSuccess = false;
                var msg = "Deleting";
                Int32 selectedRowCount;
                selectedRowCount = mgridListAssy.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        var yearused = UserSettings.LogInYear;
                        var partno = mgridListAssy.SelectedRows[i].Cells["colPartNoAssy"].Value.ToString();

                        assy = assybal.GetByID(Convert.ToInt32(yearused), partno.ToString()); ;
                        if (assybal.Delete(assy))
                        {
                            DeletingisSuccess = true;
                        }
                    }
                    if (DeletingisSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        RefreshGrid();
                        PageManager(1);
                    }
                    else
                    {
                        MessageHelpers.ShowWarning(msg + " Failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
            finally
            {
                FormHelpers.CursorWait(false);
            }
        }

        private void tstxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = tstxtSearch.Text;
            try
            {
                mgridListAssy.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "PartNo", "PartName");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void mgridListAssy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }
        private void PagingByTS(ToolStripItemClickedEventArgs e)
        {
            var strtag = e.ClickedItem.Tag;
            if (BPSolutionsTools.BPSUtilitiesV1.NZ(strtag, "").ToString() != "")
            {
                switch (strtag.ToString().ToLower())
                {
                    case "first":
                        PageManager(1);
                        break;
                    case "prev":
                        if (currentpage > 1)
                        {
                            currentpage = currentpage - 1;
                        }
                        PageManager(currentpage);
                        break;
                    case "next":
                        if (currentpage < pagetotal)
                        {
                            currentpage += 1;
                        }
                        PageManager(currentpage);
                        break;
                    case "last":
                        PageManager(Convert.ToInt32(pagetotal));
                        break;
                }
            }
        }
        private void listTSFooter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PagingByTS(e);
        }
    }
}
