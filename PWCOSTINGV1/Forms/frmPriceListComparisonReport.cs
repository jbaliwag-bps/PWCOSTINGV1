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
using PWCOSTING.BO.Default;
using PWCOSTING.BAL.Default;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL;
using BPSolutionsTools;
namespace PWCOSTINGV1.Forms
{
    public partial class frmPriceListComparisonReport : MetroForm
    {
        CategoryBAL catbal;
        YearBAL yrbal;
        List<tbl_YEAR> yrs;
        private Manual rptdetails = new Manual();
        private void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            try
            {
                //Categories
                ListHelper.FillMetroCombo(mcboCategory, catbal.GetAll().Select(i => new { i.CATCODE }).Distinct().ToList(), "CATCODE", "CATCODE");
                mcboCategory.SelectedIndex = -1;

                //First Year
                ListHelper.FillMetroCombo(mcbofrstYear, yrbal.GetAll().Select(i => new {i.RecYear}).Distinct().ToList(), "RecYear", "RecYear");
                mcbofrstYear.SelectedValue = UserSettings.LogInYear;
               //Second Year
                ListHelper.FillMetroCombo(mcboscndYear, yrbal.GetAll().Select(i => new { i.RecYear }).Distinct().ToList(), "RecYear", "RecYear");
                var yearlist = yrbal.GetAll().Select(s => s.RecYear).ToList();
                if (yearlist.Contains(UserSettings.LogInYear - 1))
                    mcboscndYear.SelectedValue = UserSettings.LogInYear - 1;
                else if (yearlist.Contains(UserSettings.LogInYear + 1))
                    mcboscndYear.SelectedValue = UserSettings.LogInYear + 1;
                else
                    mcboscndYear.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void frmPriceListComparisonReport_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        public frmPriceListComparisonReport()
        {
            InitializeComponent();
            yrbal = new YearBAL();
            yrs = new List<tbl_YEAR>();
            catbal = new CategoryBAL();
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
                    if (rptdetails.SP_GeneratePriceListComparison(Convert.ToInt32(mcbofrstYear.SelectedValue), Convert.ToInt32(mcboscndYear.SelectedValue), BPSUtilitiesV1.NZ(mcboCategory.SelectedValue, "").ToString()).Rows.Count == 0)
                    {
                        throw new Exception(msg_failed);
                    }
                    else
                    {
                        MessageHelpers.ShowInfo(msg_succ);
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
        private void PreviewComparison(string strRptName)
        {
            try
            {
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv = new frm_ReportViewer();
                frv.report = new ReportTable();
                frv.report.ReportName = strRptName;
                frv.report.ReportPath = ObjectFinder.ReportPath;
                frv.report.SourceTable = rptdetails.SP_GeneratePriceListComparison(Convert.ToInt32(mcbofrstYear.SelectedValue), Convert.ToInt32(mcboscndYear.SelectedValue), BPSUtilitiesV1.NZ(mcboCategory.SelectedValue, "").ToString());
                if (frv.report.SourceTable == null || frv.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data");
                }
                frv.Text = "Price List Comparison Report";
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
        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewComparison("rpt_PriceListComparison.rpt");
        }
    }
}
