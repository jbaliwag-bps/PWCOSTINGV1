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
using PWCOSTINGV1.Helpers;
using PWCOSTING.BO._000;
using PWCOSTING.BAL.Default;
using BPSolutionsTools;
using PWCOSTING.BAL;

namespace PWCOSTINGV1.Forms
{
    public partial class frmStandardCostingReport : MetroForm
    {
        FormState MyState;
        ErrorProviderExtended err;
        YearBAL yearbal;
        SignatoryBAL signabal;
        tbl_SIGNATORY signa;
        List<tbl_SIGNATORY> signalist;
        List<tbl_SIGNATORY> signalist_existing;

        ItemBAL itmbal;
        tbl_000_H_ITEM itm;

        DataTable dtgnrtd = new DataTable();
        private Manual rptdetails = new Manual();

        long minid;

        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            minid = Convert.ToInt64(BPSUtilitiesV1.NZ(signabal.GetAll().Select(s => s.RecID).FirstOrDefault(), 1));
            GetList();
            MyState = FormState.View;
            mbtnModify.Text = "Modify";
            LockFields(true);

            err.BlinkRate = 7;
        }
        private void ItemDesc()
        {
            string selecteditemno = BPSUtilitiesV1.NZ(mtxtItemNo.Text, "").ToString();
            itm = itmbal.GetByID(UserSettings.LogInYear, selecteditemno);
            if (itm != null)
            {
                mtxtItemDesc.Text = BPSUtilitiesV1.NZ(itm.Description, "").ToString();
            }
        }
        private void FilltxtAutoComplete()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var source = itmbal.GetItemNos(UserSettings.LogInYear);
            foreach (string i in source)
            {
                collection.Add(i);
            }
            mtxtItemNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtxtItemNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mtxtItemNo.AutoCompleteCustomSource = collection;
        }

        private void StrictDate()
        {
            var selected = mdtDate.Value;
            if (mdtDate.Value.Year <= UserSettings.LogInYear)
            {
                mdtDate.Value = new DateTime(UserSettings.LogInYear, selected.Month, selected.Day);
            }
        }
        private void LockFields(Boolean IsLock)
        {
            mtxtApprName1.ReadOnly = IsLock;
            mtxtApprName2.ReadOnly = IsLock;
            mtxtApprPosition1.ReadOnly = IsLock;
            mtxtApprPosition2.ReadOnly = IsLock;
            mtxtPrepName1.ReadOnly = IsLock;
            mtxtPrepName2.ReadOnly = IsLock;
            mtxtPrepPosition1.ReadOnly = IsLock;
            mtxtPrepPosition2.ReadOnly = IsLock;
            mtxtReviName1.ReadOnly = IsLock;
            mtxtReviName2.ReadOnly = IsLock;
            mtxtReviPosition1.ReadOnly = IsLock;
            mtxtReviPosition2.ReadOnly = IsLock;

            mbtnGenerate.Enabled = IsLock;
            mbtnExport.Enabled = IsLock;
            mbtnPrint.Enabled = IsLock;
            mbtnPreview.Enabled = IsLock;
            mbtnCancel.Enabled = !IsLock;
        }
        private void GetList()
        {
            try
            {
                mtxtYear.Text = UserSettings.LogInYear.ToString();
                //if there were existing record
                signalist_existing = signabal.GetAll().Where(w => w.ReportName == this.Text).ToList();
                if (signalist_existing.Count > 0)
                {
                    foreach (tbl_SIGNATORY s in signalist_existing)
                    {
                        if (s.RecID == minid)
                        {
                            mtxtApprName1.Text = s.SignName;
                            mtxtApprPosition1.Text = s.SignPosition;
                        }
                        else if (s.RecID == (minid+1))
                        {
                            mtxtApprName2.Text = s.SignName;
                            mtxtApprPosition2.Text = s.SignPosition;
                        }
                        else if (s.RecID == (minid+2))
                        {
                            mtxtPrepName1.Text = s.SignName;
                            mtxtPrepPosition1.Text = s.SignPosition;
                        }
                        else if (s.RecID == (minid + 3))
                        {
                            mtxtPrepName2.Text = s.SignName;
                            mtxtPrepPosition2.Text = s.SignPosition;
                        }
                        else if (s.RecID == (minid + 4))
                        {
                            mtxtReviName1.Text = s.SignName;
                            mtxtReviPosition1.Text = s.SignPosition;
                        }
                        else if (s.RecID == (minid + 5))
                        {
                            mtxtReviName2.Text = s.SignName;
                            mtxtReviPosition2.Text = s.SignPosition;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        //This function is supposed to check if any of the textboxes is null or ""
        private void CheckTBox()
        {
            err.Clear();
            var errorcount = new List<Control>();
            foreach (Control tb in Controls)
            {
                if (tb.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                {
                    if (tb.Text == "")
                    {
                        err.SetError(tb, "Required!");
                        errorcount.Add(tb);
                    }
                }
            }
            if (errorcount.Count > 0)
            {
                throw new Exception("Field(s) cannot be empty!");
            }
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    string apprtag = "APPRD";
                    string preptag = "PREPRD";
                    string revitag = "REVWD";
                    signalist = new List<tbl_SIGNATORY>();

                    //Approved By
                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtApprName1.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtApprPosition1.Text, "").ToString();
                    signa.SignFor = apprtag;
                    signalist.Add(signa);

                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid + 1;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtApprName2.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtApprPosition2.Text, "").ToString();
                    signa.SignFor = apprtag;
                    signalist.Add(signa);

                    //Prepared By
                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid + 2;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtPrepName1.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtPrepPosition1.Text, "").ToString();
                    signa.SignFor = preptag;
                    signalist.Add(signa);

                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid + 3;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtPrepName2.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtPrepPosition2.Text, "").ToString();
                    signa.SignFor = preptag;
                    signalist.Add(signa);

                    //Reviewed By
                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid + 4;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtReviName1.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtReviPosition1.Text, "").ToString();
                    signa.SignFor = revitag;
                    signalist.Add(signa);

                    signa = new tbl_SIGNATORY();
                    signa.RecID = minid + 5;
                    signa.SignName = BPSUtilitiesV1.NZ(mtxtReviName2.Text, "").ToString();
                    signa.SignPosition = BPSUtilitiesV1.NZ(mtxtReviPosition2.Text, "").ToString();
                    signa.SignFor = revitag;
                    signalist.Add(signa);

                    foreach (tbl_SIGNATORY s in signalist)
                    {
                        s.ReportName = this.Text;
                        s.UpdatedBy = UserSettings.Username;
                        s.UpdatedDate = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SaveRecord()
        {
            var msg = "Successful!";
            try
            {
                FormHelpers.CursorWait(true);
                AssignRecord(true);
                if (signalist_existing.Count == 0)
                {
                    if (signabal.Save(signalist))
                    {
                        MessageHelpers.ShowInfo("Saving " + msg);
                        Init_Form();
                    }
                }
                else
                {
                    if (signabal.Update(signalist))
                    {
                        MessageHelpers.ShowInfo("Updating " + msg);
                        Init_Form();
                    }
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
        public frmStandardCostingReport()
        {
            InitializeComponent();
            err = new ErrorProviderExtended();
            yearbal = new YearBAL();
            signabal = new SignatoryBAL();

            signalist = new List<tbl_SIGNATORY>();
            signalist_existing = new List<tbl_SIGNATORY>();
            signa = new tbl_SIGNATORY();

            itmbal = new ItemBAL();
            itm = new tbl_000_H_ITEM();
        }

        private void frmStandardCostingReport_Load(object sender, EventArgs e)
        {
            Init_Form();
            FilltxtAutoComplete();
        }
        private void mbtnSearchItem_Click(object sender, EventArgs e)
        {
            frm_DynamicList frm = new frm_DynamicList();
            frm.KindOfList = "ITEM";
            frm.MyCaller_scr = this;
            frm.Text = "List of Items";
            FormHelpers.ShowDialog(frm);
        }
        private void mbtnModify_Click(object sender, EventArgs e)
        {
            var msg_asking = "";
            if (signalist_existing.Count == 0)
            {
                msg_asking = "save";
            }
            else
            {
                msg_asking = "update";
            }

            switch (MyState)
            {
                case FormState.Edit:
                    try
                    {
                        if (MessageHelpers.ShowQuestion("Are you sure you want to " + msg_asking + " record?") == System.Windows.Forms.DialogResult.Yes)
                        {
                            SaveRecord();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageHelpers.ShowError(ex.Message);
                    }
                    break;
                default:
                    MyState = FormState.Edit;
                    mbtnModify.Text = "Update";
                    LockFields(false);
                    break;
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            err.Clear();
            switch (MyState)
            {
                case FormState.Edit:
                    Init_Form();
                    break;
            }
        }

        private Boolean Is2017Format()
        {
            Boolean _Is2017Format = false;
            if (mcbPriceQuot.Checked)
            {
                if (mcbF2017Purge.Checked)
                {
                    if (mcbWFreight.Checked && mcbWMPT.Checked)
                    {
                        if (mcbSMCost.Checked)
                        {
                            _Is2017Format = true;
                        }
                    }
                }
            }
            return _Is2017Format;
        }
        private void mbtnGenerate_Click(object sender, EventArgs e)
        {
            var msg_succ = "Generating Successful!";
            try
            {
                FormHelpers.CursorWait(true);
                if (Is2017Format())
                {
                    dtgnrtd = rptdetails.SP_GenerateQuot(mtxtItemNo.Text, UserSettings.LogInYear, mdtDate.Value, this.Text, Convert.ToDecimal(mtxtMPT.Text));
                    if (dtgnrtd != null && dtgnrtd.Rows.Count > 0)
                    {
                        MessageHelpers.ShowInfo(msg_succ);
                    }
                    else
                    {
                        throw new Exception("No Data Generated!");
                    }
                }
                else
                {
                    throw new Exception("This Format is not yet available!");
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

        private void mbtnExport_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
                PreviewF2017("rpt_StandardCostingF2017.rpt");
                Task.Factory.StartNew(() =>
                {
                    PreviewFSMT("rpt_StandardCostingFSMT.rpt");
                }, TaskCreationOptions.None);
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
        private void PreviewF2017(string strRptName)
        {
            frm_ReportViewer frv1 = new frm_ReportViewer();
            frv1.report = new ReportTable();
            frv1.report.ReportName = strRptName;
            frv1.report.ReportPath = ObjectFinder.ReportPath;
            frv1.report.SourceTable = dtgnrtd;
            frv1.report.SubDataSources = rptdetails.SP_Signatory("Standard Costing Report");
            if (frv1.report.SourceTable == null || frv1.report.SourceTable.Rows.Count == 0)
            {
                throw new Exception("Report no Data!");
            }
            frv1.Text = "Standard Costing Report";
            frv1.StartPosition = FormStartPosition.CenterScreen;
            frv1.ShowDialog();
        }
        private void PreviewFSMT(string strRptName)
        {
            frm_ReportViewer frv2 = new frm_ReportViewer();
            frv2.report = new ReportTable();
            frv2.report.ReportName = strRptName;
            frv2.report.ReportPath = ObjectFinder.ReportPath;
            frv2.report.SourceTable = rptdetails.SP_SMTRaw2017(mtxtItemNo.Text, UserSettings.LogInYear);
            if (frv2.report.SourceTable == null || frv2.report.SourceTable.Rows.Count == 0)
            {
                throw new Exception("Report no Data!");
            }
            frv2.Text = "Standard Costing Report";
            frv2.StartPosition = FormStartPosition.CenterScreen;
            frv2.ShowDialog();
        }
        private void mtxtMPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress(sender, e);
        }
        private void mdtDate_Validating(object sender, CancelEventArgs e)
        {
            StrictDate();
        }
        private void mdtDate_ValueChanged(object sender, EventArgs e)
        {
            StrictDate();
        }
        private void mtxtItemNo_TextChanged(object sender, EventArgs e)
        {
            ItemDesc();
        }
    }
}
