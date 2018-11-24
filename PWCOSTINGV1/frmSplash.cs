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
using MetroFramework.Components;
using MetroFramework;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
namespace PWCOSTINGV1
{
    public partial class frmSplash : MetroForm
    {
        private void Init_Form()
        {
            this.mlblAppName.Text = AppSettings.AppName;
            this.mlblAppVersion.Text = "Version " + AppSettings.AppVersion;
            this.mlblAppVendor.Text = "Powered by: " + AppSettings.AppVendor;
        }
        public frmSplash()
        {
            InitializeComponent();
            this.StyleManager = MyFormStyles.GetStyleManager(this);
            Init_Form();
            this.Focus();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Preloader.Preload();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void metroProgressBar1_Validating(object sender, CancelEventArgs e)
        {
            if (AppSettings.AppConnected == true) {
                this.mlblSystemStatus.Text = "Connected...";
            }
        }
    }
}
