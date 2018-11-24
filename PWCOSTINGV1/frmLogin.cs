using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using PWCOSTINGV1.Classes;
using PWCOSTING.BAL;
using PWCOSTING.BAL._000;
using PWCOSTING.BAL.Default;
using PWCOSTING.BO._000;
using PWCOSTING.BO.Default;

namespace PWCOSTINGV1
{
    public partial class frmLogin : MetroForm
    {
        #region "properties and declarations"
        public frmMDI MyCaller { get; set; }
        
        //business access layers
        UserBAL userbal;
        YearBAL yearbal;
        ErrorProviderExtended err;
        #endregion
        #region "user-defined methods"
        private void SetControlValidation()
        {
            err.ClearAllErrorMessages();
            err.Controls.Clear();
            err.Controls.Add(mtxtUsername, "Username");
            err.Controls.Add(mtxtPassword, "Password");
            err.Controls.Add(mcboLogYear, "Year");
        }
        private void Init_Form()
        {

            if (AppSettings.AppConnected == true)
            {
                this.mlblCompanyName.Text = AppSettings.CompanyProfile.COMPANY;
                this.mlblAppName.Text = AppSettings.AppName;
                this.mlblAppVersion.Text = "Version " + AppSettings.AppVersion;
                SetControlValidation();
                userbal = new UserBAL();
                yearbal = new YearBAL();
                GetList();
            }
            else
            {
                ShowSQLConfiguration();
            }
        }
        private void ShowSQLConfiguration()
        {
            var frm = new frmSQLConfiguration();
            frm.MyCaller = this;
            FormHelpers.ShowDialog(frm);
            Init_Form();
        }
        private void GetList()
        {
            try
            {
                ListHelper.FillMetroCombo(mcboLogYear, yearbal.GetAll().OrderByDescending(m => m.RecYear).ToList(), "RecYear", "RecYear");
                mcboLogYear.SelectedValue = DateTime.Today.Year;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
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
        public frmLogin()
        {
            //constructors
            InitializeComponent();           
            err = new ErrorProviderExtended();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Init_Form();
            AssignPrevLoginnedYear(false);
            AssignPrevLoginnedUser(false);
        }

        private void mlnkSQLConfig_Click(object sender, EventArgs e)
        {
            ShowSQLConfiguration();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageHelpers.ShowQuestion("Are you sure you want to exit the application?") == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void mbtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (IsValid())
                {
                    
                    var _user = userbal.LogMeIn(mtxtUsername.Text, mtxtPassword.Text);
                    if (_user != null)
                    {
                        //Get the computer name and ip
                        System.Net.IPHostEntry host; 
                        UserSettings.ComputerName = System.Net.Dns.GetHostName();
                         host = System.Net.Dns.GetHostEntry(UserSettings.ComputerName);
                        if(host.AddressList.Count() > 0) {
                            UserSettings.ComputerIP = System.Net.Dns.GetHostByName(UserSettings.ComputerName).AddressList[0].ToString();
                        }
                        //end here

                        AssignPrevLoginnedYear(true);
                        AssignPrevLoginnedUser(true);
                        PWCOSTINGV1.Properties.Settings.Default.Save();

                        UserSettings.Username = _user.Username;
                        UserSettings.CurrentUser = _user;
                        UserSettings.LogInYear = int.Parse(mcboLogYear.SelectedValue.ToString());
                        UserSettings.ServerName = PWCOSTINGV1.Properties.Settings.Default.strServerName;
                        UserSettings.DatabaseName = PWCOSTINGV1.Properties.Settings.Default.strDBName;
                        UserSettings.IsAuthenticated = true;
                        MyCaller.AuthenticateUser();
                        MyCaller.Show();
                        this.Close();
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
        private void AssignPrevLoginnedYear(Boolean IsAssign)
        {
            if (IsAssign)
            {
                PWCOSTINGV1.Properties.Settings.Default.intToLoginYear = Convert.ToInt32(mcboLogYear.SelectedValue);
            }
            else
            {
                mcboLogYear.SelectedValue = PWCOSTINGV1.Properties.Settings.Default.intToLoginYear;
            }
        }
        private void AssignPrevLoginnedUser(Boolean IsAssign)
        {
            if (IsAssign)
            {
                PWCOSTINGV1.Properties.Settings.Default.strToLoginUser = BPSolutionsTools.BPSUtilitiesV1.NZ(mtxtUsername.Text, "").ToString();
            }
            else
            {
                mtxtUsername.Text = BPSolutionsTools.BPSUtilitiesV1.NZ(PWCOSTINGV1.Properties.Settings.Default.strToLoginUser, "").ToString();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserSettings.IsAuthenticated != true)
            {
                Application.Exit();
            }
        }
    }
}
