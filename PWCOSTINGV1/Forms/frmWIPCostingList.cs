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
using MetroFramework.Controls;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL._100;
using PWCOSTING.BO._100;
using PWCOSTING.BAL;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPCostingList : MetroForm
    {
        WIPCostingBAL wipcostbal;

        WIPMatBAL matbal;
        WIPLabPIBAL labPIbal;
        WIPLabBaggingBAL labbaggbal;
        WIPLabAssyBAL labassybal;
        WIPLabPlatingBAL labplatedbal;

        List<tbl_100_WIP_COSTING_MATERIALS> wipmatlist;
        List<tbl_100_WIP_COSTING_LABOR_PI> wippilist;
        List<tbl_100_WIP_COSTING_LABOR_BAGG> wipbagglist;
        List<tbl_100_WIP_COSTING_LABOR_ASSY> wipassylist;
        List<tbl_100_WIP_COSTING_LABOR_PLATED> wipplatedlist;

        private Manual rptdetails = new Manual();
        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 18;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();

        public void Init_Form()
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
                var wipcostlist = wipcostbal.GetByYear(UserSettings.LogInYear);
                DataTable wipitemTable = new DataTable();
                using (var reader = ObjectReader.Create(wipcostlist,
                    "RecID",
                    "ItemNo",
                    "PartNo",
                    "PartName",
                    "MatLaborCost",
                    "ProfitRate",
                    "TSellingPrice",
                    "Forex",
                    "Ref_Add"
                    ))
                {
                    wipitemTable.Load(reader);
                    mgridList.DataSource = wipitemTable;
                }
                dgvorig.DataSource = mgridList.DataSource;
                Grid.ListCheck(mgridList, listTS);
                tslblRowCount.Text = "Number of Records:    " + wipcostlist.Count + "       ";
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
        public frmWIPCostingList()
        {
            InitializeComponent();
            wipcostbal = new WIPCostingBAL();

            matbal = new WIPMatBAL();
            labPIbal = new WIPLabPIBAL();
            labbaggbal = new WIPLabBaggingBAL();
            labassybal = new WIPLabAssyBAL();
            labplatedbal = new WIPLabPlatingBAL();

            wipmatlist = new List<tbl_100_WIP_COSTING_MATERIALS>();
            wippilist = new List<tbl_100_WIP_COSTING_LABOR_PI>();
            wipbagglist = new List<tbl_100_WIP_COSTING_LABOR_BAGG>();
            wipassylist = new List<tbl_100_WIP_COSTING_LABOR_ASSY>();
            wipplatedlist = new List<tbl_100_WIP_COSTING_LABOR_PLATED>();
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                var frm = new frmWIPCosting();
                var ext = frm.Text;
                switch (MyState)
                {
                    case FormState.Add:
                        ext += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var recid = Convert.ToInt64(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colRecID"].Value);
                        frm.costitem_recid = recid;
                        if (MyState == FormState.Edit)
                            ext += " - Edit";
                        else
                            ext += " - View";
                        break;
                }
                frm.Text = ext;
                frm.MyState = MyState;
                frm.MyCaller = this;
                FormHelpers.ShowForm(frm, (MetroForm)this.MdiParent);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void DeleteSub(string itemno, string partno)
        {
            wipmatlist = matbal.GetByNo(UserSettings.LogInYear, itemno, partno);
            matbal.Delete(wipmatlist);

            wippilist = labPIbal.GetByNo(UserSettings.LogInYear, itemno, partno);
            labPIbal.Delete(wippilist);

            wipbagglist = labbaggbal.GetByNo(UserSettings.LogInYear, itemno, partno);
            labbaggbal.Delete(wipbagglist);

            wipassylist = labassybal.GetByNo(UserSettings.LogInYear, itemno, partno);
            labassybal.Delete(wipassylist);

            wipplatedlist = labplatedbal.GetByNo(UserSettings.LogInYear, itemno, partno);
            labplatedbal.Delete(wipplatedlist);

        }
        private void Delete()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var recid = Convert.ToInt64(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colRecID"].Value);
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var DeletingisSuccess = false;
                    var msg = "Deleting";
                    var existwipcost = wipcostbal.GetByID(recid);
                    if (wipcostbal.Delete(existwipcost))
                    {
                        DeleteSub(existwipcost.ItemNo, existwipcost.PartNo);
                        DeletingisSuccess = true;
                    }

                    if (DeletingisSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        RefreshGrid();
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
        private void ViewWIPItem(string strRptName, string spname)
        {
            try
            {
                var recid = Convert.ToInt64(mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colRecID"].Value);
                var itemno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value.ToString();
                var partno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                if (strRptName == "")
                {
                    throw new Exception("No Report Available!");
                }
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv = new frm_ReportViewer();
                frv.report = new ReportTable();
                frv.report.ReportName = strRptName;
                frv.report.ReportPath = ObjectFinder.ReportPath;
                frv.report.SourceTable = rptdetails.SP_PreviewByWIP(spname, recid);
                frv.report.SubDataSources = rptdetails.SP_ByWIPSubs("sp_WIPMaterials",UserSettings.LogInYear, itemno, partno);
                frv.report.SubDataSources1 = rptdetails.SP_ByWIPSubs("sp_WIPPI", UserSettings.LogInYear, itemno, partno);
                frv.report.SubDataSources2 = rptdetails.SP_ByWIPSubs("sp_WIPBagg", UserSettings.LogInYear, itemno, partno);
                frv.report.SubDataSources3 = rptdetails.SP_ByWIPSubs("sp_WIPAssy", UserSettings.LogInYear, itemno, partno);
                frv.report.SubDataSources4 = rptdetails.SP_ByWIPSubs("sp_WIPPlated", UserSettings.LogInYear, itemno, partno);
                if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data!");
                }
                frv.Text = "WIP Report";
                frv.StartPosition = FormStartPosition.CenterScreen;
                frv.Show();
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
        private void ViewAllWIPItems(string strRptName, string spname)
        {
            try
            {
                if (strRptName == "")
                {
                    throw new Exception("No Report Available!");
                }
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv = new frm_ReportViewer();
                frv.report = new ReportTable();
                frv.report.ReportName = strRptName;
                frv.report.ReportPath = ObjectFinder.ReportPath;
                frv.report.SourceTable = rptdetails.SP_PreviewAllWIP(spname, UserSettings.LogInYear);
                if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data!");
                }
                frv.Text = "WIP Report";
                frv.StartPosition = FormStartPosition.CenterScreen;
                frv.Show();
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
                      case "preview":
                          ViewWIPItem("rpt_PreviewByWIP.rpt", "sp_WIPPreview");
                          break;
                      case "viewall":
                          ViewAllWIPItems("rpt_PreviewAllWIP.rpt", "sp_WIPPreviewAll");
                          break;
                  }
              }
        }
        private void frmWIPCostingList_Load(object sender, EventArgs e)
        {
            Init_Form();
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

        private void mgridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }

        private void listTSFooter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PagingByTS(e);
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = toolStriptxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "ItemNo", "PartNo");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
    }
}
