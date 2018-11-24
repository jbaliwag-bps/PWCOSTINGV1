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
    public partial class frmUserProfile : MetroForm
    {
        #region "properties and declarations"
        public FormState MyState { get; set; }
        public string username { get; set; }
        public frmUserList MyCaller { get; set; }

        UserBAL userbal;
        UserGroupBAL usergroupbal;
        SectionBAL sectionbal;
        tbl_000_USER usr;
        ErrorProviderExtended err;
        int MaxUsernameLenght;
        int MaxPasswordLength;
        #endregion

        #region "user-defined methods"
        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtUsername, "Required");
            err.Controls.Add(mtxtPassword, "Required");
            err.Controls.Add(mtxtFullName, "Required");

            err.CheckAndShowSummaryErrorMessage();
        }
        private void Init_Form()
        {
            try
            {
                var strheader = "User Profile";
                GetList();
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
                        mtxtUsername.ReadOnly = true;
                        mbtnBrowse.Visible = false;
                        if (MyState == FormState.View)
                        {
                            LockFields(true);
                            //mbtnSave.Text = "Edit";
                            mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
                            strheader += " - View";
                            mbtnSave.Focus();
                        }
                        else if (MyState == FormState.Delete)
                        {
                            LockFields(true);
                            //mbtnSave.Text = "Delete";
                            mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.delete_icon;
                            strheader += " - Delete";
                            mbtnSave.Focus();
                        }
                        else
                        {
                            //mbtnSave.Text = "Update";
                            mbtnBrowse.Visible = true;
                            strheader += " - Edit";
                        }
                        break;
                }
                mtxtUsername.Focus();
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
                    usr.UserID = usr.UserID;
                    usr.Username = mtxtUsername.Text;
                    usr.Password = mtxtPassword.Text;
                    usr.FullName = mtxtFullName.Text;
                    usr.UserGroupCode = mcboUserGroupCode.SelectedValue.ToString();
                    usr.UserGroupDesc = mcboUserGroupCode.Text;
                    usr.SectionCode = BPSUtilitiesV1.NZ(mcboSectionCode.SelectedValue, "").ToString();
                    usr.SectionDesc = BPSUtilitiesV1.NZ(mcboSectionCode.Text, "").ToString();
                    usr.AccessLevel = mtxtAccessLevel.Text;
                    usr.IsActive = mcbActive.Checked;
                    if (ofdImage.FileName != "")
                    {
                        usr.UserPhoto = BPSolutionsTools.BPSUtilitiesV1.ImageToByte(Image.FromFile(ofdImage.FileName));
                    }
                }
                else
                {
                    usr = userbal.GetByUsername(username);
                    if (usr != null)
                    {
                        mtxtUsername.Text = usr.Username;
                        mtxtPassword.Text = usr.Password;
                        mtxtConfirmPassword.Text = usr.Password;
                        mtxtFullName.Text = usr.FullName;
                        mcboUserGroupCode.SelectedValue = usr.UserGroupCode;
                        mcboSectionCode.SelectedValue = usr.SectionCode;
                        //mcboSectionCode.Text=usr.SectionDesc;
                        mtxtAccessLevel.Text = usr.AccessLevel;
                        mcbActive.Checked = usr.IsActive;
                        if (usr.UserPhoto != null)
                        {
                            picUser.BackgroundImage = BPSolutionsTools.BPSUtilitiesV1.BytesToImage(usr.UserPhoto);
                        }
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
            finally
            {

            }
        }
        private void LockFields(Boolean IsLocked)
        {
            mtxtUsername.ReadOnly = IsLocked;
            mtxtPassword.ReadOnly = IsLocked;
            mtxtConfirmPassword.ReadOnly = IsLocked;
            mcboSectionCode.Enabled = !IsLocked;
            mcboUserGroupCode.Enabled = !IsLocked;
            mtxtFullName.ReadOnly = IsLocked;
            mtxtAccessLevel.ReadOnly = IsLocked;
            mcbActive.Enabled = !IsLocked;
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
                            usr.UserID = Guid.NewGuid().ToString();
                            if (userbal.Save(usr))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (userbal.Update(usr))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Delete:
                            msg = "Deleting";
                            if (userbal.Delete(usr))
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
                var blnIsvalid = err.CheckAndShowSummaryErrorMessage();
                if (!mtxtPassword.Text.Equals(mtxtConfirmPassword.Text))
                {
                    throw new Exception("Password does not match!");
                }
                if (mtxtUsername.Text.Length < MaxUsernameLenght)
                {
                    throw new Exception("Username must be greater than " + MaxUsernameLenght.ToString() + " characters!");
                }
                if (mtxtPassword.Text.Length < MaxPasswordLength)
                {
                    throw new Exception("Password must be greater than " + MaxPasswordLength.ToString() + " characters!");
                }
                return blnIsvalid;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowWarning(ex.Message);
                return false;
            }
        }

        private void GetList()
        {
            try
            {
                ListHelper.FillMetroCombo(mcboUserGroupCode, usergroupbal.GetAll().Select(i => new { i.UserGroupCode, i.UserGroupDesc }).Distinct().OrderBy(m => m.UserGroupDesc).ToList(), "UserGroupCode", "UserGroupDesc");
                //section
                ListHelper.FillMetroCombo(mcboSectionCode, sectionbal.GetAll().Select(i => new { i.SECTIONCODE, i.SECTIONDESC }).Distinct().OrderBy(m => m.SECTIONDESC).ToList(), "SECTIONCODE", "SECTIONDESC");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public frmUserProfile()
        {
            // constructors;
            InitializeComponent();
            userbal = new UserBAL();
            usergroupbal = new UserGroupBAL();
            sectionbal = new SectionBAL();
            usr = new tbl_000_USER();
            err = new ErrorProviderExtended();

            //get default length for username and password;
            MaxUsernameLenght = PWCOSTINGV1.Properties.Settings.Default.intUsernameLenght;
            MaxPasswordLength = PWCOSTINGV1.Properties.Settings.Default.intPasswordLength;
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            Init_Form();
            ChbxSetting(true);
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if (MyState == FormState.Delete)
                    {
                        msg = "delete";
                    }
                    if (MessageHelpers.ShowQuestion("Are you sure you want to " + msg + " record?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        SaveRecord();
                    }
                    break;
                case FormState.View:
                    MyState = FormState.Edit;
                    username = usr.Username;
                    userbal = new UserBAL();
                    Init_Form();
                    break;
            }
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
        }

        private void mcbActive_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

        private void mbtnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                var selfile = ofdImage.FileName;
                picUser.BackgroundImage = Image.FromFile(selfile);
            }
        }

    }
}
