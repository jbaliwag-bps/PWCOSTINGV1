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
using PWCOSTING.BAL;
using PWCOSTINGV1.Helpers;

namespace PWCOSTINGV1.Forms
{
    public partial class frmItemList : MetroForm
    {
        public frmItem MyCaller { get; set; }
        ItemBAL itembal;
        ItemCompositionBAL compbal;
        ItemTabulationPIBAL tpibal;
        ItemTabulationVPBAL tvpbal;
        ItemTabulationAssyBAL tassybal;
        ItemMPTBAL tmptbal;
        ItemFDCBAL tfdcbal;

        tbl_000_H_ITEM item;
        List<tbl_000_H_ITEM_PART> complist;
        List<tbl_000_H_ITEM_TABULATION> tpilist;
        List<tbl_000_H_ITEM_TABULATION_VP> tvplist;
        List<tbl_000_H_ITEM_TABULATION_ASSY> tassylist;
        List<tbl_000_H_ITEM_MPT> tmptlist;
        List<tbl_000_H_ITEM_FDC> tfdclist;

        int yused = UserSettings.LogInYear;

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
                var list = itembal.GetByYear(UserSettings.LogInYear);
                DataTable itmTable = new DataTable();
                using (var reader = ObjectReader.Create(list, 
                    "DocID",
                    "ItemNo",
                    "Description",
                    "IsLocked"
                    ))
                {
                    itmTable.Load(reader);
                    mgridList.DataSource = itmTable;
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

        private void ShowEntryForm(FormState Mystate)
        {
            try
            {
                FormHelpers.CursorWait(true);
                var frm = new frmItem();
                switch (Mystate)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var itemno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value.ToString();
                        frm.itemno = itemno;
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
        public frmItemList()
        {
            InitializeComponent();
            itembal = new ItemBAL();
            compbal = new ItemCompositionBAL();
            tpibal = new ItemTabulationPIBAL();
            tvpbal = new ItemTabulationVPBAL();
            tassybal = new ItemTabulationAssyBAL();
            tmptbal = new ItemMPTBAL();
            tfdcbal = new ItemFDCBAL();

            item = new tbl_000_H_ITEM();
            complist = new List<tbl_000_H_ITEM_PART>();
            tpilist = new List<tbl_000_H_ITEM_TABULATION>();
            tvplist = new List<tbl_000_H_ITEM_TABULATION_VP>();
            tassylist = new List<tbl_000_H_ITEM_TABULATION_ASSY>();
            tmptlist = new List<tbl_000_H_ITEM_MPT>();
            tfdclist = new List<tbl_000_H_ITEM_FDC>();
        }

        private void frmItemList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void listTS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemno = "";
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
                        case "copy":
                            var frm = new frm_Copier();
                            frm.Text = "Copy Previous Items";
                            frm.MyCaller_itm = this;
                            FormHelpers.ShowDialog(frm);
                            break;
                        case "import":
                            var frm2 = new frm_ImporterByItem();
                            frm2.Text = "Import Items";
                            frm2.MyCaller_itm = this;
                            FormHelpers.ShowDialog(frm2);
                            break;
                        case "quote":
                            itemno = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value.ToString();
                            if (MessageHelpers.ShowQuestion("Quote item " + itemno +"?") == System.Windows.Forms.DialogResult.Yes)
                            {
                                QuoteItem(itemno);
                            }
                            break;
                    }

                }

            }
        }
        private void QuoteItem(string itemno)
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (itembal.QuoteItem(yused, itemno))
                {
                    MessageHelpers.ShowInfo("Quotation Successful!");
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
        public void DeleteRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var ino = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colItemNo"].Value.ToString();
                string itemno = ino;
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var DeletingisSuccess = false;
                    var msg = "Deleting";
                    item = itembal.GetByID(yused, itemno);
                    if (itembal.Delete(item))
                    {
                        DeleteSub(itemno);
                        DeletingisSuccess = true;
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
        private void DsubPI(string itemno)
        {
            tpilist = tpibal.GetByNo(yused,itemno);
            foreach (var p in tpilist)
            {
                tpibal.Delete(p);
            }
        }
        private void DsubVP(string itemno)
        {
            tvplist = tvpbal.GetByNo(yused, itemno);
            foreach (var v in tvplist)
            {
                tvpbal.Delete(v);
            }
        }
        private void DsubAssy(string itemno)
        {
            tassylist = tassybal.GetByNo(yused, itemno);
            foreach (var a in tassylist)
            {
                tassybal.Delete(a);
            }
        }
        private void DeleteSub(string itemno)
        {
            try
            {
                complist = compbal.GetByNo(yused, itemno);
                foreach (tbl_000_H_ITEM_PART c in complist)
                {
                    compbal.Delete(c);
                }
                //Tabulation
                DsubPI(itemno);
                DsubVP(itemno);
                DsubAssy(itemno);
                //
                tmptlist = tmptbal.GetByNo(yused, itemno);
                foreach (var m in tmptlist)
                {
                    tmptbal.Delete(m);
                }
                tfdclist = tfdcbal.GetByNo(yused, itemno);
                foreach (var f in tfdclist)
                {
                    tfdcbal.Delete(f);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = tstxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "ItemNo", "Description");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }

        private void mgridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
