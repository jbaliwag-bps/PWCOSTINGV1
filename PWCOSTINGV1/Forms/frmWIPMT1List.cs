using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._100;
using PWCOSTING.BAL._100;
using FastMember;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPMT1List : MetroForm
    {
        WIPMTBAL mtbal;
        tbl_100_WIP_MT mt;

        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 17;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();

        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            FillComboBoxes();
            RefreshGrid();
            rowcount = mgridList.RowCount;
            PageManager(1);
            mgridList.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        public void FillComboBoxes()
        {
            ListHelper.FillMetroCombo(mcboProcess, mtbal.GetByYear(UserSettings.LogInYear).Select(i => new { i.Process }).Distinct().OrderBy(m => m.Process).ToList(), "Process", "Process");
        }
        public void RefreshGrid()
        {
            try
            {
                var list = mtbal.GetByYear(UserSettings.LogInYear).Distinct().Where(w => w.Process == BPSUtilitiesV1.NZ(mcboProcess.SelectedValue, "").ToString()).ToList();
                DataTable mtTable = new DataTable();
                using (var reader = ObjectReader.Create(list,
                    "PartNo",
                    "PartName",
                    "Usage",
                    "Vendor"))
                {
                    mtTable.Load(reader);
                    mgridList.DataSource = mtTable;
                }
                dgvorig.DataSource = mgridList.DataSource;
                Grid.ListCheck(mgridList, listTS);
                tslblRowCount.Text = "Number of Records:    " + list.Count + "       ";
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
                    mgridList.DataSource = Grid.Pager(dgvorig, minrowcount, currentpage);
                }
            }
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                FormHelpers.CursorWait(true);
                frmWIPMT1 frm = new frmWIPMT1();
                switch (MyState)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var pno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                        frm.pno = pno;
                        break;
                }
                frm.MyState = MyState;
                frm.MyCaller = this;
                FormHelpers.ShowForm(frm, (MetroForm)this.MdiParent);
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
        public frmWIPMT1List()
        {
            InitializeComponent();
            mtbal = new WIPMTBAL();
            mt = new tbl_100_WIP_MT();
        }

        private void frmWIPMT1List_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void listTS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var strtag = e.ClickedItem.Tag;
            if (strtag != null)
            {
                if (strtag.ToString() != "")
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
                            DeleteRecord();
                            break;
                        case "view":
                            ShowEntryForm(FormState.View);
                            break;
                        case "refresh":
                            FillComboBoxes();
                            RefreshGrid();
                            PageManager(1);
                            break;
                    }

                }
            }
        }
        private void DeleteRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var pno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var isSuccess = false;
                    var msg = "Deleting";
                    mt = mtbal.GetByID(UserSettings.LogInYear, pno);
                    if (mtbal.Delete(mt))
                    {
                        isSuccess = true;
                    }
                    if (isSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        FillComboBoxes();
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

        private void mgridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = toolStriptxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "PartNo", "PartName");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
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

        private void mcboProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
