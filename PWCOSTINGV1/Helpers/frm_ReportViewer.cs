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
    public partial class frm_ReportViewer : MetroForm
    {
        public ReportTable report;
        public frm_ReportViewer()
        {
            InitializeComponent();
            report = new ReportTable(); 
        }
        private void LoadReport()
        {
            try
            {
                ReportManager.LoadReport(report);
                var _report = report;
                switch (report.ReportName)
                {
                    case "rpt_StandardCostingF2017.rpt":
                        if (_report.ReportDoc.Subreports.Count > 0)
                        {
                            _report.ReportDoc.Subreports["rpt_Signatory"].SetDataSource(_report.SubDataSources);
                        }
                        break;
                }
                CRViewer.ReportSource = _report.ReportDoc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HideExtraButtonCRV()
        {
            this.CRViewer.ShowCopyButton = false;
            this.CRViewer.ShowParameterPanelButton = false;
            this.CRViewer.ShowTextSearchButton = false;
            this.CRViewer.ShowLogo = false;

            this.CRViewer.ShowGroupTreeButton = false;
        }
        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {
            LoadReport();
            HideExtraButtonCRV();
            this.WindowState = FormWindowState.Maximized;
            this.CRViewer.EnableDrillDown = false;
        }
    }
}
