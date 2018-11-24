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
using System.Collections;
using BPSolutionsTools;
namespace PWCOSTINGV1.Forms
{
    public partial class frmProcessSetup : MetroForm
    {
        public FormState MyState;
        DefaultBAL defbal;
        ProcessSetupBAL procbal;
        tbl_000_PROCESS proc;

        List<tbl_000_PROCESS> proclist_gridall;
        List<tbl_000_PROCESS> proclist_toadd;
        List<tbl_000_PROCESS> proclist_toupdate;
        List<tbl_000_PROCESS> proclist_todelete;
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            FillComboBox();
            LoadGrid();
            MyState = FormState.View;
            StateController();
        }
        private void StateController()
        {
            switch (MyState)
            {
                case FormState.Edit:
                    mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
                    GridLock(false);
                    this.Text = "Process Setup - Edit";
                    break;
                case FormState.View:
                    mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
                    GridLock(true);
                    this.Text = "Process Setup - View";
                    break;
            }
        }

        public void GridLock(Boolean IsLocked)
        {
            try
            {
                for (int i = 0; i <= mgridList.ColumnCount - 1; i++)
                {
                    mgridList.Columns[i].ReadOnly = IsLocked;
                }
                mgridList.AllowUserToAddRows = !IsLocked;
                mgridList.Columns[0].Visible = !IsLocked;
                mcboDefaults.Enabled = IsLocked;
                KeyColumnLocker();
            }
            catch
            {

            }
        }
        public frmProcessSetup()
        {
            InitializeComponent();
            defbal = new DefaultBAL();
            procbal = new ProcessSetupBAL();

            proc = new tbl_000_PROCESS();
        }
        private void frmProcessSetup_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        private void KeyColumnLocker()
        {
            for (int i = 0; i < mgridList.RowCount; i++)
            {
                var yearused = mgridList.Rows[i].Cells["colYEARUSED"].Value;
                if (Convert.ToInt32(BPSUtilitiesV1.NZ(yearused, 0)) != 0)
                {
                    mgridList.Rows[i].Cells["colSubProcessCode"].ReadOnly = true;
                }
            }
        }
        public void LoadGrid()
        {
            try
            {
                var proclist_data = procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && w.ProcessCode == mcboDefaults.SelectedValue.ToString()).ToList();
                BindingList<tbl_000_PROCESS> proclist = new BindingList<tbl_000_PROCESS>(proclist_data);
                mgridList.DataSource = proclist;
                KeyColumnLocker();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void FillComboBox()
        {
            try
            {
                ListHelper.FillMetroCombo(mcboDefaults, defbal.GetAll().OrderByDescending(m => m.StatusUsage == "wipprocess").ToList(), "StatusCode", "StatusDesc");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message); 
            }
        }
        private void AssignRecord()
        {
            Boolean IsAdding = false;
            proclist_toadd = new List<tbl_000_PROCESS>();
            proclist_toupdate = new List<tbl_000_PROCESS>();
            proclist_gridall = new List<tbl_000_PROCESS>();
            try
            {
                if (mgridList.RowCount > 0)
                {
                    for (int i = 0; i < mgridList.RowCount; i++)
                    {
                        if (mgridList.Rows[i].IsNewRow) continue;

                        int existingyear = Convert.ToInt32(mgridList.Rows[i].Cells["colYEARUSED"].Value);
                        string existingsubpcode = mgridList.Rows[i].Cells["colSubProcessCode"].Value.ToString();
                        proc = procbal.GetAll().Where(w => w.YEARUSED == existingyear && w.SubProcessCode == existingsubpcode).FirstOrDefault();
                        if (proc == null)
                        {
                            proc = new tbl_000_PROCESS();
                            IsAdding = true;
                        }
                        proc.SubProcessCode = mgridList.Rows[i].Cells["colSubProcessCode"].Value.ToString();
                        proc.ItemDescription = mgridList.Rows[i].Cells["colItemDesc"].Value.ToString();
                        proc.ProcessCode = mcboDefaults.SelectedValue.ToString();
                        proc.StandardA = Convert.ToDecimal(mgridList.Rows[i].Cells["colSP_HC"].Value);
                        proc.StandardB = Convert.ToDecimal(mgridList.Rows[i].Cells["colCavity"].Value);
                        proc.Remarks = BPSUtilitiesV1.NZ(mgridList.Rows[i].Cells["colRemarks"].Value, "").ToString();
                        if (IsAdding)
                        {
                            //to add
                            proc.YEARUSED = UserSettings.LogInYear;
                            proc.CreatedDate = DateTime.Now;
                            proc.CreatedBy = UserSettings.Username;
                            proc.IsCopied = false;
                            proc.CopyDate = DateTime.Now;
                            proc.IsImported = false;
                            proc.ImportDate = DateTime.Now;
                            proc.ImportBy = UserSettings.Username;
                            proclist_toadd.Add(proc);
                        }
                        else
                        {
                            //to update
                            proc.UpdatedDate = DateTime.Now;
                            proc.UpdatedBy = UserSettings.Username;
                            proclist_toupdate.Add(proc);
                        }
                        //all data
                        proclist_gridall.Add(proc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<string> codelist()
        {
            List<string> _codelist = new List<string>();
            _codelist = procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear).Select(s => s.SubProcessCode).Distinct().ToList();
            return _codelist;
        }
        private List<string> descrplist()
        {
            List<string> _descrplist = new List<string>();
            _descrplist = procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear).Select(s => s.ItemDescription).Distinct().ToList();
            return _descrplist;
        }
        private void SaveRecord()
        {
            proclist_todelete = new List<tbl_000_PROCESS>();
            try
            {
                var msg = "";
                AssignRecord();
                //Delete rows from db w/c doesn't exist in grid
                    var proclist_fromdb = procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear).ToList();
                    foreach (tbl_000_PROCESS pdb in proclist_fromdb)
                    {
                            if (!proclist_gridall.Any(a => a.YEARUSED == pdb.YEARUSED && a.SubProcessCode == pdb.SubProcessCode))
                            {
                                if (pdb.ProcessCode == mcboDefaults.SelectedValue.ToString())
                                proclist_todelete.Add(pdb);
                            }
                    }
                    if (proclist_todelete.Count > 0)
                    {
                        if (procbal.Delete(proclist_todelete))
                        {
                            msg = "D";
                        }
                    }
                //Save the new rows
                if (proclist_toadd.Count > 0)
                {
                    if (procbal.Save(proclist_toadd))
                            msg = "A";
                }
                //Update Rows
                if (proclist_toupdate.Count > 0)
                {
                    if(procbal.Update(proclist_toupdate))
                    {
                            msg = "U";
                    }
                }
                if (msg != "")
                {
                    MessageHelpers.ShowInfo("List Updated Successfully!");
                    LoadGrid();
                    MyState = FormState.View;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<string> ExcemptedColumns()
        {
            var Headers = new List<string>();
            Headers.Add("");
            Headers.Add("Remarks");
            return Headers;
        }
        private void CheckGridCell(DataGridView dgv)
        {
            var emptmsg = "";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (!dgv.Rows[i].IsNewRow)
                {
                    for (int x = 0; x < dgv.ColumnCount; x++)
                    {
                        //Excemptions
                        if (dgv.Columns[x].Visible == false) continue;
                        if (ExcemptedColumns().Contains(dgv.Columns[x].HeaderText)) continue;
                        //
                        if (BPSolutionsTools.BPSUtilitiesV1.NZ(dgv[x, i].Value, "").ToString() == "")
                        {
                            if (emptmsg == "")
                            {
                                emptmsg = "Empty Fields\n";
                            }
                            int rowno = i + 1;
                            emptmsg += "\r\n>" + dgv.Columns[x].HeaderText + " (row " + rowno + ")";
                        }
                    }
                    if (emptmsg != "")
                    {
                        throw new Exception(emptmsg);
                    }
                }
            }
        }
        private void mbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (MyState == FormState.Edit)
                {
                    if (mgridList.RowCount > 1)
                    {
                        CheckGridCell(mgridList);
                        if (MessageHelpers.ShowQuestion("Are you sure you want to update list?") == System.Windows.Forms.DialogResult.Yes)
                        {
                            SaveRecord();
                        }
                    }
                    else
                    {
                        throw new Exception("No record(s) to be saved!");
                    }
                }
                else
                {
                    MyState = FormState.Edit;
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
            StateController();  
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            LoadGrid();
            switch (MyState)
            {
                case FormState.Edit:
                    MyState = FormState.View;
                    StateController();
                    break;
                default:
                    this.Close();
                    break;
            }
        }
        private void mgridList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in mgridList.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (BPSolutionsTools.BPSUtilitiesV1.NZ(mgridList.Rows[e.RowIndex].Cells["colSubProcessCode"].Value, "").ToString() != "")
                    {
                        if (mgridList.Rows[e.RowIndex].Cells["colSubProcessCode"].ReadOnly == false)
                        {
                            if (codelist().Contains(mgridList.Rows[e.RowIndex].Cells["colSubProcessCode"].Value.ToString()))
                            {
                                MessageHelpers.ShowError("Code already taken!");
                                mgridList.Rows.RemoveAt(e.RowIndex);
                                break;
                            }
                        }
                        Grid.UniqueRow(mgridList, "colSubProcessCode");
                    }
                    if (BPSolutionsTools.BPSUtilitiesV1.NZ(mgridList.Rows[e.RowIndex].Cells["colItemDesc"].Value, "").ToString() != "")
                    {
                        if(descrplist().Contains(mgridList.Rows[e.RowIndex].Cells["colItemDesc"].Value.ToString()))
                        {
                             MessageHelpers.ShowError("Description already taken!");
                             mgridList.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                        Grid.UniqueRow(mgridList, "colItemDesc");
                    }
                }
            }
            catch
            {

            }
        }
        private void mgridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (!mgridList.Rows[e.RowIndex].IsNewRow)
                {
                    if (e.ColumnIndex == 0)
                    {
                        mgridList.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void mgridList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridList, sender, e);
        }

        private void mgridList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void mbtnCopyPrev_Click(object sender, EventArgs e)
        {
            var frm = new frm_YearHelper();
            frm.Text = "Copy Previous Process";
            frm.MyCaller_proc = this;
            frm.YearSource = YearsOf.ProcessSetup;
            FormHelpers.ShowDialog(frm);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var frm = new frm_Importer();
            frm.Text = "Import From Excel File";
            frm.MyCaller_proc = this;
            frm.YearSource = YearsOf.ProcessSetup;
            FormHelpers.ShowDialog(frm);
        }

        private void mcboDefaults_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

    }
}
