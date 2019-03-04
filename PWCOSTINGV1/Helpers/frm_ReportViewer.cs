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
                    case "rpt_PreviewByWIP.rpt":
                        if (_report.ReportDoc.Subreports.Count > 0)
                        {
                            _report.ReportDoc.Subreports["subrptMaterials"].SetDataSource(_report.SubDataSources);
                            _report.ReportDoc.Subreports["subrptPI"].SetDataSource(_report.SubDataSources1);
                            //_report.ReportDoc.Subreports["subrptBagg"].SetDataSource(_report.SubDataSources2);
                            //_report.ReportDoc.Subreports["subrptAssy"].SetDataSource(_report.SubDataSources3);
                            //_report.ReportDoc.Subreports["subrptPlated"].SetDataSource(_report.SubDataSources4);
                        }
                        break;
                    case "rpt_PreviewItemDetails.rpt":
                        if (_report.ReportDoc.Subreports.Count > 0)
                        {
                            _report.ReportDoc.Subreports["subrptItemDetailsPI"].SetDataSource(_report.SubDataSources);
                            _report.ReportDoc.Subreports["subrptItemDetailsVP"].SetDataSource(_report.SubDataSources1);
                            //Sorry typo "subrptItemDetaisAssy" instead of "subrptItemDetailsAssy"
                            _report.ReportDoc.Subreports["subrptItemDetaisAssy"].SetDataSource(_report.SubDataSources2);
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
