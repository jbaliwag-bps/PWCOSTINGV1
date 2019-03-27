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
using PWCOSTING.BAL._100;
using PWCOSTING.BO._100;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPMT1 : MetroForm
    {
        public string pno { get; set; }
        public FormState MyState { get; set; }
        public frmWIPMT1List MyCaller { get; set; }

        WIPMTBAL mtbal;
        tbl_100_WIP_MT mt;
        ErrorProviderExtended err;
        private void Init_Form()
        {
            try
            {
                var strheader = "WIP MT";
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
            mtxtUsage.ReadOnly = IsLocked;
            mtxtProcess.ReadOnly = IsLocked;
            mtxtVendor.ReadOnly = IsLocked;
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    mt.YEARUSED = UserSettings.LogInYear;
                    mt.PartNo = mtxtPartNo.Text;
                    mt.PartName = mtxtPartName.Text;
                    mt.Usage = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtUsage.Text, 0));
                    mt.Process = mtxtProcess.Text;
                    mt.Vendor = mtxtVendor.Text;
                }
                else
                {
                    mt = mtbal.GetByID(UserSettings.LogInYear, pno);
                    if (mt != null)
                    {
                        mtxtPartNo.Text = mt.PartNo;
                        mtxtPartName.Text = mt.PartName;
                        mtxtUsage.Text = mt.Usage.ToString();
                        mtxtProcess.Text = mt.Process;
                        mtxtVendor.Text = mt.Vendor;
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
        private void SaveRecord()
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (IsValid())
                {
                    var isSucess = false;
                    var msg = "";
                    AssignRecord(true);
                    switch (MyState)
                    {
                        case FormState.Add:
                            msg = "Saving";
                            if (mtbal.Save(mt))
                            {
                                isSucess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (mtbal.Update(mt))
                            {
                                isSucess = true;
                            }
                            break;
                    }
                    if (isSucess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        MyCaller.FillComboBoxes();
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
                    pno = mt.PartNo;
                    mtbal = new WIPMTBAL();
                    Init_Form();
                    break;
            }
        }
        public frmWIPMT1()
        {
            InitializeComponent();
            mtbal = new WIPMTBAL();
            mt = new tbl_100_WIP_MT();
            err = new ErrorProviderExtended();
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWIPMT1_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void mtxtUsage_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
    }
}
