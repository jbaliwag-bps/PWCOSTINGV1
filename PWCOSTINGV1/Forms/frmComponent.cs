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
    public partial class frmComponent : MetroForm
    {
        public int yearused { get; set; }
        public string partno { get; set; }
        public FormState MyState { get; set; }
        public frmComponentList MyCaller { get; set; }
        ComponentBAL combal;
        tbl_000_H_PART com;
        ErrorProviderExtended err;

        private void Init_Form()
        {
            try
            {
                var strheader = "Component";
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        strheader += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        tbl_000_H_PART currcom = new tbl_000_H_PART();
                        currcom = combal.GetAll().Where(i => i.YEARUSED == yearused && i.PartNo == partno).FirstOrDefault();
                        mlblLastUpdate.Text = currcom.UpdatedDate.ToString();
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
                throw ex;
            }
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    tbl_000_H_PART existcom = new tbl_000_H_PART();
                    existcom = combal.GetAll().Where(m => m.YEARUSED == UserSettings.LogInYear && m.PartNo == mtxtPartNo.Text).FirstOrDefault();
                    if (existcom == null)
                    {
                        com.YEARUSED = UserSettings.LogInYear;
                        com.PartNo = mtxtPartNo.Text;
                        com.CreatedDate = DateTime.Now;
                        com.CreatedBy = UserSettings.Username;
                        com.IsCopied = false;
                        com.CopyDate = DateTime.Now;
                        com.IsImported = false;
                        com.ImportDate = DateTime.Now;
                        com.ImportBy = UserSettings.Username;
                    }
                    com.PartName = mtxtPartName.Text;
                    com.WholeQty = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtWholeQty.Text, 0));
                    com.WholeUnit = mtxtWholeUnit.Text;
                    com.ConversionQty = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtConversionQty.Text, 0));
                    com.ConversionUnit = mtxtConversionUnit.Text;
                    com.WholePrice = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtWholePrice.Text, 0));
                    com.ConversionPrice = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtConversionPrice.Text, 0));
                    com.PreviousPrice = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtPreviousPrice.Text,0));
                    com.IsLocked = mcbLocked.Checked;
                    com.ExpDate = DateTime.Now;
                    com.UpdatedDate = DateTime.Now;
                    com.UpdatedBy = UserSettings.Username;
                }
                else
                {
                    com = combal.GetByID(yearused, partno);
                    if (com != null)
                    {
                        mtxtPartNo.Text = com.PartNo;
                        mtxtPartName.Text = com.PartName;
                        mcbLocked.Checked = com.IsLocked;
                        mtxtPreviousPrice.Text = String.Format("{0:n4}", com.PreviousPrice);
                        mtxtWholePrice.Text = String.Format("{0:n4}",com.WholePrice);
                        mtxtWholeQty.Text = String.Format("{0:n2}", com.WholeQty);
                        mtxtWholeUnit.Text = com.WholeUnit;
                        mtxtConversionPrice.Text = String.Format("{0:n4}",com.ConversionPrice);
                        mtxtConversionQty.Text = String.Format("{0:n2}",com.ConversionQty);
                        mtxtConversionUnit.Text = com.ConversionUnit;
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
            mtxtPartNo.ReadOnly = IsLocked;
            mtxtPartName.ReadOnly = IsLocked;
            mcbLocked.Enabled = !IsLocked;
            mtxtPreviousPrice.ReadOnly = IsLocked;
            mtxtWholePrice.ReadOnly = IsLocked;
            mtxtWholeQty.ReadOnly = IsLocked;
            mtxtWholeUnit.ReadOnly = IsLocked;
            mtxtConversionPrice.ReadOnly = IsLocked;
            mtxtConversionQty.ReadOnly = IsLocked;
            mtxtConversionUnit.ReadOnly = IsLocked;
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
                            if (combal.Save(com))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (combal.Update(com))
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
                    partno = com.PartNo;
                    yearused = com.YEARUSED;
                    combal = new ComponentBAL();
                    Init_Form();
                    break;
            }
        }
        public frmComponent()
        {
            InitializeComponent();
            combal = new ComponentBAL();
            com = new tbl_000_H_PART();
            err = new ErrorProviderExtended();
        }
        private void frmComponent_Load(object sender, EventArgs e)
        {
            Init_Form();
            CheckBoxSetting(true);
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CheckBoxSetting(Boolean IsChecked)
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
            CheckBoxSetting(true);
        }

        private void mtxtPreviousPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtWholePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtWholeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }

        private void mtxtConversionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
        private void mtxtConversionQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }


    }
}
