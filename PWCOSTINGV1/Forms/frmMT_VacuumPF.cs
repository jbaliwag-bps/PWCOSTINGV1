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
    public partial class frmMT_VacuumPF : MetroForm
    {
        public FormState MyState { get; set; }
        public frmMT_VPList MyCaller { get; set; }
        public int yearused { get; set; }
        public string partno { get; set; }

        VacuumPlatingBAL vpbal;
        tbl_000_H_VP vp;
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
        private void LockFields(Boolean IsLocked)
        {
            mtxtPartNo.ReadOnly = IsLocked;
            mtxtPartName.ReadOnly = IsLocked;
            mtxtSourceData.ReadOnly = IsLocked;
            mcbLocked.Enabled = !IsLocked;
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    tbl_000_H_VP existvp = new tbl_000_H_VP();
                    existvp = vpbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && w.PartNo == mtxtPartNo.Text).FirstOrDefault();
                    if (existvp == null)
                    {
                        vp.YEARUSED = UserSettings.LogInYear;
                        vp.PartNo = mtxtPartNo.Text; 
                        vp.CreatedDate = DateTime.Now;
                        vp.CreatedBy = UserSettings.Username;
                        vp.IsCopied = false;
                        vp.CopyDate = DateTime.Now;
                        vp.IsImported = false;
                        vp.ImportDate = DateTime.Now;
                        vp.ImportBy = UserSettings.Username;
                    }
                    vp.PartName = mtxtPartName.Text;
                    vp.SourceData = mtxtSourceData.Text;
                    vp.IsLocked = mcbLocked.Checked;
                    vp.UpdatedDate = DateTime.Now;
                    vp.UpdatedBy = UserSettings.Username;
                }
                else
                {
                    vp = vpbal.GetByID(yearused, partno);
                    if (vp != null)
                    {
                        mtxtPartNo.Text = vp.PartNo;
                        mtxtPartName.Text = vp.PartName;
                        mtxtSourceData.Text = vp.SourceData;
                        mcbLocked.Checked = vp.IsLocked;
                        vp.UpdatedDate = DateTime.Now;
                        vp.UpdatedBy = UserSettings.Username;
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
                            if (vpbal.Save(vp))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (vpbal.Update(vp))
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
        public frmMT_VacuumPF()
        {
            InitializeComponent();
            vpbal = new VacuumPlatingBAL();
            vp = new tbl_000_H_VP();
            err = new ErrorProviderExtended();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMT_VacuumPF_Load(object sender, EventArgs e)
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
                    yearused = vp.YEARUSED;
                    partno = vp.PartNo;
                    vpbal = new VacuumPlatingBAL();
                    Init_Form();
                    break;
            }
        }

        private void mcbLocked_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

    }
}
