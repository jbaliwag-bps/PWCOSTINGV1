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
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._000;


namespace PWCOSTINGV1.Forms
{
    public partial class frmFXandSPList : MetroForm 
    {
        FXSPBAL FXSPbal;
        tbl_000_FXSP fxsp;
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            mgridList1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mgridList2.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        public void RecordCount(){
            var fxcount = FXSPbal.GetAll().Select(i => new { i.RecID, i.RecType, i.YearUsed}).Where(r => r.RecType == "FX" && r.YearUsed == UserSettings.LogInYear).Count();
            mlblFXCount.Text = fxcount.ToString() + " Record(s)";
            var spcount = FXSPbal.GetAll().Select(i => new { i.RecID, i.RecType, i.YearUsed }).Where(r => r.RecType == "SP" && r.YearUsed == UserSettings.LogInYear).Count();
            mlblSPCount.Text = spcount.ToString() + " Record(s)";
        }

        public void RefreshGrid()
        {
            try
            {
                var list1 = FXSPbal.GetAll().Select(i => new { i.RecID, i.RecType, i.EffectiveDate, i.Rate, i.YearUsed}).OrderBy(m => m.EffectiveDate).Where(r => r.RecType =="FX" && r.YearUsed == UserSettings.LogInYear).ToList();
                this.mgridList1.DataSource = list1;
                var list2 = FXSPbal.GetAll().Select(i => new { i.RecID, i.RecType, i.EffectiveDate, i.Rate, i.YearUsed}).OrderBy(m => m.EffectiveDate).Where(r => r.RecType == "SP" && r.YearUsed == UserSettings.LogInYear).ToList();
                this.mgridList2.DataSource = list2;
                this.mgridList2.ClearSelection();
                if (mgridList1.RowCount == 0 && mgridList2.RowCount == 0)
                {
                    Grid.tsButtonManager(listTS, true);
                }
                else
                {
                    if(mgridList1.RowCount > 0)
                    Grid.ListCheck(mgridList1, listTS);
                    if(mgridList2.RowCount > 0)
                    Grid.ListCheck(mgridList2, listTS);
                }
                RecordCount();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void ShowEntryForm(FormState Mystate)
        {
            try
            {
                var frm = new frmFXandSP();
                switch (Mystate)
                {
                    case FormState.Add:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                            try
                            {
                                if (mgridList1.SelectedRows != null)
                                {
                                    var fxsptype = mgridList1.Rows[mgridList1.SelectedCells[0].RowIndex].Cells["colRecType1"].Value.ToString();
                                    var fxspeffdate = mgridList1.Rows[mgridList1.SelectedCells[0].RowIndex].Cells["colEffectiveDate1"].Value.ToString();
                                    frm.RecType = fxsptype;
                                    frm.EffectiveDate = fxspeffdate;
                                }
                            }
                            catch
                            {
                                if (mgridList2.SelectedRows != null)
                                {
                                    var fxsptype = mgridList2.Rows[mgridList2.SelectedCells[0].RowIndex].Cells["colRecType2"].Value.ToString();
                                    var fxspeffdate = mgridList2.Rows[mgridList2.SelectedCells[0].RowIndex].Cells["colEffectiveDate2"].Value.ToString();
                                    frm.RecType = fxsptype;
                                    frm.EffectiveDate = fxspeffdate;
                                }
                            }
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
        public frmFXandSPList()
        {
            InitializeComponent();
            FXSPbal = new FXSPBAL();
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
        }

        private void frmFXandSPList_Load(object sender, EventArgs e)
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
                            break;
                    }

                }
            }
        }
        public void DeleteRecord()
        {
            var fxsptype = "";
            var fxspeffdate = "";
            try
            {
                if (mgridList1.SelectedRows != null)
                {
                    fxsptype = mgridList1.Rows[mgridList1.SelectedCells[0].RowIndex].Cells["colRecType1"].Value.ToString();
                    fxspeffdate = mgridList1.Rows[mgridList1.SelectedCells[0].RowIndex].Cells["colEffectiveDate1"].Value.ToString();
                }
            }
            catch
            {
                if (mgridList2.SelectedRows != null)
                {
                    fxsptype = mgridList2.Rows[mgridList2.SelectedCells[0].RowIndex].Cells["colRecType2"].Value.ToString();
                    fxspeffdate = mgridList2.Rows[mgridList2.SelectedCells[0].RowIndex].Cells["colEffectiveDate2"].Value.ToString();
                }
            }
            string rectype = fxsptype;
            string effectivedate = fxspeffdate;
            if (MessageHelpers.ShowQuestion("Are you sure you want to delete record?") == System.Windows.Forms.DialogResult.Yes)
            {
                var isSuccess = false;
                var msg = "Deleting";
                fxsp = FXSPbal.GetByID(rectype, Convert.ToDateTime(effectivedate));
                if (FXSPbal.Delete(fxsp))
                {
                    isSuccess = true;
                }
                if (isSuccess)
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
        private void mgridList1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }
        private void mgridList2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }
        private void mgridList1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.mgridList2.ClearSelection();
            }
        }

        private void mgridList2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.mgridList1.ClearSelection();
            }
        }

    }
}
