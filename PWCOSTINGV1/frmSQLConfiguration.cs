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
using PWCOSTINGV1.Helpers;
using PWCOSTING.BAL;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
namespace PWCOSTINGV1
{
    public partial class frmSQLConfiguration : MetroForm
    {
        #region "properties and declarations"
        CompanyBAL compbal;
        tbl_000_COMPANY comp;
        Boolean IsLoading;
        Boolean IsConfigured = false;
        public frmLogin MyCaller { get; set; }
        #endregion

        #region "User-defined Methods"
        private void Init_Form()
        {
            //get Application Settings for Connection String.
            AssignRecords(false);
        }
        private void AssignRecords(Boolean IsAssign)
        {

            if (IsAssign)
            {
                AppConnectionString.ServerName = mtxtServerName.Text;
                AppConnectionString.ServerUserID = mtxtUserID.Text;
                AppConnectionString.ServerPassword = mtxtPassword.Text;
                AppConnectionString.DBName =mtxtDBName.Text;
                AppConnectionString.UpdateSourcePath = mtxtUpdateSource.Text;
                AppConnectionString.IsTrusted = mrbTrusted.Checked;

                PWCOSTINGV1.Properties.Settings.Default.strServerName = AppConnectionString.ServerName;
                PWCOSTINGV1.Properties.Settings.Default.blnIsTrusted = AppConnectionString.IsTrusted;
                PWCOSTINGV1.Properties.Settings.Default.strUserID = AppConnectionString.ServerUserID;
                PWCOSTINGV1.Properties.Settings.Default.strPassword = AppConnectionString.ServerPassword;
                PWCOSTINGV1.Properties.Settings.Default.strDBName = AppConnectionString.DBName;
                PWCOSTINGV1.Properties.Settings.Default.strUpdateSource = AppConnectionString.UpdateSourcePath;
                PWCOSTINGV1.Properties.Settings.Default.cnString = AppConnectionString.ConnectionString;
            }
            else
            {
                AppConnectionString.ServerName = PWCOSTINGV1.Properties.Settings.Default.strServerName;
                AppConnectionString.IsTrusted = PWCOSTINGV1.Properties.Settings.Default.blnIsTrusted;
                AppConnectionString.ServerUserID = PWCOSTINGV1.Properties.Settings.Default.strUserID;
                AppConnectionString.ServerPassword = PWCOSTINGV1.Properties.Settings.Default.strPassword;
                AppConnectionString.DBName = PWCOSTINGV1.Properties.Settings.Default.strDBName;
                AppConnectionString.UpdateSourcePath = PWCOSTINGV1.Properties.Settings.Default.strUpdateSource;

                mtxtServerName.Text = AppConnectionString.ServerName;
                mtxtUserID.Text = AppConnectionString.ServerUserID;
                mtxtPassword.Text = AppConnectionString.ServerPassword;
                mtxtDBName.Text = AppConnectionString.DBName;
                mtxtUpdateSource.Text = AppConnectionString.UpdateSourcePath;
                mrbTrusted.Checked = AppConnectionString.IsTrusted;
                mrbSQLAccount.Checked = !AppConnectionString.IsTrusted;
                LockAuth(mrbTrusted.Checked);
            }
        }
        private void LockAuth(Boolean IsLock)
        {
            mtxtUserID.ReadOnly = IsLock;
            mtxtPassword.ReadOnly = IsLock;
        }

        private void TestConnection()
        {
            try
            {
                AssignRecords(true);
                SetBALConnection.SetConnectionString(AppConnectionString.ConnectionString);
                compbal = new CompanyBAL();
                comp = compbal.GetByID(1);
                AppSettings.CompanyProfile = comp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public frmSQLConfiguration()
        {
            InitializeComponent();            
        }

        private void frmSQLConfiguration_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            Init_Form();
            mtxtServerName.Focus();
            IsLoading = false;
        }

        private void mbtnBrowse_Click(object sender, EventArgs e)
        {
            fbdUpdateSource.SelectedPath = mtxtUpdateSource.Text;
            fbdUpdateSource.ShowNewFolderButton = false;
            var result = fbdUpdateSource.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.Cancel)
            {
                mtxtUpdateSource.Text = fbdUpdateSource.SelectedPath;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageHelpers.ShowQuestion("Are you sure you want to save settings?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FormHelpers.CursorWait(true);
                    TestConnection();
                    PWCOSTINGV1.Properties.Settings.Default.Save();
                    MessageHelpers.ShowInfo("Connection Settings updated successfully.");
                    AppSettings.AppConnected = true;
                    this.Close();
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
        private void mbtnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
                TestConnection();
                Preloader.Preload();
                MessageHelpers.ShowInfo("Test connection successful.");
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
        private void mrbTrusted_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsLoading)
            {
                LockAuth(mrbTrusted.Checked);
            }
        }

        private void frmSQLConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppSettings.AppConnected == false)
            {
                if (MessageHelpers.ShowQuestion("Would you like to exit the application?") == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
