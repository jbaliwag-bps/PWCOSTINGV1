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
    public partial class frmUserGroup : MetroForm
    {
        #region "properties and declarations"
        public FormState MyState { get; set; }
        public string groupid { get; set;  }
        public frmUserGroupList MyCaller { get; set; }

        UserGroupBAL compbal;
        tbl_000_USERGROUP comp;
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
                if (comp.MenuList == null)
                {
                     comp.MenuList = new List<tbl_000_USERGROUP_MENUS>();
                }
                mgridRights.DataSource = new List<tbl_000_USERGROUP_MENUS>();
                mgridRights.DataSource = comp.MenuList;
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
                            comp.MenuList.Add(userright);
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
        private void Removeright(int menuID)
        {
            try
            {
                var userright = comp.MenuList.SingleOrDefault(m => m.MenuID == menuID);
                if (userright != null)
                {
                    comp.MenuList.Remove(userright);
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
                        comp.GroupID = Guid.NewGuid().ToString();
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
                    comp.UserGroupCode = mtxtGroupCode.Text;
                    comp.UserGroupDesc = mtxtGroupDesc.Text;
                    comp.Remarks = mtxtRemarks.Text;                    
                    comp.IsActive = mcbActive.Checked;   
                 
                }
                else
                {
                    comp = compbal.GetByID(groupid);
                    RefreshList();
                    if (comp != null)
                    {
                        mtxtGroupCode.Text=comp.UserGroupCode;
                        mtxtGroupDesc.Text=comp.UserGroupDesc;
                        mtxtRemarks.Text=comp.Remarks;
                        mcbActive.Checked=comp.IsActive;    
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
                        if (compbal.Save(comp))
                        {
                            strmsg = "Saving Successful!";
                            blnsuccess = true;
                        }                 
                    }
                    if (MyState == FormState.Edit)
                    {
                        strmsg = "Updating Failed!";
                        if (compbal.Update(comp))
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
            compbal = new UserGroupBAL();
            comp = new tbl_000_USERGROUP();
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
                frm.AddedList = comp.MenuList;
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
            try
            {
                if (mgridRights.SelectedRows.Count < 1)
                {
                    throw new Exception("No selected User Rights!");
                }
                var selIndex = mgridRights.SelectedRows[0].Cells["colMenuID"].Value;
                
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
    }
}
