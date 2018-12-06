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
    public partial class frmMT_PIList : MetroForm
    {
        PlasticInjectionBAL pibal;
        tbl_000_H_PI pi;
        ErrorProviderExtended err;
        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 18;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            rowcount = mgridListPI.RowCount;
            PageManager(1);
            mgridListPI.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        private void RefreshGrid()
        {
            var pilist = pibal.GetByYear(UserSettings.LogInYear);
            DataTable piTable = new DataTable();
            using (var reader = ObjectReader.Create(pilist, 
                "DocID",
                "MoldNo", 
                "MoldName",
                "SPH",
                "Cavity",
                "PPH",
                "Usage",
                "MolSetUpTime",
                "Oz",
                "PurgePerG",
                "UpdatedDate",
                "UpdatedBy"
                ))
            {
                piTable.Load(reader);
                mgridListPI.DataSource = piTable;
            }
            dgvorig.DataSource = mgridListPI.DataSource;
            Grid.ListCheck(mgridListPI, listTS);
            tslblRowCount.Text = "Number of Records:    " + pilist.Count + "       ";
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
                    mgridListPI.DataSource = Grid.Pager(dgvorig, minrowcount, currentpage);
                }
            }
        }
        public frmMT_PIList()
        {
            InitializeComponent();
            pibal = new PlasticInjectionBAL();
            pi = new tbl_000_H_PI();
            err = new ErrorProviderExtended();
        }

        private void frmMT_PIList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                var frmpi = new frmMT_PI();
                switch (MyState)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        frmpi.yearused = UserSettings.LogInYear;
                        var mno = mgridListPI.Rows[mgridListPI.SelectedCells[0].RowIndex].Cells["colMoldNo"].Value.ToString();
                        frmpi.moldno = mno;
                        break;
                }
                frmpi.MyState = MyState;
                frmpi.MyCaller = this;
                FormHelpers.ShowForm(frmpi, (MetroForm)this.MdiParent);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
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
                        frm.MyCaller_mtpi = this;
                        frm.YearSource = YearsOf.MaintainanceTable;
                        frm.YearofMaintenanceTable_Sub = MaintainanceTableSub.PlasticInjection;
                        frm.Text = "Copy Previous PI";
                        FormHelpers.ShowDialog(frm);
                        break;
                    case "import":
                        var form = new frm_Importer();
                        form.Text = "Import From Excel File";
                        form.MyCaller_mtpi = this;
                        form.YearSource = YearsOf.MaintainanceTable;
                        form.YearofMaintenanceTable_Sub = MaintainanceTableSub.PlasticInjection;
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
                var msg = "Deleting";
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var yearused = UserSettings.LogInYear;
                    var moldno = mgridListPI.Rows[mgridListPI.SelectedCells[0].RowIndex].Cells["colMoldNo"].Value.ToString();

                    pi = pibal.GetByID(Convert.ToInt32(yearused), moldno.ToString()); ;
                    if (pibal.Delete(pi))
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
                throw ex;
            }
            finally
            {
                FormHelpers.CursorWait(false);
            }
        }
        private void tstxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = BPSolutionsTools.BPSUtilitiesV1.NZ(tstxtSearch.Text, "").ToString();
            try
            {
                mgridListPI.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "MoldNo", "MoldName");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }

        private void mgridListPI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
