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

namespace PWCOSTINGV1.Forms
{
    public partial class frm_Importer : MetroForm
    {
        public frmComponentList MyCaller_com { get; set; }
        public frmMT_PIList MyCaller_mtpi { get; set; }
        public frmMT_VPList MyCaller_mtvp { get; set; }
        public frmMT_AssyList MyCaller_mtassy { get; set; }
        public frmProcessSetup MyCaller_proc { get; set; }
        public YearsOf YearSource { get; set; }
        public MaintainanceTableSub YearofMaintenanceTable_Sub { get; set; }
        ComponentBAL combal;
        PlasticInjectionBAL pibal;
        VacuumPlatingBAL vpbal;
        AssymblyBAL assybal;
        ProcessSetupBAL procbal;

        List<tbl_000_H_PART> comlist;
        List<tbl_000_H_PI> pilist;
        List<tbl_000_H_VP> vplist;
        List<tbl_000_H_ASSY> assylist;
        List<tbl_000_PROCESS> proclist;

        List<tbl_000_H_PART> cleaned_list_com;
        List<tbl_000_H_PI> cleaned_list_pi;
        List<tbl_000_H_VP> cleaned_list_vp;
        List<tbl_000_H_ASSY> cleaned_list_assy;
        List<tbl_000_PROCESS> cleaned_list_proc;

        string msg = "";
        string msgval_nochanges = "No Changes have been made!";
        string msgval_success = "Importing Successful!";
        string finishing_msg = "";
        public frm_Importer()
        {
            InitializeComponent();
            combal = new ComponentBAL();
            pibal = new PlasticInjectionBAL();
            vpbal = new VacuumPlatingBAL();
            assybal = new AssymblyBAL();
            procbal = new ProcessSetupBAL();

            comlist = new List<tbl_000_H_PART>();
            pilist = new List<tbl_000_H_PI>();
            vplist = new List<tbl_000_H_VP>();
            assylist = new List<tbl_000_H_ASSY>();
            proclist = new List<tbl_000_PROCESS>();

            cleaned_list_com = new List<tbl_000_H_PART>();
            cleaned_list_pi = new List<tbl_000_H_PI>();
            cleaned_list_vp = new List<tbl_000_H_VP>();
            cleaned_list_assy = new List<tbl_000_H_ASSY>();
            cleaned_list_proc = new List<tbl_000_PROCESS>();
        }

        private void frm_Importer_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = "NOTES: \r\n If Overwrite Existing is checked it will overwrite items \r\n that are in the previous and also in the current logged in year.\r\n Please close the file before importing.";
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
        private void GetExclData(string FilePath)
        {
            try
            {
                //Get Data from Excel File
                using (FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true // Use first row as ColumnNames
                        }
                    });
                    if (result.Tables.Count > 0)
                    {
                        switch (YearSource)
                        {
                            #region Getting Components Data
                            case YearsOf.Components:
                                comlist = result.Tables[0].AsEnumerable().Select(r => new tbl_000_H_PART
                                {
                                    PartNo = r.Field<object>("Part No.").ToString(),
                                    PartName = r.Field<object>("Part Name").ToString(),
                                    WholeQty = Convert.ToDecimal(r.Field<object>("Whole Qty.")),
                                    WholeUnit = r.Field<object>("Whole Unit").ToString(),
                                    ConversionQty = Convert.ToDecimal(r.Field<object>("Conversion Qty.")),
                                    ConversionUnit = r.Field<object>("Conversion Unit").ToString(),
                                    WholePrice = Convert.ToDecimal(r.Field<object>("Whole Price")),
                                    ConversionPrice = Convert.ToDecimal(r.Field<object>("Conversion Price")),
                                    ExpDate = Convert.ToDateTime(r.Field<object>("Exp. Date")),
                                    ExpRateUS = Convert.ToDecimal(r.Field<object>("Exp. Rate(US)")),
                                    ExpRateYEN = Convert.ToDecimal(r.Field<object>("Exp. Rate(YEN)")),
                                    PreviousPrice = Convert.ToDecimal(r.Field<object>("Previous Price"))
                                }).ToList();
                                break;
                                #endregion
                            #region Getting Tabulation Data
                            case YearsOf.MaintainanceTable:
                                switch (YearofMaintenanceTable_Sub)
                                {
                                    case MaintainanceTableSub.PlasticInjection:
                                        pilist = result.Tables[0].AsEnumerable().Select(r => new tbl_000_H_PI
                                        {
                                            MoldNo = r.Field<object>("Mold No.").ToString(),
                                            MoldName = r.Field<object>("Mold Name").ToString(),
                                            Oz = r.Field<object>("Oz").ToString(),
                                            PurgePerG = Convert.ToDecimal(r.Field<object>("Purge/Gram")),
                                            SPH = Convert.ToDecimal(r.Field<object>("Shots/Hour")),
                                            Cavity = Convert.ToDecimal(r.Field<object>("Cavity")),
                                            PPH = Convert.ToDecimal(r.Field<object>("Pieces/Hour"))
                                        }).ToList();
                                        break;
                                    case MaintainanceTableSub.VacuumPlating:
                                        vplist = result.Tables[0].AsEnumerable().Select(r => new tbl_000_H_VP
                                            {
                                                PartNo = r.Field<object>("Part No.").ToString(),
                                                PartName = r.Field<object>("Part Name").ToString(),
                                                SourceData = r.Field<object>("Source Data").ToString(),
                                            }).ToList();
                                        break;
                                    case MaintainanceTableSub.Assembly:
                                        assylist = result.Tables[0].AsEnumerable().Select(r => new tbl_000_H_ASSY
                                            {
                                                PartNo = r.Field<object>("Part No.").ToString(),
                                                PartName = r.Field<object>("Part Name").ToString(),
                                                RATEPERHOUR = Convert.ToDecimal(r.Field<object>("Rate/Hour"))
                                            }).ToList();
                                        break;
                                }
                                break;
                            #endregion
                            #region Getting Process Data
                            case YearsOf.ProcessSetup:
                                proclist = result.Tables[0].AsEnumerable().Select(r => new tbl_000_PROCESS
                                    {
                                        SubProcessCode = r.Field<object>("Subprocess Code").ToString(),
                                        ProcessCode = r.Field<object>("Process Code").ToString(),
                                        ItemDescription = r.Field<object>("Description").ToString(),
                                        StandardA = Convert.ToDecimal(r.Field<object>("SP/HC")),
                                        StandardB = Convert.ToDecimal(r.Field<object>("Cavity/PH")),
                                        Remarks = r.Field<object>("Remarks").ToString()
                                    }).ToList();
                                break;
                            #endregion
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Invalid Type or File is in Use!");
            }
        }
        private void Import()
        {
            List<tbl_000_H_PART> write_list_com;
            List<tbl_000_H_PI> write_list_pi;
            List<tbl_000_H_VP> write_list_vp;
            List<tbl_000_H_ASSY> write_list_assy;
            List<tbl_000_PROCESS> write_list_proc;
            try
            {
                GetExclData(mtxtFilePath.Text);

                    if (!mcbOverWrite.Checked)
                    {
                        msg = "This process will import previous components from the selected year to the current logged in year. Do you want to continue?";
                        if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                        {
                            switch (YearSource)
                            {
                                #region Components to Import
                                case YearsOf.Components:
                                    write_list_com = new List<tbl_000_H_PART>();
                                    var currentyear_list_com = combal.GetByYear(UserSettings.LogInYear).ToList();
                                    //Matching by 'PartNo' or 'PartName'
                                    foreach (tbl_000_H_PART c in currentyear_list_com)
                                    {
                                        write_list_com.Add(combal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == c.PartNo || w.PartName == c.PartName)).FirstOrDefault());
                                    }
                                    //Remove columns from excell if it exists in current year
                                    foreach (tbl_000_H_PART c in write_list_com)
                                    {
                                        if (c != null) 
                                        {
                                            comlist.RemoveAll(r => r.PartNo == c.PartNo || r.PartName == c.PartName);
                                        }
                                    }
                                    //Fill some Columns and Save them
                                    Save_com();
                                    break;
                                #endregion
                                #region Tabulation to Import
                                case YearsOf.MaintainanceTable:
                                    switch (YearofMaintenanceTable_Sub)
                                    {
                                        case MaintainanceTableSub.PlasticInjection:
                                            write_list_pi = new List<tbl_000_H_PI>();
                                            var currentyear_list_pi = pibal.GetByYear(UserSettings.LogInYear).ToList();
                                            foreach (tbl_000_H_PI p in currentyear_list_pi)
                                            {
                                                write_list_pi.Add(pibal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.MoldNo == p.MoldNo || w.MoldName == p.MoldName)).FirstOrDefault());
                                            }
                                            foreach (tbl_000_H_PI p in write_list_pi)
                                            {
                                                if (p != null)
                                                {
                                                    pilist.RemoveAll(r => r.MoldNo == p.MoldNo || r.MoldName == p.MoldName);
                                                }
                                            }
                                            Save_pi();
                                            break;
                                        case MaintainanceTableSub.VacuumPlating:
                                            write_list_vp = new List<tbl_000_H_VP>();
                                            var currentyear_list_vp = vpbal.GetByYear(UserSettings.LogInYear).ToList();
                                            foreach (tbl_000_H_VP v in currentyear_list_vp)
                                            {
                                                write_list_vp.Add(vpbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == v.PartNo || w.PartName == v.PartName)).FirstOrDefault());
                                            }
                                            foreach (tbl_000_H_VP v in write_list_vp)
                                            {
                                                if (v != null)
                                                {
                                                    vplist.RemoveAll(r => r.PartNo == v.PartNo || r.PartName == v.PartName);
                                                }
                                            }
                                            Save_vp();
                                            break;
                                        case MaintainanceTableSub.Assembly:
                                            write_list_assy = new List<tbl_000_H_ASSY>();
                                            var currentyear_list_assy = assybal.GetByYear(UserSettings.LogInYear).ToList();
                                            foreach (tbl_000_H_ASSY a in currentyear_list_assy)
                                            {
                                                write_list_assy.Add(assybal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == a.PartNo || w.PartName == a.PartName)).FirstOrDefault());
                                            }
                                            foreach (tbl_000_H_ASSY a in write_list_assy)
                                            {
                                                if (a != null)
                                                {
                                                    assylist.RemoveAll(r => r.PartNo == a.PartNo || r.PartName == a.PartName);
                                                }
                                            }
                                            Save_assy();
                                            break;
                                    }
                                    break;
                                #endregion
                                #region Process to Import
                                case YearsOf.ProcessSetup:
                                    write_list_proc = new List<tbl_000_PROCESS>();
                                    var currentyear_list_proc = procbal.GetByYear(UserSettings.LogInYear).ToList();
                                    foreach(tbl_000_PROCESS p in currentyear_list_proc)
                                    {
                                        write_list_proc.Add(procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.SubProcessCode == p.SubProcessCode || w.ItemDescription == p.ItemDescription)).FirstOrDefault());
                                    }
                                    foreach (tbl_000_PROCESS p in write_list_proc)
                                    {
                                        if(p != null)
                                        {
                                            proclist.RemoveAll(r => r.SubProcessCode == p.SubProcessCode || r.ItemDescription == p.ItemDescription);
                                        }
                                    }
                                    Save_proc();
                                    break;
                                #endregion
                            }
                        }
                    }
                    else
                    {
                        msg = "This process will remove the existing components and replace it with the selected year. Do you want to continue?";
                        if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                        {
                            switch (YearSource)
                            {
                                #region Components to Import with Overwrite
                                case YearsOf.Components:
                                    write_list_com = new List<tbl_000_H_PART>();
                                    //Matching by 'PartNo' or 'PartName'
                                    foreach (tbl_000_H_PART c in comlist)
                                    {
                                        write_list_com.Add(combal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == c.PartNo || w.PartName == c.PartName)).FirstOrDefault());
                                    }
                                    //Delete the records to be Overwritten
                                    if (BPSUtilitiesV1.NZ(write_list_com, "").ToString() != "")
                                    {
                                        foreach (tbl_000_H_PART c in write_list_com)
                                        {
                                            if (c != null)
                                            {
                                                combal.Delete(c);
                                            }
                                        }
                                    }
                                    //Fill some Columns and Save them
                                    Save_com();
                                    break;
                                #endregion
                                #region Tabulation to import with Overwrite
                                case YearsOf.MaintainanceTable:
                                    switch (YearofMaintenanceTable_Sub)
                                    {
                                        case MaintainanceTableSub.PlasticInjection:
                                            write_list_pi = new List<tbl_000_H_PI>();
                                            foreach (tbl_000_H_PI p in pilist)
                                            {
                                                write_list_pi.Add(pibal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.MoldNo == p.MoldNo || w.MoldName == p.MoldName)).FirstOrDefault());
                                            }
                                            if (BPSUtilitiesV1.NZ(write_list_pi, "").ToString() != "")
                                            {
                                                foreach (tbl_000_H_PI p in write_list_pi)
                                                {
                                                    if (p != null)
                                                    {
                                                        pibal.Delete(p);
                                                    }
                                                }
                                            }
                                            Save_pi();
                                            break;
                                        case MaintainanceTableSub.VacuumPlating:
                                            write_list_vp = new List<tbl_000_H_VP>();
                                            foreach (tbl_000_H_VP v in vplist)
                                            {
                                                write_list_vp.Add(vpbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == v.PartNo || w.PartName == v.PartName)).FirstOrDefault());
                                            }
                                            if(BPSUtilitiesV1.NZ(write_list_vp, "").ToString() != "")
                                            {
                                                foreach (tbl_000_H_VP v in write_list_vp)
                                                {
                                                    if (v != null)
                                                    {
                                                        vpbal.Delete(v);
                                                    }
                                                }
                                            }
                                            Save_vp();
                                            break;
                                        case MaintainanceTableSub.Assembly:
                                            write_list_assy = new List<tbl_000_H_ASSY>();
                                            foreach (tbl_000_H_ASSY a in assylist)
                                            {
                                                write_list_assy.Add(assybal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.PartNo == a.PartNo || w.PartName == a.PartName)).FirstOrDefault());
                                            }
                                            if (BPSUtilitiesV1.NZ(write_list_assy, "").ToString() != "")
                                            {
                                                foreach (tbl_000_H_ASSY a in write_list_assy)
                                                {
                                                    if (a != null)
                                                    {
                                                        assybal.Delete(a);
                                                    }
                                                }
                                            }
                                            Save_assy();
                                            break;
                                    }
                                    break;
                                #endregion
                                #region Process to Import with Overwrite
                                case YearsOf.ProcessSetup:
                                    write_list_proc = new List<tbl_000_PROCESS>();
                                    List<tbl_000_PROCESS> todelete_proc = new List<tbl_000_PROCESS>(); 
                                    foreach (tbl_000_PROCESS p in proclist)
                                    {
                                        write_list_proc.Add(procbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && (w.SubProcessCode == p.SubProcessCode || w.ItemDescription == p.ItemDescription)).FirstOrDefault());
                                    }
                                    if (BPSUtilitiesV1.NZ(write_list_proc, "").ToString() != "")
                                    {
                                        foreach (tbl_000_PROCESS p in write_list_proc)
                                        {
                                                if (p != null)
                                                {
                                                    todelete_proc.Add(p);
                                                }
                                        }
                                        procbal.Delete(todelete_proc);
                                    }
                                    Save_proc();
                                    break;
                                #endregion
                            }
                        }

                    }
                    this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Saving Components
        private void Save_com()
        {
            foreach (tbl_000_H_PART c in comlist)
            {
                c.YEARUSED = UserSettings.LogInYear;
                c.IsLocked = false;
                c.CreatedDate = DateTime.Now;
                c.CreatedBy = UserSettings.Username;
                c.UpdatedDate = DateTime.Now;
                c.IsCopied = false;
                c.CopyDate = DateTime.Now;
                c.IsImported = true;
                c.ImportDate = DateTime.Now;
                c.ImportBy = UserSettings.Username;
                cleaned_list_com.Add(c);
            }
            if (combal.Save_List(cleaned_list_com))
            {
                if (cleaned_list_com.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_com.Init_Form();
            }
        }
        #endregion
        #region Saving Tabulation
        private void Save_pi()
        {
            foreach (tbl_000_H_PI p in pilist)
            {
                p.YEARUSED = UserSettings.LogInYear;
                p.IsLocked = false;
                p.CreatedDate = DateTime.Now;
                p.CreatedBy = UserSettings.Username;
                p.UpdatedDate = DateTime.Now;
                p.IsCopied = false;
                p.CopyDate = DateTime.Now;
                p.IsImported = true;
                p.ImportDate = DateTime.Now;
                p.ImportBy = UserSettings.Username;
                cleaned_list_pi.Add(p);
            }
            if (pibal.Save_List(cleaned_list_pi))
            {
                if (cleaned_list_pi.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_mtpi.Init_Form();
            }
        }
        private void Save_vp()
        {
            foreach (tbl_000_H_VP v in vplist)
            {
                v.YEARUSED = UserSettings.LogInYear;
                v.IsLocked = false;
                v.CreatedDate = DateTime.Now;
                v.CreatedBy = UserSettings.Username;
                v.UpdatedDate = DateTime.Now;
                v.IsCopied = false;
                v.CopyDate = DateTime.Now;
                v.IsImported = true;
                v.ImportDate = DateTime.Now;
                v.ImportBy = UserSettings.Username;
                cleaned_list_vp.Add(v);
            }
            if (vpbal.Save_List(cleaned_list_vp))
            {
                if (cleaned_list_vp.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_mtvp.Init_Form();
            }
        }
        private void Save_assy()
        {
            foreach (tbl_000_H_ASSY a in assylist)
            {
                a.YEARUSED = UserSettings.LogInYear;
                a.IsLocked = false;
                a.CreatedDate = DateTime.Now;
                a.CreatedBy = UserSettings.Username;
                a.UpdatedDate = DateTime.Now;
                a.IsCopied = false;
                a.CopyDate = DateTime.Now;
                a.IsImported = true;
                a.ImportDate = DateTime.Now;
                a.ImportBy = UserSettings.Username;
                cleaned_list_assy.Add(a);
            }
            if(assybal.Save_List(cleaned_list_assy))
            {
                if(cleaned_list_assy.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_mtassy.Init_Form();
            }
        }
        #endregion
        #region Saving Process
        private void Save_proc()
        {
            foreach (tbl_000_PROCESS p in proclist)
            {
                p.YEARUSED = UserSettings.LogInYear;
                p.IsActive = false;
                p.CreatedDate = DateTime.Now;
                p.CreatedBy = UserSettings.Username;
                p.UpdatedDate = DateTime.Now;
                p.IsCopied = false;
                p.CopyDate = DateTime.Now;
                p.IsImported = true;
                p.ImportDate = DateTime.Now;
                p.ImportBy = UserSettings.Username;
                cleaned_list_proc.Add(p);
            }
            if (procbal.Save(cleaned_list_proc))
            {
                if (cleaned_list_proc.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_proc.Init_Form();
            }
        }
        #endregion
        private void mbtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtFilePath.Text != "")
                {
                    FormHelpers.CursorWait(true);
                    Import();
                }
                else
                {
                    throw new Exception("Filepath cannot be empty!");
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

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
