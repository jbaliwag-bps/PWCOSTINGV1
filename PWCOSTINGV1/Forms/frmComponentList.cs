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
using PWCOSTINGV1.Helpers;
using PWCOSTING.BO._000;
using PWCOSTING.BAL;
namespace PWCOSTINGV1.Forms
{
    public partial class frmComponentList : MetroForm
    {
        public frmItem MyCaller { get; set; }
        ComponentBAL combal;
        tbl_000_H_PART com;
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
                var list = combal.GetByYear(UserSettings.LogInYear).ToList();
                DataTable comTable = new DataTable();
                using (var reader = ObjectReader.Create(list,
                    "DocID",
                    "PartNo",
                    "PartName",
                    "WholeQty",
                    "WholeUnit",
                    "ConversionQty",
                    "ConversionUnit",
                    "WholePrice",
                    "ConversionPrice",
                    "PreviousPrice",
                    "UpdatedDate",
                    "UpdatedBy",
                    "IsLocked"
                    ))
                {
                    comTable.Load(reader);
                    mgridList.DataSource = comTable;
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
        public void PageManager(int pagenum)
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
                var frm = new frmComponent();
                switch (MyState)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var year = UserSettings.LogInYear;
                        var no = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                        frm.yearused = year;
                        frm.partno = no;
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
        }
        private void purpling()
        {
            Color darkpurple = System.Drawing.ColorTranslator.FromHtml("#7C4199");
            Color selectedpurple = System.Drawing.ColorTranslator.FromHtml("#AA83CB");

            //Header
            mgridList.Columns["colWholeQty"].HeaderCell.Style.BackColor = darkpurple;
            mgridList.Columns["colWholeUnit"].HeaderCell.Style.BackColor = darkpurple;
            mgridList.Columns["colConQty"].HeaderCell.Style.BackColor = darkpurple;
            mgridList.Columns["colConUnit"].HeaderCell.Style.BackColor = darkpurple;
            mgridList.Columns["colLastUpdated"].HeaderCell.Style.BackColor = darkpurple;
            mgridList.Columns["colUpdatedBy"].HeaderCell.Style.BackColor = darkpurple;
            //

            //Selection
            mgridList.Columns["colWholeQty"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            mgridList.Columns["colWholeUnit"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            mgridList.Columns["colConQty"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            mgridList.Columns["colConUnit"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            mgridList.Columns["colLastUpdated"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            mgridList.Columns["colUpdatedBy"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            //
        }
        public frmComponentList()
        {
            InitializeComponent();
            combal = new ComponentBAL();
            com = new tbl_000_H_PART();
        }
        private void frmComponentList_Load(object sender, EventArgs e)
        {
            Init_Form();
            purpling();
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
                        DeleteRecord();
                        break;
                    case "view":
                        ShowEntryForm(FormState.View);
                        break;
                    case "refresh":
                        RefreshGrid();
                        PageManager(1);
                        break;
                    case "print":
                        GenerateReport("rpt_Component.rpt", "sp_Component");
                        break;
                    case "copy":
                        var frm = new frm_YearHelper();
                        frm.Text = "Copy Previous Components";
                        frm.MyCaller_com = this;
                        frm.YearSource = YearsOf.Components;
                        FormHelpers.ShowDialog(frm);
                        break;
                    case "import":
                        var form = new frm_Importer();
                        form.Text = "Import From Excel File";
                        form.MyCaller_com = this;
                        form.YearSource = YearsOf.Components;
                        FormHelpers.ShowDialog(form);
                        break;
                }
            }
        }

        public void DeleteRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var year = UserSettings.LogInYear;
                int yearused = year;
                var no = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colPartNo"].Value.ToString();
                string partno = no;
                if (MessageHelpers.ShowQuestion("Are you sure want to delete record?") == DialogResult.Yes)
                {
                    var isSuccess = false;
                    var msg = "Deleting";
                    com = combal.GetByID(yearused, partno);
                    if (combal.Delete(com))
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

        private void mgridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);

        }
        private void GenerateReport(string strRptName, string spname)
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (strRptName == "")
                {
                    MessageBox.Show("No Report Available!");
                }
                else
                {
                    frm_ReportViewer frv = new frm_ReportViewer();
                    frv.report = new ReportTable();
                    frv.report.ReportName = strRptName;
                    frv.report.ReportPath = ObjectFinder.ReportPath;
                    frv.report.SourceTable = rptdetails.SP_dtComponent(spname, UserSettings.LogInYear);
                    if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                    {
                        throw new Exception("Report no Data!");
                    }
                    frv.Text = "Components Report";
                    frv.StartPosition = FormStartPosition.CenterScreen;

                    frv.Show();
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

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = toolStriptxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "PartNo ", "PartName");
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
    }
}
