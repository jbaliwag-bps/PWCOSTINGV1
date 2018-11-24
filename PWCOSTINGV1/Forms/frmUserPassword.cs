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
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
namespace PWCOSTINGV1.Forms
{
    public partial class frmUserPassword : MetroForm
    {
        public frmMDI MyCaller { get; set; }
        UserBAL userbal;
        tbl_000_USER current_user;
        ErrorProviderExtended err;
        public frmUserPassword()
        {
            InitializeComponent();
            userbal = new UserBAL();
            err = new ErrorProviderExtended();
            current_user = new tbl_000_USER();
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangePass()
        {
            current_user = userbal.GetByUsername(UserSettings.Username);
            err.Clear();
            if (current_user.Password == mtxtOldPass.Text)
            {
                if (mtxtNewPass.Text != "" && mtxtConPass.Text != "")
                {
                    if (mtxtNewPass.Text == mtxtConPass.Text)
                    {
                        current_user.Password = mtxtConPass.Text;
                        if (MessageHelpers.ShowQuestion("Are you sure want to change your password?") == DialogResult.Yes)
                        {
                            if (userbal.Update(current_user))
                            {
                                MessageHelpers.ShowInfo("Password successfully changed.");
                                this.Close();
                            }
                            else
                            {
                                throw new Exception("Error occured!");
                            }
                        }
                    }
                    else
                    {
                        err.SetError(mtxtConPass, "Passwords entered does not match!");
                    }
                }
                else
                {
                    if (mtxtNewPass.Text == "")
                    {
                        err.SetError(mtxtNewPass, "Required");
                    }
                    else if (mtxtNewPass.Text == "")
                    {
                        err.SetError(mtxtConPass, "Required");
                    }
                    else
                    {
                        err.SetError(mtxtNewPass, "Required");
                        err.SetError(mtxtConPass, "Required");
                    }

                }
            }
            else
            {
                err.SetError(mtxtOldPass, "Please enter your old password!");
            }
            err.CheckAndShowSummaryErrorMessage();
        }
        private void mbtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);     
                ChangePass();
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
