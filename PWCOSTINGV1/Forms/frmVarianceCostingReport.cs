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
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._000;
using BPSolutionsTools;
using PWCOSTINGV1.Helpers;
using PWCOSTING.BAL;

namespace PWCOSTINGV1.Forms
{
    public partial class frmVarianceCostingReport : MetroForm
    {
        private Manual rptdetails = new Manual();
        public frmVarianceCostingReport()
        {
            InitializeComponent();
        }
        private void frmVarianceCostingReport_Load(object sender, EventArgs e)
        {
            FillFields();
        }
        private void FillFields()
        {
            //ComboBox
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            foreach (string m in months)
            {
                if (m != string.Empty)
                {
                    mcboMonth.Items.Add(m);
                }
            }
            mcboMonth.SelectedIndex = 0;

            //TextBox
            mtxtYear.Text = UserSettings.LogInYear.ToString();

        }
        private void mbtnGenerate_Click(object sender, EventArgs e)
        {
            var msg_succ = "Generating Successful!";
            var msg_failed = "No Data Generated!";
            try
            {
                FormHelpers.CursorWait(true);
                var checkdt = rptdetails.SP_GenerateVariance(mcboMonth.SelectedIndex + 1, Convert.ToInt16(mtxtYear.Text));
                    if (checkdt == null || checkdt.Rows.Count == 0)
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

        private void mtxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress_NoPoint(sender, e);
        }

        private void mbtnPreview_Click(object sender, EventArgs e)
        {
            Preview("rpt_VarianceCosting.rpt");
        }
        private void Preview(string strRptName)
        {
            try
            {
                FormHelpers.CursorWait(true);
                frm_ReportViewer frv1 = new frm_ReportViewer();
                frv1.report = new ReportTable();
                frv1.report.ReportName = strRptName;
                frv1.report.ReportPath = ObjectFinder.ReportPath;
                frv1.report.SourceTable = rptdetails.SP_GenerateVariance(mcboMonth.SelectedIndex+1, Convert.ToInt16(mtxtYear.Text));
                if (frv1.report.SourceTable == null || frv1.report.SourceTable.Rows.Count == 0)
                {
                    throw new Exception("Report no Data!");
                }
                frv1.Text = "Variance Costing Report";
                frv1.StartPosition = FormStartPosition.CenterScreen;
                frv1.Show();
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
