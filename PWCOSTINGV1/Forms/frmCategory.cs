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
    public partial class frmCategory : MetroForm
    {
        public string CategoryCode { get; set; }
        public int YearUsed { get; set; }
        public FormState MyState { get; set; }
        public frmCategoryList MyCaller { get; set; }

        CategoryBAL catbal;
        tbl_000_H_CATEGORY cat;
        ErrorProviderExtended err;
        private void Init_Form()
        {
            try
            {
                var strheader = "Category";
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
                            mtxtCategoryCode.ReadOnly = true;
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
                    cat.CATCODE = mtxtCategoryCode.Text;
                    cat.CATDESC = mtxtCategoryDesc.Text;
                    cat.RATECONVERSION = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtPhp.Text, 0));
                    cat.FIXEDCHARGELABOR = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFCLabor.Text, 0));
                    cat.FIXEDCHARGEFO = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFCFOverhead.Text, 0));
                    cat.PRODALLOWANCETIME = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtPTAllowance.Text, 0));
                    cat.FIXEDRATELOSS = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFRLMProcess.Text, 0));
                    cat.FIXEDRATEPROFIT = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFPRate.Text, 0));
                    cat.YENRATECONVERSION = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtYen.Text, 0));
                    cat.FIXEDRATEDEPNMOLD = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFCDMold.Text, 0));
                    cat.FIXEDRATEDEPNFILM = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtFCDFilm.Text, 0));
                    cat.OTHERPROCESSCOST = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtOPCost.Text, 0));
                    cat.YEARUSED = UserSettings.LogInYear;
                    cat.MoldSetup = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtMoldSetup.Text, 0));
                    cat.LotSize = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtLotSize.Text, 0));
                    cat.IsDependent = mcbDependent.Checked;
                    cat.IsActive = mcbActive.Checked;
                }
                else
                {
                    cat = catbal.GetByID(CategoryCode, YearUsed);
                    if (cat != null)
                    {
                        mtxtCategoryCode.Text = cat.CATCODE;
                        mtxtCategoryDesc.Text = cat.CATDESC;
                        mtxtPhp.Text = cat.RATECONVERSION.ToString();
                        mtxtFCLabor.Text = cat.FIXEDCHARGELABOR.ToString();
                        mtxtFCFOverhead.Text = cat.FIXEDCHARGEFO.ToString();
                        mtxtPTAllowance.Text = cat.PRODALLOWANCETIME.ToString();
                        mtxtFRLMProcess.Text = cat.FIXEDRATELOSS.ToString();
                        mtxtFPRate.Text = cat.FIXEDRATEPROFIT.ToString();
                        mtxtYen.Text = cat.YENRATECONVERSION.ToString();
                        mtxtFCDMold.Text = cat.FIXEDRATEDEPNMOLD.ToString();
                        mtxtFCDFilm.Text = cat.FIXEDRATEDEPNFILM.ToString();
                        mtxtOPCost.Text = cat.OTHERPROCESSCOST.ToString();
                        mtxtMoldSetup.Text = cat.MoldSetup.ToString();
                        mtxtLotSize.Text = cat.LotSize.ToString();
                        mcbDependent.Checked = cat.IsDependent;
                        mcbActive.Checked = cat.IsActive;
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
            mtxtCategoryCode.ReadOnly = IsLocked;
            mtxtCategoryDesc.ReadOnly = IsLocked;
            mtxtPhp.ReadOnly = IsLocked;
            mtxtFCLabor.ReadOnly = IsLocked;
            mtxtFCFOverhead.ReadOnly = IsLocked;
            mtxtPTAllowance.ReadOnly = IsLocked;
            mtxtFRLMProcess.ReadOnly = IsLocked;
            mtxtFPRate.ReadOnly = IsLocked;
            mtxtYen.ReadOnly = IsLocked;
            mtxtFCDMold.ReadOnly = IsLocked;
            mtxtFCDFilm.ReadOnly = IsLocked;
            mtxtOPCost.ReadOnly = IsLocked;
            mtxtMoldSetup.ReadOnly = IsLocked;
            mtxtLotSize.ReadOnly = IsLocked;
            mcbDependent.Enabled = !IsLocked;
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
                            if (catbal.Save(cat))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (catbal.Update(cat))
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
                    CategoryCode = cat.CATCODE;
                    catbal = new CategoryBAL();
                    Init_Form();
                    break;
            }
        }

        private void mtxtPhp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal decPhp = Convert.ToDecimal(this.mtxtPhp.Text);
                mlblPhp.Text = decPhp.ToString();
            }
            catch
            {
                mtxtPhp.Text = "0";
            }
        }

        private void mtxtYen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal decYen = Convert.ToDecimal(this.mtxtYen.Text);
                mlblYen.Text = decYen.ToString();
            }
            catch
            {
                mtxtYen.Text = "0";
            }
        }
        public frmCategory()
        {
            InitializeComponent();
            catbal = new CategoryBAL();
            cat = new tbl_000_H_CATEGORY();
            err = new ErrorProviderExtended();
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Init_Form();
            ChbxSetting(true);
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (mcbDependent.Checked == IsChecked)
            {
                mcbDependent.Text = "Yes";
            }
            else
            {
                mcbDependent.Text = "No";
            }
        }

        private void mcbActive_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

        private void mcbDependent_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }

        private void mtpCharges_Click(object sender, EventArgs e)
        {

        }

        private void mtxtPhp_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFCLabor_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFCFOverhead_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFCDMold_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFCDFilm_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtYen_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFPRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtFRLMProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtPTAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtOPCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtMoldSetup_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtLotSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
    }
}
