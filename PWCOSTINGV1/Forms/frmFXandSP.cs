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
    public partial class frmFXandSP : MetroForm
    {
        public string RecType { get; set; }
        public string EffectiveDate { get; set; }
        public int YearUsed { get; set; }
        public FormState MyState { get; set; }
        public frmFXandSPList MyCaller { get; set; }

        FXSPBAL fxspbal;
        tbl_000_FXSP fxsp;
        ErrorProviderExtended err;
        private void Init_Form()
        {
            try
            {
                var strheader = "FX and SP";
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false, true);
                        strheader += " - New";
                        this.mcboType.SelectedIndex = 0;
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        AssignRecord(false);
                        LockFields(true, false);
                        if (MyState == FormState.View)
                        {
                            mbtnSave.Text = "Edit";
                            strheader += " - View";
                            mbtnSave.Focus();
                        }

                        else
                        {
                            mtxtRate.ReadOnly = false;
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
                    fxsp.RecType = mcboType.SelectedItem.ToString();
                    fxsp.EffectiveDate = Convert.ToDateTime(mdtpEffectiveDate.Value.Date);
                    fxsp.Rate = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtRate.Text, 0));
                    //For Testing
                    fxsp.YearUsed = UserSettings.LogInYear;
                    fxsp.CreatedBy = UserSettings.Username;
                    fxsp.CreatedDate = DateTime.Now;
                    fxsp.UpdatedBy = UserSettings.Username;
                    fxsp.UpdatedDate = DateTime.Now;
                    //end
                }
                else
                {
                    fxsp = fxspbal.GetByID(RecType, Convert.ToDateTime(EffectiveDate));
                    if (fxsp != null)
                    {
                        mcboType.SelectedItem = fxsp.RecType;
                        mdtpEffectiveDate.Value = fxsp.EffectiveDate;
                        mtxtRate.Text = fxsp.Rate.ToString();
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
        private void LockFields(Boolean IsLocked, Boolean IsEnabled)
        {
            mcboType.Enabled = IsEnabled;
            mdtpEffectiveDate.Enabled = IsEnabled;
            mtxtRate.ReadOnly = IsLocked;
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
                            if (fxspbal.Save(fxsp))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (fxspbal.Update(fxsp))
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
        private void mbtnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            switch (MyState)
            {
                case FormState.Add:
                case FormState.Edit:
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
                    RecType = fxsp.RecType;
                    fxspbal = new FXSPBAL();
                    Init_Form();
                    break;
            }
        }
        public frmFXandSP()
        {
            InitializeComponent();
            fxspbal = new FXSPBAL();
            fxsp = new tbl_000_FXSP();
            err = new ErrorProviderExtended();
        }

        private void frmFXandSP_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

    }
}
