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
    public partial class frmMT_PI : MetroForm
    {
        public FormState MyState { get; set; }
        public frmMT_PIList MyCaller { get; set; }
        public int yearused { get; set; }
        public string moldno { get; set; }

        PlasticInjectionBAL pibal;
        tbl_000_H_PI pi;
        ErrorProviderExtended err;
        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtMoldNo, "Required");
            err.Controls.Add(mtxtMoldName, "Required");
            err.Controls.Add(mtxtOz, "Required");
            err.Controls.Add(mtxtPPG, "Required");
            err.Controls.Add(mtxtSPH, "Required");
            err.Controls.Add(mtxtCavity, "Required");
            err.Controls.Add(mtxtPPH, "Required");

            err.CheckAndShowSummaryErrorMessage();
        }

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
                            mtxtMoldNo.ReadOnly = true;
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
        private void LockFields(Boolean IsLocked)
        {
            mtxtMoldNo.ReadOnly = IsLocked;
            mtxtMoldName.ReadOnly = IsLocked;
            mcbLocked.Enabled = !IsLocked;
            mtxtMoldSetupTime.ReadOnly = IsLocked;
            mtxtCavity.ReadOnly = IsLocked;
            mtxtOz.ReadOnly = IsLocked;
            mtxtPPG.ReadOnly = IsLocked;
            mtxtSPH.ReadOnly = IsLocked;
            mtxtCavity.ReadOnly = IsLocked;
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    tbl_000_H_PI existpi = new tbl_000_H_PI();
                    existpi = pibal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && w.MoldNo == mtxtMoldNo.Text).FirstOrDefault();
                    if (existpi == null)
                    {
                        pi.YEARUSED = UserSettings.LogInYear;
                        pi.CreatedDate = DateTime.Now;
                        pi.CreatedBy = UserSettings.Username;
                        pi.IsCopied = false;
                        pi.CopyDate = DateTime.Now;
                        pi.IsImported = false;
                        pi.ImportDate = DateTime.Now;
                        pi.ImportBy = UserSettings.Username;
                    }
                  pi.MoldNo = mtxtMoldNo.Text;
                  pi.MoldName = mtxtMoldName.Text;
                  pi.Oz = mtxtOz.Text;
                  pi.Cavity = Convert.ToDecimal(mtxtCavity.Text);
                  pi.PurgePerG = Convert.ToDecimal(mtxtPPG.Text);
                  pi.SPH = Convert.ToDecimal(mtxtSPH.Text);
                  pi.Cavity = Convert.ToDecimal(mtxtCavity.Text);
                  pi.PPH = Convert.ToDecimal(mtxtPPH.Text);
                  pi.MolSetUpTime = Convert.ToDecimal(mtxtMoldSetupTime.Text);
                  pi.Usage = Convert.ToDecimal(mtxtUsage.Text);
                  pi.IsLocked = mcbLocked.Checked;
                  pi.UpdatedDate = DateTime.Now;
                  pi.UpdatedBy = UserSettings.Username;

                }
                else
                {
                    pi = pibal.GetByID(yearused, moldno);
                    if (pi != null)
                    {
                        mtxtMoldNo.Text = pi.MoldNo;
                        mtxtMoldName.Text = pi.MoldName;
                        mtxtOz.Text = pi.Oz;
                        mtxtPPG.Text = pi.PurgePerG.ToString();
                        mtxtSPH.Text = Convert.ToInt32(pi.SPH).ToString();
                        mtxtCavity.Text = Convert.ToInt32(pi.Cavity).ToString();
                        mtxtPPH.Text = Convert.ToInt32(pi.PPH).ToString();
                        mtxtMoldSetupTime.Text = pi.MolSetUpTime.ToString();
                        mtxtUsage.Text = Convert.ToInt32(pi.Usage).ToString();
                        mcbLocked.Checked = pi.IsLocked;
                        pi.UpdatedDate = DateTime.Now;
                        pi.UpdatedBy = UserSettings.Username;
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
                            if (pibal.Save(pi))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (pibal.Update(pi))
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
        public frmMT_PI()
        {
            InitializeComponent();
            pibal = new PlasticInjectionBAL();
            pi = new tbl_000_H_PI();
            err = new ErrorProviderExtended();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMT_PI_Load(object sender, EventArgs e)
        {
            Init_Form();
            ChbxSetting(true);
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

        private void mcbLocked_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
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
                    yearused  = pi.YEARUSED;
                    moldno = pi.MoldNo;
                    pibal = new PlasticInjectionBAL();
                    Init_Form();
                    break;
            }
        }

        private void mtxtPPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtSPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtCavity_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtPPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
        private void CalculatePPH()
        {
            double sph = Convert.ToDouble(BPSolutionsTools.BPSUtilitiesV1.NZ(mtxtSPH.Text, 0));
            double cavity = Convert.ToDouble(BPSolutionsTools.BPSUtilitiesV1.NZ(mtxtCavity.Text, 1));
            double pph = (double)(sph * cavity);
            mtxtPPH.Text = Math.Round(pph, 4).ToString();
        }
        private void mtxtCavity_TextChanged(object sender, EventArgs e)
        {
            CalculatePPH();
        }

        private void mtxtSPH_TextChanged(object sender, EventArgs e)
        {
            CalculatePPH();
        }

        private void mtxtMoldSetupTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtUsage_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
    }
}
