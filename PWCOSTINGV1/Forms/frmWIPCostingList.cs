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
using PWCOSTING.BAL._100;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._100;
using PWCOSTING.BAL;
using PWCOSTINGV1.Helpers;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPCostingList : MetroForm
    {
        WIPBAL wipbal;
        tbl_100_WIP wip;
        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 18;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();
        private void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            rowcount = mgridList.RowCount;
            PageManager(1);
            mgridList.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        public void RefreshGrid()
        {
            try
            {
                var list = wipbal.GetByYear(UserSettings.LogInYear);
                DataTable wipTable = new DataTable();
                using (var reader = ObjectReader.Create(list,
                    "ItemNo",
                    "PartCode",
                    "PartName"
                    ))
                {
                    wipTable.Load(reader);
                    mgridList.DataSource = wipTable;
                }
                dgvorig.DataSource = mgridList.DataSource;
                Grid.ListCheck(mgridList, listTS);
                tslblRowCount.Text = "Number of Records:    " + list.Count + "       ";
            }
            catch (Exception ex)
            {
                throw ex;
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
        private void ShowEntryForm(FormState Mystate)
        {
            try
            {
                FormHelpers.CursorWait(true);
                var frm = new frmWIPCosting();
                switch (Mystate)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var recid = Convert.ToInt64(BPSolutionsTools.BPSUtilitiesV1.NZ(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colRecID"].Value, 0));
                        frm.recid = recid;
                        var itemno = BPSolutionsTools.BPSUtilitiesV1.NZ(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value, "").ToString();
                        frm.itemno = itemno;
                        var partcode = BPSolutionsTools.BPSUtilitiesV1.NZ(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value, "").ToString();
                        frm.partcode = partcode;
                        break;
                }
                frm.MyState = Mystate;
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
        public frmWIPCostingList()
        {
            InitializeComponent();
            wipbal = new WIPBAL();
            wip = new tbl_100_WIP();
        }

        private void frmWIPCostingList_Load(object sender, EventArgs e)
        {
           
        }
        private void DeleteRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var ino = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value.ToString();
                var pno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var isSuccess = false;
                    var msg = "Deleting";
                    wip = wipbal.GetByID(UserSettings.LogInYear, ino, pno);
                    if (wipbal.Delete(wip))
                    {
                        isSuccess = true;
                    }
                    if (isSuccess)
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
                            RefreshGrid();
                            PageManager(1);
                            break;
                    }

                }
            }
        }
    }
}
