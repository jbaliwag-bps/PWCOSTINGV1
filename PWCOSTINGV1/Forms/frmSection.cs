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
    public partial class frmSection : MetroForm
    {
        public FormState MyState { get; set; }
        public string SectionCode { get; set; }
        public frmSectionList MyCaller { get; set; }

        SectionBAL sectbal;
        tbl_000_SECTION sect;
        ErrorProviderExtended err;

        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtSectionCode, "Required");
            err.Controls.Add(mtxtSectionDesc, "Required");
            err.CheckAndShowSummaryErrorMessage();
        }
        private void Init_Form()
        {
            try
            {
                var strheader = "Section";
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
                            mtxtSectionCode.ReadOnly = true;
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
                    sect.SECTIONCODE = mtxtSectionCode.Text;
                    sect.SECTIONDESC = mtxtSectionDesc.Text;
                    sect.IsActive = mcbActive.Checked;
                    sect.ISCOSTING = mcbCosting.Checked;
                    sect.SUPERVISOR = mtxtSectionSupervisor.Text;
                }
                else
                {
                    sect = sectbal.GetByID(SectionCode);
                    if (sect != null)
                    {
                        mtxtSectionCode.Text = sect.SECTIONCODE.ToString();
                        mtxtSectionDesc.Text = sect.SECTIONDESC;
                        mtxtSectionSupervisor.Text = sect.SUPERVISOR;
                        mcbActive.Checked = sect.IsActive;
                        mcbCosting.Checked = sect.ISCOSTING;
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
            mtxtSectionCode.ReadOnly = IsLocked;
            mtxtSectionDesc.ReadOnly = IsLocked;
            mtxtSectionSupervisor.ReadOnly = IsLocked;
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
                            if (sectbal.Save(sect))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (sectbal.Update(sect))
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
        public frmSection()
        {
            InitializeComponent();
            sectbal = new SectionBAL();
            sect = new tbl_000_SECTION();
            err = new ErrorProviderExtended();
        }

        private void frmSection_Load(object sender, EventArgs e)
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
                    SectionCode = sect.SECTIONCODE;
                    sectbal = new SectionBAL();
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
            if (mcbCosting.Checked == IsChecked)
            {
                mcbCosting.Text = "Yes";
            }
            else
            {
                mcbCosting.Text = "No";
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

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
