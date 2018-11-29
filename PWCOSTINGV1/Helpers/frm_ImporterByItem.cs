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
using PWCOSTING.BO._000;
using PWCOSTING.BAL;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
using ExcelDataReader;
using System.IO;
using BPSolutionsTools;
using System.Text.RegularExpressions;

namespace PWCOSTINGV1.Forms
{
    public partial class frm_ImporterByItem : MetroForm
    {
        public frmItemList MyCaller_itm { get; set; }

        ItemBAL itmbal;
        ItemCompositionBAL compbal;
        tbl_000_H_ITEM itm;
        List<tbl_000_H_ITEM> itmlist;
        List<tbl_000_H_ITEM_PART> itm_comlist;
        List<tbl_tmp_H_ITEM_PART> tmpdatalist;
        string msg = "";
        string msgval_nochanges = "No Changes have been made!";
        string msgval_success = "Importing Successful!";

        IExcelDataReader reader;
        DataTable dttemp;
        tmp_CompositionBAL tmpcombal;
        public frm_ImporterByItem()
        {
            InitializeComponent();
            itmbal = new ItemBAL();
            compbal = new ItemCompositionBAL();
            tmpcombal = new tmp_CompositionBAL();
            itm = new tbl_000_H_ITEM();
            itmlist = new List<tbl_000_H_ITEM>();
            itm_comlist = new List<tbl_000_H_ITEM_PART>();
            tmpdatalist = new List<tbl_tmp_H_ITEM_PART>();
        }
        private void frm_ImporterByItem_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = "NOTE: If Overwrite Existing is checked it will overwrite items \r\n that are in the previous and also in the current logged in year.";
        }

        private void mbtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = mtxtFilePath.Text;
            fdlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                mtxtFilePath.Text = fdlg.FileName;
                Application.DoEvents();
            }
        }
        private Decimal Usage(string data)
        {
            Decimal parsed_data = 1;
            Decimal ans = 1;
            int alphcount = Regex.Matches(data,@"[a-zA-Z]").Count;
            if (alphcount == 0)
            {
                parsed_data = Convert.ToDecimal(data);
                 ans = parsed_data;
            }
            return ans;
        }
        private List<string> ProcessList()
        {
            List<string> AllowedProcess = new List<string>();
            AllowedProcess.Add("AP");
            AllowedProcess.Add("PF");
            AllowedProcess.Add("PFP");
            return AllowedProcess;
        }
        private string Bagging(string itemaddress)
        {
            string Bagging = "";
            if (itemaddress.Length > 1)
                {
                    int prefixcountstart = 0;
                    int prefixcountstop = 1; 
                    if (itemaddress.Length >= 5)
                    {
                        prefixcountstop = 2;
                    }
                    string prefx = itemaddress.Substring(prefixcountstart, prefixcountstop);
                    var parentrow = tmpdatalist.Where(w => w.ItemAddress == prefx).FirstOrDefault();
                    if (parentrow == null)
                        throw new Exception("Child row have no Parent row!");
                    Bagging = parentrow.PartName;
                }
                else
            {
                var currentrow = tmpdatalist.Where(w => w.ItemAddress == itemaddress).FirstOrDefault();
                Bagging = currentrow.PartName;
            }
            return Bagging;
        }
        private void GetExclData(string FilePath)
      {
            try
            {
                using (FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read))
                {
                    reader = ExcelReaderFactory.CreateReader(stream);
                    DataSet dirty_result = reader.AsDataSet();
                    DataSet result = reader.AsDataSet(
                        new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true,
                                ReadHeaderRow = rowReader =>  // skip 3 rows
                                {
                                    rowReader.Read();
                                    rowReader.Read();
                                    rowReader.Read();
                                }
                            }
                        }
                        );
                    if (result.Tables.Count > 0)
                    {
                        dttemp = new DataTable();
                        dttemp = dirty_result.Tables[0];

                        tmpdatalist = new List<tbl_tmp_H_ITEM_PART>();
                        List<tbl_tmp_H_ITEM_PART> tmpdatalist_cleaned = new List<tbl_tmp_H_ITEM_PART>();
                        tbl_tmp_H_ITEM_PART tmpdata = new tbl_tmp_H_ITEM_PART();
                        tmpdatalist = result.Tables[0].AsEnumerable().Select(r => new tbl_tmp_H_ITEM_PART
                        {
                            ItemAddress = BPSUtilitiesV1.NZ(r.Field<object>("ADDRESS"),"").ToString(),
                            PartNo = BPSUtilitiesV1.NZ(r.Field<object>("CODE"), "").ToString(),
                            PartName = BPSUtilitiesV1.NZ(r.Field<object>("PARTS NAME"), "").ToString(),
                            ItemUsage = Usage(BPSUtilitiesV1.NZ(r.Field<object>("USAGE"), "1").ToString()),
                            Process = BPSUtilitiesV1.NZ(r.Field<object>("PROCESS"), "").ToString(),
                            ItemVendor = BPSUtilitiesV1.NZ(r.Field<object>("VENDOR"), "").ToString(),
                            Bagging = BPSUtilitiesV1.NZ(r.Field<object>("PARTS NAME"), "").ToString()
                        }).ToList();
                        if (BPSolutionsTools.BPSUtilitiesV1.NZ(dttemp.Rows[1][6], "").ToString() != "")
                        {
                            tmpdata.ItemAddress = "";
                            tmpdata.PartNo = dttemp.Rows[0][1].ToString();
                            tmpdata.PartName = "FINAL PROCESS";
                            tmpdata.ItemUsage = 1;
                            tmpdata.Process = "_FP";
                            tmpdata.ItemVendor = "";
                            tmpdata.Bagging = "";
                            tmpdatalist_cleaned.Add(tmpdata);

                        }
                        foreach (tbl_tmp_H_ITEM_PART tc in tmpdatalist)
                        {
                            if (tc.PartNo == "REVISED PORTION")
                            {
                                break;
                            }
                            if (tc.PartNo == null || tc.PartNo == "") continue;
                            if (tc.ItemAddress.ToUpper() == "Y") continue;
                            tc.Bagging = Bagging(tc.ItemAddress);
                            tmpdatalist_cleaned.Add(tc);
                         }
                        if (tmpdatalist_cleaned.Count == 0) throw new Exception("No Data Found!");
                        else
                        {
                            tmpcombal.Save(tmpdatalist_cleaned);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private tbl_000_H_ITEM ItemToSave()
        {
            tbl_000_H_ITEM write_itm = new tbl_000_H_ITEM();

            write_itm.YEARUSED = UserSettings.LogInYear;
            write_itm.ItemNo = dttemp.Rows[0][1].ToString();
            write_itm.Description = dttemp.Rows[1][1].ToString();
            write_itm.CatCode = "";
            write_itm.CatDesc = "";
            write_itm.CreatedDate = DateTime.Now;
            write_itm.CreatedBy = UserSettings.Username;
            write_itm.LastUpdated = DateTime.Now;
            write_itm.LockedDate = DateTime.Now;
            write_itm.CopyDate = DateTime.Now;
            write_itm.UpdatedDate = DateTime.Now;
            write_itm.IsImported = true;
            write_itm.ImportDate = DateTime.Now;
            write_itm.ImportBy = UserSettings.Username;
            return write_itm;
        }
        private void Import()
        {
            try
            {
                FormHelpers.CursorWait(true);
                GetExclData(mtxtFilePath.Text);
                var chk_itm = itmbal.GetByID(UserSettings.LogInYear, dttemp.Rows[0][1].ToString());
                if (!mcbOverWrite.Checked)
                {
                    msg = "This process will import components to the current logged in year. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                            if (chk_itm == null)
                            {
                                if (itmbal.Save(ItemToSave()))
                                {
                                    tmpcombal.DistributeCompo(UserSettings.LogInYear, dttemp.Rows[0][1].ToString(), UserSettings.Username);
                                    MessageHelpers.ShowInfo(msgval_success);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageHelpers.ShowInfo(msgval_nochanges);
                                this.Close();
                            }
                    }
                }
                else
                {
                    msg = "This process will remove the existing components and replace it. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                        if (chk_itm != null)
                        {

                            if (itmbal.Delete(chk_itm))
                            {
                                DeleteSub(chk_itm.ItemNo);
                            }
                        }
                        if (itmbal.Save(ItemToSave()))
                        {
                            tmpcombal.DistributeCompo(UserSettings.LogInYear, dttemp.Rows[0][1].ToString(), UserSettings.Username);
                            MessageHelpers.ShowInfo(msgval_success);
                            this.Close();
                        }
                    }
                }
                MyCaller_itm.RefreshGrid();
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
        private void DeleteSub(string itemno)
        {
            try
            {
                List<tbl_000_H_ITEM_PART> complist = new List<tbl_000_H_ITEM_PART>();
                complist = compbal.GetByNo(UserSettings.LogInYear, itemno);
                foreach (tbl_000_H_ITEM_PART c in complist)
                {
                    compbal.Delete(c);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void mbtnImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
