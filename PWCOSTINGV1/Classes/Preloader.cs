using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTINGV1.Helpers;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Windows.Forms;

namespace PWCOSTINGV1.Classes
{
    public class Preloader
    {
        public static void Preload()
        {
            Task.Factory.StartNew(() =>
            {
                using (ReportDocument ReportPreLoad = new ReportDocument())
                {
                    ReportPreLoad.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports/rpt_PreLoad.rpt"));
                    frm_Preloader printpreview = new frm_Preloader();
                    printpreview.rpt = ReportPreLoad;
                    Application.Run(printpreview);
                }

            }, TaskCreationOptions.HideScheduler);
        }
    }
}
