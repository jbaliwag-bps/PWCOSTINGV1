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
    public partial class frmUserGroup : MetroForm
    {
        #region "properties and declarations"
        public FormState MyState { get; set; }
        public string groupid { get; set;  }
        public frmUserGroupList MyCaller { get; set; }

        UserGroupBAL usrgrpbal;
        tbl_000_USERGROUP usrgrp;
        ErrorProviderExtended err;
        #endregion  

        #region "user-defined methods"
        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtGroupCode, "Required");
            err.Controls.Add(mtxtGroupDesc, "Required");

            err.CheckAndShowSummaryErrorMessage();
        }
        private void RefreshList()
        {
            try
            {
                if (usrgrp.MenuList == null)
                {
                     usrgrp.MenuList = new List<tbl_000_USERGROUP_MENUS>();
                }
                mgridRights.DataSource = new List<tbl_000_USERGROUP_MENUS>();
                mgridRights.DataSource = usrgrp.MenuList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddRights(List<tbl_000_USERGROUP_MENUS> UserRights)
        {
            try
            {
                if (UserRights != null)
                {
                    if (UserRights.Count > 0)
                    {
                        foreach (tbl_000_USERGROUP_MENUS userright in UserRights)
                        {
                            usrgrp.MenuList.Add(userright);
                        }
                        RefreshList();
                    }                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Removeright(string usrgrpcode, int menuID)
        {
            try
            {
                var userright = usrgrp.MenuList.SingleOrDefault(m => m.MenuID == menuID && m.UserGroupCode == usrgrpcode);
                if (userright != null)
                {
                    usrgrp.MenuList.Remove(userright);
                    RefreshList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Init_Form()
        {
            try
            {
                var strheader = "User Group";
                switch (MyState)
                {
                    case FormState.Add:
                        usrgrp.GroupID = Guid.NewGuid().ToString();
                        LockFields(false);
                        strheader += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.View:
                    case FormState.Delete:
                        AssignRecord(false);
                        LockFields(false);
                        if (MyState == FormState.View)
                        {
                            LockFields(true);
                            mbtnSave.BackgroundImage = PWCOSTINGV1.Properties.Resources.editicon;
                            strheader += " - View";
                            mbtnSave.Focus();
                        }
                        else if (MyState == FormState.Delete)
                        {
                            LockFields(true);
                            mbtnSave.Text = "Delete";
                            strheader += " - Delete";
                            mbtnSave.Focus();
                        }
                        else
                        {
                            mtxtGroupCode.ReadOnly = true;
                            mbtnSave.BackgroundImage = PWCOSTINGV1.Properties.Resources.saveicon1;
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
                    usrgrp.UserGroupCode = mtxtGroupCode.Text;
                    usrgrp.UserGroupDesc = mtxtGroupDesc.Text;
                    usrgrp.Remarks = mtxtRemarks.Text;
                    usrgrp.IsActive = mcbActive.Checked;   
                 
                }
                else
                {
                    usrgrp = usrgrpbal.GetByID(groupid);
                    RefreshList();
                    if (usrgrp != null)
                    {
                        mtxtGroupCode.Text = usrgrp.UserGroupCode;
                        mtxtGroupDesc.Text = usrgrp.UserGroupDesc;
                        mtxtRemarks.Text = usrgrp.Remarks;
                        mcbActive.Checked = usrgrp.IsActive;    
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
            mtxtGroupCode.ReadOnly = IsLocked;
            mtxtGroupDesc.ReadOnly = IsLocked;
            mtxtRemarks.ReadOnly = IsLocked;            
            mcbActive.Enabled = !IsLocked;
        }

        private void SaveRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                mgridRights.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (IsValid())
                {
                    var strmsg = "";
                    var blnsuccess = false;
                    AssignRecord(true);
                    if (MyState == FormState.Add)
                    {
                        strmsg = "Saving Failed!";
                        if (usrgrpbal.Save(usrgrp))
                        {
                            strmsg = "Saving Successful!";
                            blnsuccess = true;
                        }                 
                    }
                    if (MyState == FormState.Edit)
                    {
                        strmsg = "Updating Failed!";
                        if (usrgrpbal.Update(usrgrp))
                        {
                            strmsg = "Updating Successful!";
                            blnsuccess = true;
                        }                        
                    }                    
                    if (blnsuccess)
                    {
                        MessageHelpers.ShowInfo(strmsg);
                        MyCaller.RefreshGrid();
                        MyCaller.Focus();
                        this.Close();
                    }
                    else
                    {
                        MessageHelpers.ShowWarning(strmsg);
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
        #endregion
        public frmUserGroup()
        {
            InitializeComponent();
            usrgrpbal = new UserGroupBAL();
            usrgrp = new tbl_000_USERGROUP();
            err = new ErrorProviderExtended();
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
            if (MyState != FormState.View)
            {
                if (MessageHelpers.ShowQuestion("Proceed with saving?") == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveRecord();
                }                
            }
            else
            {
                MyState = FormState.Edit;
                Init_Form();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmSearchListMenu();
                frm.AddedList = usrgrp.MenuList;
                frm.UserGroupCaller = this;
                FormHelpers.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FormHelpers.CursorWait(true);
            try
            {
                if (mgridRights.SelectedRows.Count < 1)
                {
                    throw new Exception("No selected User Rights!");
                }
                else
                {
                    var usrgrpcode = BPSUtilitiesV1.NZ(mgridRights.SelectedRows[0].Cells["colUserGroupCode"].Value, "").ToString();
                    var menuid = Convert.ToInt32(BPSUtilitiesV1.NZ(mgridRights.SelectedRows[0].Cells["colMenuID"].Value, 0));
                    if (usrgrpcode != "" && menuid != 0)
                    {
                        Removeright(usrgrpcode, menuid);
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
    }
}
