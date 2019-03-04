using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PWCOSTINGV1.Classes;
using MetroFramework;
using PWCOSTING.BAL;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;

namespace PWCOSTINGV1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetTheme();
            SetAppSettings();
            SetDBConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMDI());
        }
        private static void SetTheme()
        {
            MyFormStyles.MyStyle = MetroThemeStyle.Light;
            MyFormStyles.MyColor = MetroColorStyle.Blue;
        }

        private static void SetAppSettings()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            AppSettings.AppName = fvi.ProductName;
            AppSettings.AppVersion = fvi.FileVersion;
            AppSettings.AppVendor = fvi.CompanyName;
            AppSettings.AppCopyright = fvi.LegalCopyright;
            AppSettings.AppTrademark = fvi.LegalTrademarks;
            AppSettings.AppConnected = false;
        }

        private static void SetDBConnection()
        {
            var cnstring = PWCOSTINGV1.Properties.Settings.Default.cnString;
            SetBALConnection.SetConnectionString(cnstring);
            TestConnection();
        }

        private static void TestConnection()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start(); //open splash
            try
            {
                CompanyBAL compbal;
                compbal = new CompanyBAL();
                AppSettings.CompanyProfile = compbal.GetByID(1);
                AppSettings.AppConnected = true;
                Preloader.Preload(); //Preload Report
                //Cache.Refresh();
                t.Abort(); //close splash
            }
            catch (Exception ex)
            {
                t.Abort(); //close splash
                MessageHelpers.ShowError(ex.Message);
                AppSettings.AppConnected = false;

            }
        }
        private static void Loading()
        {
            Application.Run(new frmSplash());
        }
    }
}
