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
using PWCOSTING.BO._000;
using PWCOSTING.BO.Default;
using PWCOSTING.BAL._000;
using PWCOSTING.BAL.Default;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frm_YearHelper : MetroForm
    {
        public frmComponentList MyCaller_com { get; set; }
        public frmMT_PIList MyCaller_mtpi { get; set; }
        public frmMT_VPList MyCaller_mtvp { get; set; }
        public frmMT_AssyList MyCaller_mtassy { get; set; }
        public frmProcessSetup MyCaller_proc { get; set; }
        public frmItemList MyCaller_itm { get; set; }

        public YearsOf YearSource{ get; set; }
        public MaintainanceTableSub YearofMaintenanceTable_Sub { get; set; }

        ComponentBAL combal;
        PlasticInjectionBAL pibal;
        VacuumPlatingBAL vpbal;
        AssymblyBAL assybal;
        ProcessSetupBAL procbal;

        ItemBAL itmbal;
        ItemCompositionBAL itmcombal;
        ItemTabulationPIBAL itmpibal;
        ItemTabulationVPBAL itmvpbal;
        ItemTabulationAssyBAL itmassybal;
        ItemMPTBAL itmmptbal;
        ItemFDCBAL itmfdcbal;

        List<tbl_000_H_ASSY> assylist;

        List<tbl_000_H_ITEM> itmlist;
        List<tbl_000_H_ITEM_PART> itmcomlist;
        List<tbl_000_H_ITEM_TABULATION> itmpilist;
        List<tbl_000_H_ITEM_TABULATION_VP> itmvplist;
        List<tbl_000_H_ITEM_TABULATION_ASSY> itmassylist;
        List<tbl_000_H_ITEM_MPT> itmmptlist;
        List<tbl_000_H_ITEM_FDC> itmfdclist;

        #region cleaned lists
        List<tbl_000_H_PART> cleaned_list_com;
        List<tbl_000_H_PI> cleaned_list_pi;
        List<tbl_000_H_VP> cleaned_list_vp;
        List<tbl_000_H_ASSY> cleaned_list_assy;
        List<tbl_000_PROCESS> cleaned_list_proc;

        List<tbl_000_H_ITEM> cleaned_list_itm;
        List<tbl_000_H_ITEM_PART> cleaned_list_itmcom;
        List<tbl_000_H_ITEM_TABULATION> cleaned_list_itmpi;
        List<tbl_000_H_ITEM_TABULATION_VP> cleaned_list_itmvp;
        List<tbl_000_H_ITEM_TABULATION_ASSY> cleaned_list_itmassy;
        List<tbl_000_H_ITEM_MPT> cleaned_list_itmmpt;
        List<tbl_000_H_ITEM_FDC> cleaned_list_itmfdc;
        #endregion
        List<tbl_000_H_ITEM> todelete_item;
        string msg = "";
        string msgval_nochanges = "No Changes have been made!";
        string msgval_success = "Copying Successful!";
        string finishing_msg = "";
        int selyear;
        public void Init_Form()
        {
            RefreshCBox();
            metroLabel1.Text = "NOTE: If Overwrite Existing is checked it will overwrite all data \r\n that are in the previous and also in the current logged in year.";
            mtxtCurLogYear.Text = UserSettings.LogInYear.ToString();
            mtxtCurLogYear.Height = 30;
        }
        public void RefreshCBox()
        {
            switch (YearSource)
            {
                case YearsOf.Components:
                    ListHelper.FillMetroCombo(mcboYear, combal.GetAll().Select(i => new { i.YEARUSED}).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                    break;
                case YearsOf.MaintainanceTable:
                    switch (YearofMaintenanceTable_Sub)
                    {
                        case MaintainanceTableSub.PlasticInjection:
                            ListHelper.FillMetroCombo(mcboYear, pibal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                            break;
                        case MaintainanceTableSub.VacuumPlating:
                            ListHelper.FillMetroCombo(mcboYear, vpbal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                            break;
                        case MaintainanceTableSub.Assembly:
                            ListHelper.FillMetroCombo(mcboYear, assybal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                            break;
                    }
                    break;
                case YearsOf.ProcessSetup:
                    ListHelper.FillMetroCombo(mcboYear, procbal.GetAll().Select(i => new {i.YEARUSED}).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                    break;
                case YearsOf.Items:
                    ListHelper.FillMetroCombo(mcboYear, itmbal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
                    break;
            }
        }
        public frm_YearHelper()
        {
            InitializeComponent();
             combal = new ComponentBAL();
             pibal = new PlasticInjectionBAL();
             vpbal = new VacuumPlatingBAL();
             assybal = new AssymblyBAL();
             procbal = new ProcessSetupBAL();

             itmbal = new ItemBAL();
             itmcombal = new ItemCompositionBAL();
             itmpibal = new ItemTabulationPIBAL();
             itmvpbal = new ItemTabulationVPBAL();
             itmassybal = new ItemTabulationAssyBAL();
             itmmptbal = new ItemMPTBAL();
             itmfdcbal = new ItemFDCBAL();

             assylist = new List<tbl_000_H_ASSY>();

             itmlist = new List<tbl_000_H_ITEM>();
             itmcomlist = new List<tbl_000_H_ITEM_PART>();
             itmpilist = new List<tbl_000_H_ITEM_TABULATION>();
             itmvplist = new List<tbl_000_H_ITEM_TABULATION_VP>();
             itmassylist = new List<tbl_000_H_ITEM_TABULATION_ASSY>();
             itmmptlist = new List<tbl_000_H_ITEM_MPT>();
             itmfdclist = new List<tbl_000_H_ITEM_FDC>();

             #region cleaned lists
             cleaned_list_com = new List<tbl_000_H_PART>();
             cleaned_list_pi = new List<tbl_000_H_PI>();
             cleaned_list_vp = new List<tbl_000_H_VP>();
             cleaned_list_assy = new List<tbl_000_H_ASSY>();
             cleaned_list_proc = new List<tbl_000_PROCESS>();

             cleaned_list_itm = new List<tbl_000_H_ITEM>();
             cleaned_list_itmcom = new List<tbl_000_H_ITEM_PART>();
             cleaned_list_itmpi = new List<tbl_000_H_ITEM_TABULATION>();
             cleaned_list_itmvp = new List<tbl_000_H_ITEM_TABULATION_VP>();
             cleaned_list_itmassy = new List<tbl_000_H_ITEM_TABULATION_ASSY>();

             cleaned_list_assy = new List<tbl_000_H_ASSY>();
             cleaned_list_itmmpt = new List<tbl_000_H_ITEM_MPT>();
             cleaned_list_itmfdc = new List<tbl_000_H_ITEM_FDC>();
            #endregion
            todelete_item = new List<tbl_000_H_ITEM>();
        }
        private void ContinueCopy()
        {
            try
            {
                FormHelpers.CursorWait(true);
                List<tbl_000_H_ITEM> write_list_itm;
                selyear = Convert.ToInt32(mcboYear.SelectedValue.ToString());
                if (!mcbOverWrite.Checked)
                {
                    msg = "This process will copy previous components from the selected year to the current logged in year. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                        switch (YearSource)
                        {
                            #region Components to Copy
                            case YearsOf.Components:
                                Save_com(false);
                                break;
                            #endregion
                            #region Tabulation to Copy
                            case YearsOf.MaintainanceTable:
                                switch (YearofMaintenanceTable_Sub)
                                {
                                    case MaintainanceTableSub.PlasticInjection:
                                        Save_pi(false);
                                        break;
                                    case MaintainanceTableSub.VacuumPlating:
                                        Save_vp(false);
                                        break;
                                    case MaintainanceTableSub.Assembly:
                                        Save_assy(false);
                                        break;
                                }
                                break;
                            #endregion
                            #region Process to Copy
                            case YearsOf.ProcessSetup:
                                Save_proc(false);
                                break;
                            #endregion
                            #region Items to Copy
                            case YearsOf.Items:
                                write_list_itm = new List<tbl_000_H_ITEM>();
                                var currentyear_list_itm = itmbal.GetByYear(UserSettings.LogInYear).ToList();
                                foreach (tbl_000_H_ITEM i in currentyear_list_itm)
                                {
                                    write_list_itm.Add(itmbal.GetAll().Where(w => w.YEARUSED == selyear && w.ItemNo == i.ItemNo).FirstOrDefault());
                                }
                                foreach (tbl_000_H_ITEM i in write_list_itm)
                                {
                                    if (i != null)
                                    {
                                        itmlist.RemoveAll(r => r.ItemNo == i.ItemNo);
                                    }
                                }
                                Save_item();
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
                            #region Components to Copy with Overwrite
                            case YearsOf.Components:
                                Save_com(true);
                                break;
                            #endregion
                            #region Tabulation to Copy with Overwrite
                            case YearsOf.MaintainanceTable:
                                switch (YearofMaintenanceTable_Sub)
                                {
                                    case MaintainanceTableSub.PlasticInjection:
                                        Save_pi(true);
                                        break;
                                    case MaintainanceTableSub.VacuumPlating:
                                        Save_vp(true);
                                        break;
                                    case MaintainanceTableSub.Assembly:
                                        Save_assy(true);
                                        break;
                                }
                                break;
                            #endregion
                            #region Process to Copy with Overwrite
                            case YearsOf.ProcessSetup:
                                Save_proc(true);
                                break;
                            #endregion
                            #region Items to Copy with Overwrite
                            case YearsOf.Items:
                                write_list_itm = new List<tbl_000_H_ITEM>();
                                foreach (tbl_000_H_ITEM i in itmlist)
                                {
                                    write_list_itm.Add(itmbal.GetAll().Where(w => w.YEARUSED == UserSettings.LogInYear && w.ItemNo == i.ItemNo).FirstOrDefault());
                                }
                                AssignSubItems(write_list_itm);
                                if (BPSUtilitiesV1.NZ(write_list_itm, "").ToString() != "")
                                {
                                    foreach (tbl_000_H_ITEM i in write_list_itm)
                                    {
                                        if (i != null)
                                        {
                                            todelete_item.Add(i);
                                        }
                                    }
                                    var tmptodelete_item = todelete_item;
                                    itmbal.Delete_List(todelete_item);
                                    //AssignSubItems(itmlist);
                                    DeleteSub(todelete_item);
                                    Save_item();
                                }
                                break;
                            #endregion
                        }

                    }
                }
                    this.Close();
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
        #region Saving Components
        private void Save_com(Boolean IsOverwrite)
        {
            if (combal.CopyByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_com.Init_Form();
            }
        }
        #endregion
        #region Saving Tabulation
        private void Save_pi(Boolean IsOverwrite)
        {
            if (pibal.CopyByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_mtpi.Init_Form();
            }
        }
        private void Save_vp(Boolean IsOverwrite)
        {
            if (vpbal.CopyByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_mtvp.Init_Form();
            }
        }
        private void Save_assy(Boolean IsOverwrite)
        {
            if (assybal.CopyByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_mtassy.Init_Form();
            }
        }
        #endregion
        #region Saving Process
        private void Save_proc(Boolean IsOverwrite)
        {
            if (procbal.CopyByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_proc.LoadGrid();
            }
        }
        #endregion
        #region Saving Items
        //Item Subs
        private void Modify_SubItems()
        {
             foreach (tbl_000_H_ITEM_PART ic in itmcomlist)
            {
                ic.DocID = 0;
                ic.YEARUSED = UserSettings.LogInYear;
                ic.IsCopied = true;
                ic.CopyDate = DateTime.Now;
                cleaned_list_itmcom.Add(ic);
            }
              foreach (tbl_000_H_ITEM_TABULATION ipi in itmpilist)
            {
                ipi.DocID = 0;
                ipi.YEARUSED = UserSettings.LogInYear;
                ipi.IsCopied = true;
                ipi.CopyDate = DateTime.Now;
                cleaned_list_itmpi.Add(ipi);

            }
              foreach (tbl_000_H_ITEM_TABULATION_VP ivp in itmvplist)
              {
                  ivp.DocID = 0;
                  ivp.YEARUSED = UserSettings.LogInYear;
                  ivp.IsCopied = true;
                  ivp.CopyDate = DateTime.Now;
                  cleaned_list_itmvp.Add(ivp);
              }
              foreach (tbl_000_H_ITEM_TABULATION_ASSY iassy in itmassylist)
              {
                  iassy.DocID = 0;
                  iassy.YEARUSED = UserSettings.LogInYear;
                  iassy.IsCopied = true;
                  iassy.CopyDate = DateTime.Now;
                  cleaned_list_itmassy.Add(iassy);
              }
              foreach (tbl_000_H_ITEM_MPT impt in itmmptlist)
              {
                  impt.DocID = 0;
                  impt.YEARUSED = UserSettings.LogInYear;
                  impt.IsCopied = true;
                  impt.CopyDate = DateTime.Now;
                  cleaned_list_itmmpt.Add(impt);
              }
              foreach (tbl_000_H_ITEM_FDC ifdc in itmfdclist)
              {
                  ifdc.DocID = 0;
                  ifdc.YEARUSED = UserSettings.LogInYear;
                  ifdc.IsCopied = true;
                  ifdc.CopyDate = DateTime.Now;
                  cleaned_list_itmfdc.Add(ifdc);
              }

        }
        //
        private void DsubPI(tbl_000_H_ITEM itm)
        {
            foreach (tbl_000_H_ITEM_TABULATION ip in itm.itemPI)
            {
                itmpibal.Delete(ip);
            }
        }
        private void DsubVP(tbl_000_H_ITEM itm)
        {
            foreach (tbl_000_H_ITEM_TABULATION_VP ivp in itm.itemVP)
            {
                itmvpbal.Delete(ivp);
            }
        }
        private void DsubAssy(tbl_000_H_ITEM itm)
        {
            foreach (tbl_000_H_ITEM_TABULATION_ASSY iassy in itm.itemAssy)
            {
                itmassybal.Delete(iassy);
            }
        }
        private void DeleteSub(List<tbl_000_H_ITEM> todelete_list)
        {
            try
            {
                foreach (tbl_000_H_ITEM i in todelete_list)
                {
                    switch ((ItemComposition)i.Type)
                    {
                        case ItemComposition.Components:
                            foreach (tbl_000_H_ITEM_PART ic in i.itemCom)
                            {
                                itmcombal.Delete(ic);
                            }
                            break;
                        case ItemComposition.PlasticInjection:
                            DsubPI(i);
                            break;
                        case ItemComposition.VacuumPlating:
                            DsubVP(i);
                            break;
                        case ItemComposition.Assembly:
                            DsubAssy(i);
                            break;
                        case ItemComposition.PlasticInjection_VacuumPlating:
                            DsubPI(i);
                            DsubVP(i);
                            break;
                        case ItemComposition.PlasticInjection_Assembly:
                            DsubPI(i);
                            DsubAssy(i);
                            break;
                        case ItemComposition.VacuumPlating_Assembly:
                            DsubVP(i);
                            DsubAssy(i);
                            break;
                        case ItemComposition.AllTabulation:
                            DsubPI(i);
                            DsubVP(i);
                            DsubAssy(i);
                            break;
                        case ItemComposition.ManufacturingProcessTIME:
                            foreach (tbl_000_H_ITEM_MPT impt in i.itemMPT)
                            {
                                itmmptbal.Delete(impt);
                            }
                            break;
                        case ItemComposition.FilmDepreciationCost:
                            foreach (tbl_000_H_ITEM_FDC impt in i.itemFDC)
                            {
                                itmfdcbal.Delete(impt);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void AssignSubItems(List<tbl_000_H_ITEM> itmlist_fill)
        {
            //Filling Lists with Switch
            foreach (tbl_000_H_ITEM i in itmlist_fill)
            {
                if (i != null)
                {
                    switch ((ItemComposition)i.Type)
                    {
                        case ItemComposition.Components:
                            itmcomlist = itmcombal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();

                            i.itemCom = itmcomlist;
                            break;
                        case ItemComposition.PlasticInjection:
                        case ItemComposition.VacuumPlating:
                        case ItemComposition.Assembly:
                        case ItemComposition.PlasticInjection_VacuumPlating:
                        case ItemComposition.PlasticInjection_Assembly:
                        case ItemComposition.VacuumPlating_Assembly:
                        case ItemComposition.AllTabulation:
                            itmpilist = itmpibal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();
                            itmassylist = itmassybal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();
                            itmvplist = itmvpbal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();

                            i.itemPI = itmpilist;
                            i.itemVP = itmvplist;
                            i.itemAssy = itmassylist;
                            break;
                        case ItemComposition.ManufacturingProcessTIME:
                            itmmptlist = itmmptbal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();

                            i.itemMPT = itmmptlist;
                            break;
                        case ItemComposition.FilmDepreciationCost:
                            itmfdclist = itmfdcbal.GetAll().Where(w => w.YEARUSED == i.YEARUSED && w.ItemNo == i.ItemNo).ToList();

                            i.itemFDC = itmfdclist;
                            break;
                    }
                }
            }
            //
        }
        private void Save_item()
        {
            AssignSubItems(itmlist);
            Modify_SubItems();
            foreach (tbl_000_H_ITEM i in itmlist)
            {
                i.DocID = 0;
                i.YEARUSED = UserSettings.LogInYear;
                i.IsCopied = true;
                i.CopyDate = DateTime.Now;
                //Component List
                if (cleaned_list_itmcom.Count > 0)
                {
                    i.itemCom = cleaned_list_itmcom;
                }
                //Tabulation
                if (cleaned_list_itmpi.Count > 0)
                {
                    i.itemPI = cleaned_list_itmpi;
                }
                if (cleaned_list_itmvp.Count > 0)
                {
                    i.itemVP = cleaned_list_itmvp;
                }
                if (cleaned_list_itmassy.Count > 0)
                {
                    i.itemAssy = cleaned_list_itmassy;
                }
                //MPT
                if (cleaned_list_itmmpt.Count > 0)
                {
                    i.itemMPT = cleaned_list_itmmpt;
                }
                //FDC
                if (cleaned_list_itmfdc.Count > 0)
                {
                    i.itemFDC = cleaned_list_itmfdc;
                }
                cleaned_list_itm.Add(i);
            }

            if(itmbal.Save_List(cleaned_list_itm))
            {
                if (cleaned_list_itm.Count > 0)
                {
                    finishing_msg = msgval_success;
                }
                else
                {
                    finishing_msg = msgval_nochanges;
                }
                MessageHelpers.ShowInfo(finishing_msg);
                MyCaller_itm.RefreshGrid();
            }
        }
        #endregion
        private void frm_YearHelper_Load(object sender, EventArgs e)
        {
            Init_Form();
            if(mcboYear.Items.Count < 1)
            {
                mbtnOk.Enabled = false;
            }
        }
        private void mbtnOk_Click(object sender, EventArgs e)
        {
            ContinueCopy();
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
