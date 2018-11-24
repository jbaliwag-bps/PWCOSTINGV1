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
    public partial class frmCategoryList : MetroForm
    {
        CategoryBAL Categorybal;
        tbl_000_H_CATEGORY cat;

        long rowcount = 0;
        long pagetotal = 0;
        int minrowcount = 17;
        int currentpage = 1;
        DataGridView dgvorig = new DataGridView();

        private void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            rowcount = mgridList.RowCount;
            PageManager(1);
        }
        public void RefreshGrid()
        {
            try
            {
                //var list = Categorybal.GetAll().Select(i => new { i.RecID, i.CATCODE, i.CATDESC, i.YEARUSED, i.MoldSetup, i.LotSize, i.IsDependent, i.IsActive }).OrderBy(m => m.CATDESC).Where(r=>r.YEARUSED == UserSettings.LogInYear).ToList();
                //this.mgridList.DataSource = list;

                var list = Categorybal.GetAll().Select(i => new
                {
                    i.RecID,
                    i.YEARUSED,
                    aCATCODE = i.CATCODE,
                    bCATDESC = i.CATDESC,
                    cMoldSetup = i.MoldSetup,
                    dLotSize = i.LotSize,
                    eIsDependent = i.IsDependent,
                    fIsActive = i.IsActive
                }).Distinct().Where(r => r.YEARUSED == UserSettings.LogInYear).ToList();
                DataTable itmTable = new DataTable();
                using (var reader = ObjectReader.Create(list))
                {
                    itmTable.Load(reader);
                    mgridList.DataSource = itmTable;
                }
                dgvorig.DataSource = mgridList.DataSource;
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
        private void ShowEntryForm(FormState Mystate)
        {
            try
            {
                var frm = new frmCategory();
                switch (Mystate)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var ccode = mgridList.SelectedRows[0].Cells["colCATCODE"].Value.ToString();
                        frm.CategoryCode = ccode;
                        var cyearused = mgridList.SelectedRows[0].Cells["colYEARUSED"].Value.ToString();
                        frm.YearUsed = Convert.ToInt32(cyearused);
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
        }
        public frmCategoryList()
        {
            InitializeComponent();
            Categorybal = new CategoryBAL();
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
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
                            RefreshGrid();
                            PageManager(1);
                            break;
                    }

                }
            }
        }
        public void DeleteRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var categorycode = mgridList.SelectedRows[0].Cells["colCATCODE"].Value.ToString();
                string ccode = categorycode;
                var cyearused = mgridList.SelectedRows[0].Cells["colYEARUSED"].Value.ToString();
                int yearused = Convert.ToInt32(cyearused);
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var isSuccess = false;
                    var msg = "Deleting";
                    cat = Categorybal.GetByID(categorycode, yearused);
                    if (Categorybal.Delete(cat))
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

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = toolStriptxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "aCATCODE", "bCATDESC");
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
