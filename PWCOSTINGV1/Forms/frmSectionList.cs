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
    public partial class frmSectionList : MetroForm
    {
        public frmItem MyCaller { get; set; }
        SectionBAL Sectionbal;
        tbl_000_SECTION sect;
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
        }
        public void RefreshGrid()
        {
            try
            {
                var list = Sectionbal.GetAll().Distinct().OrderBy(m => m.SECTIONDESC).ToList();
                DataTable itmTable = new DataTable();
                using (var reader = ObjectReader.Create(list,
                    "RecID",
                    "SECTIONCODE",
                    "SECTIONDESC",
                    "IsActive"))
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
                var frm = new frmSection();
                switch (Mystate)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var scode = mgridList.SelectedRows[0].Cells["colSectionCode"].Value.ToString();
                        frm.SectionCode = scode;
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
        public frmSectionList()
        {
            InitializeComponent();
            Sectionbal = new SectionBAL();
        }

        private void frmSectionList_Load(object sender, EventArgs e)
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
                var sectioncode = mgridList.SelectedRows[0].Cells["colSectionCode"].Value.ToString();
                string scode = sectioncode;
                if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
                {
                    var DeletingisSuccess = false;
                    var msg = "Deleting";
                    sect = Sectionbal.GetByID(sectioncode);
                    if (Sectionbal.Delete(sect))
                    {
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

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = toolStriptxtSearch.Text;
            try
            {
                mgridList.DataSource = Grid.PageRandom(dgvorig, minrowcount, strtosearch, "SECTIONCODE", "SECTIONDESC");
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
