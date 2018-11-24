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
using PWCOSTING.BAL.Default;
using PWCOSTING.BO.Default;

namespace PWCOSTINGV1.Forms
{
    public partial class frmCompanyProfile : MetroForm
    {
        #region "properties and declarations"
        public FormState MyState { get; set; }
        private int compID { get { return 1; } }

        YearBAL yearbal;
        tbl_000_FXSP fxsp;
        tbl_YEAR year;
        tbl_000_H_CATEGORY cat;
        CompanyBAL compbal;
        tbl_000_COMPANY comp;
        ErrorProviderExtended err;
        #endregion  

        #region "user-defined methods"
        private void SetControlValidation()
        {
            err.Controls.Clear();
            err.Controls.Add(mtxtCompany, "Required");
            err.Controls.Add(mtxtShortName, "Required");

            err.CheckAndShowSummaryErrorMessage();
        }
        private void Init_Form()
        {
            try
            {
                var strheader = "My Company";
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        AssignRecord(false);
                        LockFields(false);
                        if (MyState == FormState.View)
                        {
                            LockFields(true);
                            strheader += " - View";
                            mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
                            mbtnSave.Focus();
                        }
                        else
                        {
                            mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
                            strheader += " - Edit";
                        }
                        break;
                }
                this.Text = strheader;
                mTCCompany.SelectedIndex = 0;
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
                    comp.COMPANY = mtxtCompany.Text;
                    comp.SHORTNAME = mtxtShortName.Text;
                    comp.ADDRESS1 = mtxtAddress1.Text;
                    comp.ADDRESS2 = mtxtAddress2.Text;
                    //comp.IsActive = mcbActive.Checked;
                    comp.TELNOS = mtxtTelNos.Text;
                    comp.MOBILENOS = mtxtMobileNos.Text;
                    comp.FAXNOS = mtxtFaxNos.Text;
                    comp.EMAIL = mtxtEmail.Text;
                }
                else
                {
                    comp = compbal.GetByID(compID);
                    if (comp != null)
                    {
                        mtxtCompany.Text=comp.COMPANY;
                        mtxtShortName.Text=comp.SHORTNAME;
                        mtxtAddress1.Text=comp.ADDRESS1;
                        mtxtAddress2.Text=comp.ADDRESS2;
                        //mcbActive.Checked=comp.IsActive;
                        mtxtTelNos.Text=comp.TELNOS;
                        mtxtMobileNos.Text=comp.MOBILENOS;
                        mtxtFaxNos.Text=comp.FAXNOS;
                        mtxtEmail.Text=comp.EMAIL;
                        
                    }
                    else
                    {
                        throw new Exception("Record doesn't exist!");
                    }
                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RefreshGrid()
        {
            try
            {
                var list = yearbal.GetAll().Select(i => new{ i.RecID, i.RecYear, i.IsLocked}).Distinct().OrderBy(y => y.RecYear).ToList();
                mgridYearList.DataSource = list;
                mlblNoRecords.Text = comp.YearList.Count.ToString() + " record(s)";
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void LockFields(Boolean IsLocked)
        {
            mtxtCompany.ReadOnly = IsLocked;
            mtxtShortName.ReadOnly = IsLocked;
            mtxtAddress1.ReadOnly = IsLocked;
            mtxtAddress2.ReadOnly = IsLocked;
            mtxtTelNos.ReadOnly = IsLocked;
            mtxtMobileNos.ReadOnly = IsLocked;
            mtxtFaxNos.ReadOnly = IsLocked;
            mtxtEmail.ReadOnly = IsLocked;
            //mcbActive.Enabled = !IsLocked;
        }

        private void SaveRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (IsValid())
                {
                    AssignRecord(true);
                    if (compbal.Update(comp))
                    {
                        MessageHelpers.ShowInfo("Update Successful!");
                        MyState = FormState.View;
                        Init_Form();
                    }
                    else
                    {
                        MessageHelpers.ShowWarning("Update Failed!");
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
        public frmCompanyProfile()
        {
            InitializeComponent();
            yearbal = new YearBAL();
            year = new tbl_YEAR();
            fxsp = new tbl_000_FXSP();
            compbal = new CompanyBAL();
            comp = new tbl_000_COMPANY();
            err = new ErrorProviderExtended();
        }

        private void frmCompanyProfile_Load(object sender, EventArgs e)
        {
            MyState = FormState.View;
            Init_Form();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            if (MyState == FormState.Edit)
            {
                MyState = FormState.View;
                Init_Form();
            }
            else
            {
                this.Close();
            }
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            if (MyState == FormState.Edit)
            {
                if (MessageHelpers.ShowQuestion("Are you sure you want to update record?") == System.Windows.Forms.DialogResult.Yes)
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

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmCompanyYear();
            form.MyCaller = this;
            FormHelpers.ShowDialog(form);
        }

        private void mbtnLock_Click(object sender, EventArgs e)
        {
            Lock();
        }
        public void AssignforLocking(Boolean IsLockYear)
        {
            var recid = Convert.ToInt32(mgridYearList.SelectedRows[0].Cells["colRecID"].Value);
            var recyear = mgridYearList.SelectedRows[0].Cells["colYear"].Value.ToString();
            try
            {
                if (IsLockYear)
                {
                    year.RecID = recid;
                    year.RecYear = Convert.ToInt32(recyear);
                    year.IsLocked = true;
                }
                else
                {
                    if(year == null)
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
        public void Lock()
        {
            if (MessageHelpers.ShowQuestion("Are you sure want to lock this year?") == DialogResult.Yes)
            {
                var LockingisSuccess = false;
                var msg = "Locking";
                AssignforLocking(true);
                if (yearbal.Lock(year))
                {
                    LockingisSuccess = true;
                }
                if (LockingisSuccess)
                {
                    MessageHelpers.ShowInfo(msg + " Successful!");
                    RefreshGrid();
                }
                else
                {
                    MessageHelpers.ShowInfo(msg + " Failed!");
                }
            }
        }

        private void mbtnRemove_Click(object sender, EventArgs e)
        {
            RemoveYear();
        }
        public void RemoveYear()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var recyear = mgridYearList.SelectedRows[0].Cells["colYear"].Value.ToString();
                if (MessageHelpers.ShowQuestion("Are you sure you want to remove this year?") == DialogResult.Yes)
                {
                    var RemovingisSuccess = false;
                    var msg = "Removing";
                    fxsp = yearbal.CheckFXSPYear(Convert.ToInt32(recyear));
                    cat = yearbal.CheckCatYear(Convert.ToInt32(recyear));
                    if (yearbal.Remove(Convert.ToInt32(recyear)))
                    {
                        RemovingisSuccess = true;
                    }
                    if (RemovingisSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        RefreshGrid();
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
        
    }
}
