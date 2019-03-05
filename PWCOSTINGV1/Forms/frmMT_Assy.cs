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
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmMT_Assy : MetroForm
    {
        public FormState MyState { get; set; }
        public frmMT_AssyList MyCaller { get; set; }
        public int yearused { get; set; }
        public string partno { get; set; }

        AssymblyBAL assybal;
        tbl_000_H_ASSY assy;
        ErrorProviderExtended err;

        private void Init_Form()
        {
            try
            {
                var strheader = this.Text;
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        strheader += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.Delete:
                    case FormState.View:
                        AssignRecord(false);
                        LockFields(false);
                        if (MyState == FormState.View)
                        {
                            LockFields(true);
                            mbtnSave.Text = "Edit";
                            strheader += " - View";
                            mbtnSave.Focus();
                        }
                        else
                        {
                            mtxtPartNo.ReadOnly = true;
                            mbtnSave.Text = "Update";
                            strheader += " - Edit";
                        }
                        break;
                }
                this.Text = strheader;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    tbl_000_H_ASSY existassy = new tbl_000_H_ASSY();
                    existassy = assybal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && w.PartNo == mtxtPartNo.Text).FirstOrDefault();
                    if (existassy == null)
                    {
                        assy.CreatedDate = DateTime.Now;
                        assy.CreatedBy = UserSettings.Username;
                        assy.IsCopied = false;
                        assy.CopyDate = DateTime.Now;
                        assy.IsImported = false;
                        assy.ImportDate = DateTime.Now;
                        assy.ImportBy = UserSettings.Username;
                    }
                    assy.YEARUSED = UserSettings.LogInYear;
                    assy.PartNo = mtxtPartNo.Text;
                    assy.PartName = mtxtPartName.Text;
                    assy.HC = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtHC.Text, 0));
                    assy.Qty = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtQty.Text, 0));
                    assy.RATEPERHOUR = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtRatePerHour.Text, 0));
                    assy.IsLocked = mcbLocked.Checked;
                    assy.UpdatedDate = DateTime.Now;
                    assy.UpdatedBy = UserSettings.Username;
                }
                else
                {
                    assy = assybal.GetByID(yearused, partno);
                    if (assy != null)
                    {
                        mtxtPartNo.Text = assy.PartNo;
                        mtxtPartName.Text = assy.PartName;
                        mtxtHC.Text = ((double)assy.HC).ToString();
                        mtxtQty.Text = ((double)assy.Qty).ToString();
                        mtxtRatePerHour.Text = assy.RATEPERHOUR.ToString();
                        mcbLocked.Checked = assy.IsLocked;
                        assy.UpdatedDate = DateTime.Now;
                        assy.UpdatedBy = UserSettings.Username;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LockFields(Boolean IsLocked)
        {
            mtxtPartNo.ReadOnly = IsLocked;
            mtxtPartName.ReadOnly = IsLocked;
            mtxtHC.ReadOnly = IsLocked;
            mtxtQty.ReadOnly = IsLocked;
            mcbLocked.Enabled = !IsLocked;
        }
        private Boolean IsValid()
        {
            try
            {
                return err.CheckAndShowSummaryErrorMessage();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowWarning(ex.Message);
                return false;
            }
        }
        private void SaveRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (IsValid())
                {
                    var isSuccess = false;
                    var msg = "";
                    AssignRecord(true);
                    switch (MyState)
                    {
                        case FormState.Add:
                            msg = "Saving";
                            if (assybal.Save(assy))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (assybal.Update(assy))
                            {
                                isSuccess = true;
                            }
                            break;
                    }
                    if (isSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        MyCaller.Init_Form();
                        this.Close();
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
        public frmMT_Assy()
        {
            InitializeComponent();
            assybal = new AssymblyBAL();
            assy = new tbl_000_H_ASSY();
            err = new ErrorProviderExtended();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMT_Assy_Load(object sender, EventArgs e)
        {
            Init_Form();
            ChbxSetting(true);
            CalculateRate();
        }
        public void ChbxSetting(Boolean IsChecked)
        {
            if (mcbLocked.Checked == IsChecked)
            {
                mcbLocked.Text = "Locked";
            }
            else
            {
                mcbLocked.Text = "Unlocked";
            }
        }
        private void mbtnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            switch (MyState)
            {
                case FormState.Add:
                case FormState.Edit:
                case FormState.Delete:
                    msg = "save";
                    if (MyState == FormState.Edit)
                    {
                        msg = "update";
                    }
                    if (MessageHelpers.ShowQuestion("Are you sure you want to " + msg + " record?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        SaveRecord();
                    }
                    break;
                case FormState.View:
                    MyState = FormState.Edit;
                    yearused = assy.YEARUSED;
                    partno = assy.PartNo;
                    assybal = new AssymblyBAL();
                    Init_Form();
                    break;
            }
        }

        private void mcbLocked_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

        private void mtxtRatePerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
        private void CalculateRate()
        {
            try
            {
                double hc = Convert.ToInt32(BPSolutionsTools.BPSUtilitiesV1.NZ(mtxtHC.Text, 0));
                double qty = Convert.ToInt32(BPSolutionsTools.BPSUtilitiesV1.NZ(mtxtQty.Text, 1));
                double rate = (double)(hc / qty);
                 mtxtRatePerHour.Text = Math.Round(rate, 4).ToString();
            }
            catch
            {

            }
        }

        private void mtxtHC_TextChanged(object sender, EventArgs e)
        {
            CalculateRate();
        }

        private void mtxtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateRate();
        }

        private void mtxtHC_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
    }
}
