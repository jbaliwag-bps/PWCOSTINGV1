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
    public partial class frmMT_VPList : MetroForm
    {
        VacuumPlatingBAL vpbal;
        tbl_000_H_VP vp;
        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 18;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            rowcount = mgridListVP.RowCount;
            PageManager(1);
        }
        private void RefreshGrid()
        {
            try
            {
                var vplist = vpbal.GetByYear(UserSettings.LogInYear);
                DataTable vpTable = new DataTable();
                using (var reader = ObjectReader.Create(vplist, "DocID", "PartNo", "PartName", "SourceData", "UpdatedDate", "UpdatedBy"))
                {
                    vpTable.Load(reader);
                    mgridListVP.DataSource = vpTable;
                }
                dgvorig.DataSource = mgridListVP.DataSource;
                tslblRowCount.Text = "Number of Records:    " + vplist.Count + "       ";
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
                    mgridListVP.DataSource = Grid.Pager(dgvorig, minrowcount, currentpage);
                }
            }
        }
        public frmMT_VPList()
        {
            InitializeComponent();
            vpbal = new VacuumPlatingBAL();
            vp = new tbl_000_H_VP();
        }
        private void frmMT_VPList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                FormHelpers.CursorWait(true);
                var frmvp = new frmMT_VacuumPF();
                switch (MyState)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        frmvp.yearused = UserSettings.LogInYear;
                        var pno = mgridListVP.SelectedRows[0].Cells["colPartNoVP"].Value.ToString();
                        frmvp.partno = pno;
                        break;
                }
                frmvp.MyState = MyState;
                frmvp.MyCaller = this;
                FormHelpers.ShowForm(frmvp, (MetroForm)this.MdiParent);
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
                         frm.MyCaller_mtvp = this ;
                         frm.YearSource = YearsOf.MaintainanceTable;
                         frm.YearofMaintenanceTable_Sub = MaintainanceTableSub.VacuumPlating;
                         frm.Text = "Copy Previous VP";
                         FormHelpers.ShowDialog(frm);
                         break;
                     case "import":
                         var form = new frm_Importer();
                         form.Text = "Import From Excel File";
                         form.MyCaller_mtvp = this;
                         form.YearSource = YearsOf.MaintainanceTable;
                         form.YearofMaintenanceTable_Sub = MaintainanceTableSub.VacuumPlating;
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
                    selectedRowCount = mgridListVP.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            var yearused = UserSettings.LogInYear;
                            var partno = mgridListVP.SelectedRows[i].Cells["colPartNoVP"].Value.ToString();

                            vp = vpbal.GetByID(Convert.ToInt32(yearused), partno.ToString()); ;
                            if (vpbal.Delete(vp))
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
                mgridListVP.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "PartNo", "PartName");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void mgridListVP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
