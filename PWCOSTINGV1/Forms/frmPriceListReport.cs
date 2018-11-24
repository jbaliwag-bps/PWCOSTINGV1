using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL;
namespace PWCOSTINGV1.Forms
{
    public partial class frmPriceListReport : MetroForm
    {
        CategoryBAL catbal;
        private Manual rptdetails = new Manual();
        List<tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY> tmp_SCsummlist;
        tmp_StndrdCostngSummBAL tmp_SCsummbal;
        private void frmPriceListReport_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = "Note: Click the button Generate Pricelist \r\n to refresh the computation. It will take \r\n several minutes to generate..";
            metroLabel3.Text = "Tip: Just leave the Category blank to view all..";
            mbtnPreviewWDetails.Text = "Preview PriceList Summary \r\n with Details";
            FillComboBox();
        }
        private void FillComboBox()
        {
            ListHelper.FillMetroCombo(mcboCategory, catbal.GetAll().Select(i => new { i.CATCODE }).Distinct().ToList(), "CATCODE", "CATCODE");
            mcboCategory.SelectedIndex = -1;
        }
        public frmPriceListReport()
        {
            InitializeComponent();
            catbal = new CategoryBAL();
            tmp_SCsummlist = new List<tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY>();
            tmp_SCsummbal = new tmp_StndrdCostngSummBAL();
        }

        private void mbtnGenerate_Click(object sender, EventArgs e)
        {
            var msg_succ = "Generating Successful!";
            var msg_failed = "No Data Generated!";
            if (MessageHelpers.ShowQuestion("Generate Report?") == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    FormHelpers.CursorWait(true);
                    rptdetails.SP_GeneratePriceList(UserSettings.LogInYear, BPSolutionsTools.BPSUtilitiesV1.NZ(mcboCategory.SelectedValue, "").ToString());
                    tmp_SCsummlist = tmp_SCsummbal.GetAll();
                    if (tmp_SCsummlist.Count > 0)
                    {
                        MessageHelpers.ShowInfo(msg_succ);
                    }
                    else
                    {
                        throw new Exception(msg_failed);
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
        }

        private void mbtnPreview_Click(object sender, EventArgs e)
        {
            PreviewReportSummary("rpt_PriceListSummary.rpt");
        }

        private void mbtnPreviewWDetails_Click(object sender, EventArgs e)
        {
            PreviewReportSummaryWDetails("sp_GeneratePriceListWDetails", "rpt_PriceListSummaryWDetails.rpt");
        }
        private void PreviewReportSummary(string strRptName)
        {
            try
            {
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv = new frm_ReportViewer();
                frv.report = new ReportTable();
                frv.report.ReportName = strRptName;
                frv.report.ReportPath = ObjectFinder.ReportPath;
                frv.report.SourceTable = rptdetails.SP_GeneratePriceList(UserSettings.LogInYear, BPSolutionsTools.BPSUtilitiesV1.NZ(mcboCategory.SelectedValue, "").ToString());
                if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data!");
                }
                frv.Text = "Price List Report";
                frv.StartPosition = FormStartPosition.CenterScreen;
                frv.Show();
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
        private void PreviewReportSummaryWDetails(string spname, string strRptName)
        {
            try
            {
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv = new frm_ReportViewer();
                frv.report = new ReportTable();
                frv.report.ReportName = strRptName;
                frv.report.ReportPath = ObjectFinder.ReportPath;
                frv.report.SourceTable = rptdetails.SP_GeneratePriceListWDetails(spname, UserSettings.LogInYear);
                if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data");
                }
                frv.Text = "Price List Report with Details";
                frv.StartPosition = FormStartPosition.CenterScreen;
                frv.Show();
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
