using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PWCOSTINGV1.Classes;
using MetroFramework.Forms;

namespace PWCOSTINGV1.Helpers
{
    public partial class frm_Preloader : MetroForm
    {
        public ReportDocument rpt { get; set; }
        private bool allowshowdisplay = false;
        public frm_Preloader()
        {
            InitializeComponent();
        }
        private void frm_Preloader_Load(object sender, EventArgs e)
        {
            CRViewer.ReportSource = rpt;
        }
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }
    }
}
