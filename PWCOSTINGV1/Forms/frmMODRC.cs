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

namespace PWCOSTINGV1.Forms
{
    public partial class frmMODRC : MetroForm
    {
        public FormState MyState { get; set; }
        public string mrcode { get; set; }
        public frmMODRCList MyCaller { get; set; }

        MODRCBAL mrbal;
        tbl_000_MODRC modrc;
        ErrorProviderExtended err;

        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtCode, "Required");
            err.Controls.Add(mtxtTime, "Required");
            err.CheckAndShowSummaryErrorMessage();
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
        private void Init_Form()
        {
            try
            {
                var strheader = "MOD/RC";
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        strheader += " - New";
                        break;
                    case FormState.Edit:    
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
                            mtxtCode.ReadOnly = true;
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
                    modrc.MODRCCode = mtxtCode.Text;
                    modrc.Description = mtxtDesc.Text;
                    modrc.IsActive = mcbActive.Checked;
                    modrc.IsCosting = mcbCosting.Checked;
                    modrc.Time = Convert.ToDecimal(mtxtTime.Text);
                    modrc.DateCreated = DateTime.Now;
                    modrc.DateUpdated = DateTime.Now;
                    modrc.DateDeactivated = DateTime.Now;
                }
                else
                {
                    modrc = mrbal.GetByID(mrcode);
                    if (modrc != null)
                    {
                        mtxtCode.Text = modrc.MODRCCode;
                        mtxtDesc.Text = modrc.Description;
                        mcbActive.Checked = modrc.IsActive;
                        mcbCosting.Checked = modrc.IsCosting;
                        mtxtTime.Text = modrc.Time.ToString();
                    }
                    else
                    {
                        throw new Exception("Record doesn't exist!");
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
            mcbActive.Enabled = !IsLocked;
            mcbCosting.Enabled = !IsLocked;
            mtxtCode.ReadOnly = IsLocked;
            mtxtDesc.ReadOnly = IsLocked;
            mtxtTime.ReadOnly = IsLocked;
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
                            if (mrbal.Save(modrc))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (mrbal.Update(modrc))
                            {
                                isSuccess = true;
                            }
                            break;
                    }
                    if (isSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        MyCaller.RefreshGrid();
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
        public frmMODRC()
        {
            InitializeComponent();
            mrbal = new MODRCBAL();
            modrc = new tbl_000_MODRC();
            err = new ErrorProviderExtended();
        }
        public void ChbxSetting(Boolean IsChecked)
        {
            if (mcbActive.Checked == IsChecked)
            {
                mcbActive.Text = "Active";
            }
            else
            {
                mcbActive.Text = "Inactive";
            }
            if (mcbCosting.Checked == IsChecked)
            {
                mcbCosting.Text = "Yes";
            }
            else
            {
                mcbCosting.Text = "No";
            }
        }
        private void MODRC_Load(object sender, EventArgs e)
        {
            Init_Form();
            ChbxSetting(true);
        }

        private void mtxtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            SetControlValidation();
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
                    mrcode = modrc.MODRCCode;
                    mrbal = new MODRCBAL();
                    Init_Form();
                    break;
            }
        }

        private void mcbActive_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

        private void mcbCosting_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }
    }
}
