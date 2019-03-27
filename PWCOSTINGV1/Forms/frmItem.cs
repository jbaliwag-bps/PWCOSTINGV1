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
using MetroFramework.Controls;
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._000;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmItem : MetroForm
    {

        PlasticInjectionBAL pibal;
        VacuumPlatingBAL vpbal;
        AssymblyBAL assybal;
        MODRCBAL mrbal;
        ComponentBAL combal;
        CategoryBAL catbal;
        ItemBAL itembal;
        ItemCompositionBAL item_combal;
        ItemTabulationPIBAL item_pibal;
        ItemTabulationVPBAL item_vpbal;
        ItemTabulationAssyBAL item_assybal;
        ItemMPTBAL item_mptbal;
        ItemFDCBAL item_fdcbal;

        tbl_000_H_PI pi;
        tbl_000_H_VP vp;
        tbl_000_H_ASSY assy;
        tbl_000_MODRC modrc;
        tbl_000_H_PART com;

        tbl_000_H_ITEM item;
        tbl_000_H_CATEGORY cat;

        List<tbl_000_H_ITEM_PART> item_comlist;
        List<tbl_000_H_ITEM_TABULATION> item_pilist;
        List<tbl_000_H_ITEM_TABULATION_VP> item_vplist;
        List<tbl_000_H_ITEM_TABULATION_ASSY> item_assylist;
        List<tbl_000_H_ITEM_MPT> item_mptlist;
        List<tbl_000_H_ITEM_FDC> item_fdclist;

        //Binder
        BindingList<tbl_000_H_ITEM_PART> bitem_comlist;
        BindingList<tbl_000_H_ITEM_TABULATION> bitem_pilist;
        BindingList<tbl_000_H_ITEM_TABULATION_VP> bitem_vplist;
        BindingList<tbl_000_H_ITEM_TABULATION_ASSY> bitem_assylist;
        BindingList<tbl_000_H_ITEM_MPT> bitem_mptlist;
        BindingList<tbl_000_H_ITEM_FDC> bitem_fdclist; 

        ErrorProviderExtended err;

        public FormState MyState { get; set; }
        public frmItemList MyCaller { get; set; }
        public string itemno { get; set; }
        public int yearused { get; set; }
        public string moldno { get; set; }
        public string partnoVP { get; set; }
        public string partnoAssy { get; set; }
        public string sectioncode { get; set; }
        public string partnoCL { get; set; }

        public int _yearused { get; set; }
        public string _itemno { get; set; }
        private void Init_Form()
        {
            try
            {
                var strheader = "Item";
                mtcItem.SelectedIndex = 0;
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        LockColumn(false);
                        PanelSetup();
                        strheader += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        AssignRecord(false, true);
                        LockFields(false);
                        LockColumn(false);
                        if (MyState == FormState.View)
                        {
                            LockFields(true);
                            LockColumn(true);
                            mbtnSave.BackgroundImage = Properties.Resources.editicon;
                            strheader += " - View";
                            mbtnSave.Focus();
                        }
                        else
                        {
                            mtxtItemNo.ReadOnly = true;
                            mbtnSave.BackgroundImage = Properties.Resources.saveicon1;
                            strheader += " - Edit";
                        }
                        break;
                }
                this.Text = strheader;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
            ListHelper.FillMetroCombo(mcboCatCode, catbal.GetAll().Select(i => new { i.CATCODE, i.CATDESC }).Distinct().OrderBy(m => m.CATDESC).ToList(), "CATCODE", "CATDESC");
            lblTotalDepn.Text = CalculateTotal(mgridListPI, "colDepnMold").ToString();
            lblTotalOPTime.Text = CalculateTotal(mgridListPI, "colOperatingTime").ToString();
            lblTotalSTDRateHour.Text = CalculateTotal(mgridListAssy, "colSTDRATEperHour").ToString();
            lblTotalAmount.Text = CalculateTotal(mgridListCL, "colAmount").ToString();
        }
        private void AssignMain()
        {
            item = itembal.GetByID(UserSettings.LogInYear, itemno);
            if (item == null)
            {
                item = new tbl_000_H_ITEM();
                item.state = "add";
                item.YEARUSED = UserSettings.LogInYear;
                item.ItemNo = mtxtItemNo.Text;
                item.CreatedDate = DateTime.Now;
                item.CreatedBy = UserSettings.Username;
                item.LockedDate = DateTime.Now;
                item.IsCopied = false;
                item.CopyDate = DateTime.Now;
                item.ImportDate = DateTime.Now;
            }
            else
            {
                item.state = "update";
            }
            
            item.Description = mtxtItemDesc.Text;
            item.CatCode = BPSUtilitiesV1.NZ(mcboCatCode.SelectedValue, "").ToString();
            item.CatDesc = mcboCatCode.Text;
            if (!item.IsLocked && mcbLock.Checked)
            {
                item.LockedDate = DateTime.Now;
            }
            item.IsLocked = mcbLock.Checked;
            //Temporary
            item.LotQTY = 0;
            item.ProdMonth = 0;
            //
            item.LastUpdated = DateTime.Now;
            item.UpdatedDate = DateTime.Now;
            item.UpdatedBy = UserSettings.Username;
        }
        private void RenewLists()
        {
            item_comlist = new List<tbl_000_H_ITEM_PART>();
            item_pilist = new List<tbl_000_H_ITEM_TABULATION>();
            item_vplist = new List<tbl_000_H_ITEM_TABULATION_VP>();
            item_assylist = new List<tbl_000_H_ITEM_TABULATION_ASSY>();
            item_mptlist = new List<tbl_000_H_ITEM_MPT>();
            item_fdclist = new List<tbl_000_H_ITEM_FDC>();
        }
        private double CalculateTotal(DataGridView dgv, string columnname)
        {
            double sum = 0;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                sum += Convert.ToDouble(dgv.Rows[i].Cells[columnname].Value);
            }
            sum = Math.Round(sum, 4);
            return sum;
        }
        private void PanelSetup()
        {
            if (mtcItem.SelectedTab == mtpTabulationData || mtcItem.SelectedTab == mtpCompositionList)
            {
                var bluetheme = ColorTranslator.FromHtml("#00AEDB");
                TabPage page = mtcItem.SelectedTab;

                //Panels and their Labels
                var panels = page.Controls.OfType<Panel>();
                foreach (var p in panels)
                {
                    p.BackColor = bluetheme;
                    var plabels = p.Controls.OfType<Label>();
                    foreach (var plbl in plabels)
                    {
                        plbl.ForeColor = Color.White;
                    }
                }
            }
        }
        private void LockFields(Boolean IsLocked)
        {
            mtxtItemNo.ReadOnly = IsLocked;
            mtxtItemDesc.ReadOnly = IsLocked;
            mcboCatCode.Enabled = !IsLocked;
            mcbLock.Enabled = !IsLocked;
        }
        private void LockColumn(Boolean IsLock)
        {
            mgridListCL.ReadOnly = IsLock;
            mgridListPI.ReadOnly = IsLock;
            mgridListVP.ReadOnly = IsLock;
            mgridListMPT.ReadOnly = IsLock;
            mgridListFDC.ReadOnly = IsLock;
        }
        //Assigning
        private void FilltxtAutoComplete()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var source = itembal.GetAllItemNos();
            foreach (string i in source)
            {
                collection.Add(i);
            }
            mtxtItemNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtxtItemNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mtxtItemNo.AutoCompleteCustomSource = collection;
        }
        //End Assigning Subs
        private void LoadItem(tbl_000_H_ITEM item)
        {
            bitem_comlist = new BindingList<tbl_000_H_ITEM_PART>(item.itemCom);
            mgridListCL.DataSource = bitem_comlist;

            bitem_pilist = new BindingList<tbl_000_H_ITEM_TABULATION>(item.itemPI);
            mgridListPI.DataSource = bitem_pilist;

            bitem_vplist = new BindingList<tbl_000_H_ITEM_TABULATION_VP>(item.itemVP);
            mgridListVP.DataSource = bitem_vplist;

            bitem_assylist = new BindingList<tbl_000_H_ITEM_TABULATION_ASSY>(item.itemAssy);
            mgridListAssy.DataSource = bitem_assylist;

            bitem_mptlist = new BindingList<tbl_000_H_ITEM_MPT>(item.itemMPT);
            mgridListMPT.DataSource = bitem_mptlist;

            bitem_fdclist = new BindingList<tbl_000_H_ITEM_FDC>(item.itemFDC);
            mgridListFDC.DataSource = bitem_fdclist;
        }
        private void AssignRecord(Boolean IsSave, Boolean IsNewItem)
        {
            try
            {
                AssignMain();
                if (IsSave)
                {
                    //Composition List
                    for (int i = 0; i < mgridListCL.RowCount; i++)
                    {
                        if (mgridListCL.Rows[i].IsNewRow) continue;
                        var docid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridListCL.Rows[i].Cells["colDocIDCL"].Value, 0));
                        var item_com = item_combal.GetByID(docid);
                        if (item_com == null)
                        {
                            item_com = new tbl_000_H_ITEM_PART();
                            item_com.state = "add";
                            item_com.YEARUSED = UserSettings.LogInYear;
                            item_com.ItemNo = mtxtItemNo.Text;
                            item_com.PartNo = mgridListCL.Rows[i].Cells["colPartNoCL"].Value.ToString();
                            item_com.IsCopied = false;
                            item_com.CopyDate = DateTime.Now;
                            item_com.ImportDate = DateTime.Now;
                        }
                        else
                        {
                            item_com.state = "update";
                        }
                        item_com.PartName = mgridListCL.Rows[i].Cells["colDescriptionCL"].Value.ToString();
                        item_com.PartType = mgridListCL.Rows[i].Cells["colBagging"].Value.ToString();
                        item_com.ItemAddress = mgridListCL.Rows[i].Cells["colAddress"].Value.ToString();
                        item_com.ItemUsage = Convert.ToDecimal(mgridListCL.Rows[i].Cells["colUsageCL"].Value);
                        item_com.SectionCode = mgridListCL.Rows[i].Cells["colProcess"].Value.ToString();
                        item_com.ItemVendor = mgridListCL.Rows[i].Cells["colVendor"].Value.ToString();
                        item_com.ItemUnit = mgridListCL.Rows[i].Cells["colUnit"].Value.ToString();
                        item_com.UnitPrice = Convert.ToDecimal(mgridListCL.Rows[i].Cells["colUnitPrice"].Value);
                        item_com.Amount = Convert.ToDecimal(mgridListCL.Rows[i].Cells["colAmount"].Value);
                        item_comlist.Add(item_com);
                    }
                    if (item_comlist.Count > 0)
                    {
                        item.itemCom = item_comlist;
                    }

                    //Tabulation Data: PI
                    for (int i = 0; i < mgridListPI.RowCount; i++)
                    {
                        if (mgridListPI.Rows[i].IsNewRow) continue;
                        var docid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridListPI.Rows[i].Cells["colDocIDPI"].Value, 0));
                        var item_pi = item_pibal.GetByID(docid);
                        if (item_pi == null)
                        {
                            item_pi = new tbl_000_H_ITEM_TABULATION();
                            item_pi.state = "add";
                            item_pi.YEARUSED = UserSettings.LogInYear;
                            item_pi.ItemNo = mtxtItemNo.Text;
                            item_pi.PartNo = mgridListPI.Rows[i].Cells["colMoldNo"].Value.ToString();
                            item_pi.IsCopied = false;
                            item_pi.CopyDate = DateTime.Now;
                        }
                        else
                        {
                            item_pi.state = "update";
                        }
                        item_pi.PartName = mgridListPI.Rows[i].Cells["colPartNamePI"].Value.ToString();
                        item_pi.AcquisitionCost = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colAcquCost"].Value);
                        item_pi.QtyProduced = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colQTYprodcd"].Value);
                        item_pi.DepQty = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colDepnQty"].Value);
                        item_pi.MoldCost = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colMoldCost"].Value);
                        item_pi.ESTSHHR = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colSPH"].Value);
                        item_pi.ESTPCSHR = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colPPH"].Value);
                        item_pi.ESTHC = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colUsagePI"].Value);
                        item_pi.DepnMold = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colDepnMold"].Value);

                        //Temporary
                        item_pi.ACTSHHR = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colSPH"].Value);
                        item_pi.ACTPCSHR = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colPPH"].Value);
                        item_pi.ACTHC = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colUsagePI"].Value);
                        //

                        item_pi.Cavity = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colCavity"].Value);
                        item_pi.MoldSetUpTime = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colMSandChangehr"].Value);
                        item_pi.Oz = mgridListPI.Rows[i].Cells["colOz"].Value.ToString();
                        item_pi.Purge_G = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colPurge"].Value);
                        item_pi.OPTime = Convert.ToDecimal(mgridListPI.Rows[i].Cells["colOperatingTime"].Value);
                        item_pilist.Add(item_pi);
                    }
                    if (item_pilist.Count > 0)
                    {
                        item.itemPI = item_pilist;
                    }

                    //Tabulation Data: VP
                    for (int i = 0; i < mgridListVP.RowCount; i++)
                    {
                        if (mgridListVP.Rows[i].IsNewRow) continue;
                        var docid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridListVP.Rows[i].Cells["colDocIDVP"].Value, 0));
                        var item_vp = item_vpbal.GetByID(docid);
                        if (item_vp == null)
                        {
                            item_vp = new tbl_000_H_ITEM_TABULATION_VP();
                            item_vp.state = "add";
                            item_vp.YEARUSED = UserSettings.LogInYear;
                            item_vp.ItemNo = mtxtItemNo.Text;
                            item_vp.PartNo = mgridListVP.Rows[i].Cells["colPartNoVP"].Value.ToString();
                            item_vp.CreatedDate = DateTime.Now;
                            item_vp.CreatedBy = UserSettings.Username;
                            item_vp.IsCopied = false;
                            item_vp.CopyDate = DateTime.Now;
                        }
                        else
                        {
                            item_vp.state = "update";
                        }

                        item_vp.PartName = mgridListVP.Rows[i].Cells["colPartNameVP"].Value.ToString();
                        item_vp.SourceData = mgridListVP.Rows[i].Cells["colSourceData"].Value.ToString();
                        item_vp.ActualTimePerUnit = Convert.ToDecimal(mgridListVP.Rows[i].Cells["colATperUnit"].Value);
                        //Temporary
                        item_vp.VP_Operation = mgridListVP.Rows[i].Cells["colHC"].Value.ToString();
                        item_vp.TotalQty = Convert.ToDecimal(mgridListVP.Rows[i].Cells["colQty"].Value);
                        item_vp.TotalTime = 0;
                        item_vplist.Add(item_vp);
                    }
                    if (item_vplist.Count > 0)
                    {
                        item.itemVP = item_vplist;
                    }

                    //Tabulation Data: Assy
                    for (int i = 0; i < mgridListAssy.RowCount; i++)
                    {
                        if (mgridListAssy.Rows[i].IsNewRow) continue;
                        var docid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridListAssy.Rows[i].Cells["colDocIDAssy"].Value, 0));
                        var item_assy = item_assybal.GetByID(docid);
                        if (item_assy == null)
                        {
                            item_assy = new tbl_000_H_ITEM_TABULATION_ASSY();
                            item_assy.state = "add";
                            item_assy.YEARUSED = UserSettings.LogInYear;
                            item_assy.ItemNo = mtxtItemNo.Text;
                            item_assy.PartNo = mgridListAssy.Rows[i].Cells["colPartNoAssy"].Value.ToString();
                            item_assy.CreatedDate = DateTime.Now;
                            item_assy.CreatedBy = UserSettings.Username;
                            item_assy.IsCopied = false;
                            item_assy.CopyDate = DateTime.Now;
                        }
                        else
                        {
                            item_assy.state = "update";
                        }
                        item_assy.PartName = mgridListAssy.Rows[i].Cells["colPartNameAssy"].Value.ToString();
                        item_assy.Usage = Convert.ToDecimal(mgridListAssy.Rows[i].Cells["colOPUSG"].Value);

                        //Temporary
                        item_assy.OPASSY = Convert.ToInt32(mgridListAssy.Rows[i].Cells["colOPHC"].Value);
                        item_assy.OPPI = Convert.ToInt32(mgridListAssy.Rows[i].Cells["colOPHC"].Value);
                        //
                        item_assy.STDRATEPERHOUR = Convert.ToDecimal(mgridListAssy.Rows[i].Cells["colSTDRATEperHour"].Value);
                        item_assylist.Add(item_assy);
                    }
                    if (item_assylist.Count > 0)
                    {
                        item.itemAssy = item_assylist;
                    }

                    //MPT
                    for (int i = 0; i < mgridListMPT.RowCount; i++)
                    {
                        if (mgridListMPT.Rows[i].IsNewRow) continue;
                        var docid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridListMPT.Rows[i].Cells["colDocIDMPT"].Value, 0));
                        var item_mpt = item_mptbal.GetByID(docid);
                        if (item_mpt == null)
                        {
                            item_mpt = new tbl_000_H_ITEM_MPT();
                            item_mpt.state = "add";
                            item_mpt.YEARUSED = UserSettings.LogInYear;
                            item_mpt.ItemNo = mtxtItemNo.Text;
                            item_mpt.SectionCode = mgridListMPT.Rows[i].Cells["colSectionCode"].Value.ToString();
                            item_mpt.CreatedDate = DateTime.Now;
                            item_mpt.CreatedBy = UserSettings.Username;
                            item_mpt.IsCopied = false;
                            item_mpt.CopyDate = DateTime.Now;
                        }
                        else
                        {
                            item_mpt.state = "update";
                        }
                        item_mpt.SectionName = mgridListMPT.Rows[i].Cells["colSectionName"].Value.ToString();
                        item_mpt.ProductionTime = Convert.ToDecimal(mgridListMPT.Rows[i].Cells["colProductionTime"].Value);
                        item_mptlist.Add(item_mpt);
                    }
                    if (item_mptlist.Count > 0)
                    {
                        item.itemMPT = item_mptlist;
                    }

                    //FDC
                    for (int i = 0; i < mgridListFDC.RowCount; i++)
                    {
                        if (mgridListFDC.Rows[i].IsNewRow) continue;
                        var type = BPSUtilitiesV1.NZ(mgridListFDC.Rows[i].Cells["colType"].Value, "").ToString();
                        var item_fdc = item_fdcbal.GetByID(UserSettings.LogInYear, mtxtItemNo.Text, type);
                        if (item_fdc == null)
                        {
                            item_fdc = new tbl_000_H_ITEM_FDC();
                            item_fdc.state = "add";
                            item_fdc.YEARUSED = UserSettings.LogInYear;
                            item_fdc.ItemNo = mtxtItemNo.Text;
                            item_fdc.DepnType = mgridListFDC.Rows[i].Cells["colType"].Value.ToString();
                            item_fdc.CreatedDate = DateTime.Now;
                            item_fdc.CreatedBy = UserSettings.Username;
                            item_fdc.IsCopied = false;
                            item_fdc.CopyDate = DateTime.Now;
                        }
                        else
                        {
                            item_fdc.state = "update";
                        }
                        item_fdc.Description = mgridListFDC.Rows[i].Cells["colDesciptionFDC"].Value.ToString();
                        item_fdc.FDC_QTY = Convert.ToDecimal(mgridListFDC.Rows[i].Cells["colQTYFDC"].Value);
                        item_fdc.AcquisitionCost = Convert.ToDecimal(mgridListFDC.Rows[i].Cells["colAcquCostFDC"].Value);
                        item_fdc.DepnQTY = Convert.ToDecimal(mgridListFDC.Rows[i].Cells["colDepnQtyFDC"].Value);
                        item_fdc.DepnCost = Convert.ToDecimal(mgridListFDC.Rows[i].Cells["colDepnCost"].Value);
                        item_fdc.DepnFilm = Convert.ToDecimal(mgridListFDC.Rows[i].Cells["colDepnFilm"].Value);
                        item_fdclist.Add(item_fdc);
                    }
                    if (item_fdclist.Count > 0)
                    {
                        item.itemFDC = item_fdclist;
                    }
                }
                else
                {
                    if (IsNewItem)
                        item = itembal.GetByID(UserSettings.LogInYear, itemno);
                    else
                        itemno = item.ItemNo;

                    if (item != null)
                    {
                        mtxtItemNo.Text = item.ItemNo;
                        mtxtItemDesc.Text = item.Description;
                        mcboCatCode.SelectedValue = item.CatCode;
                        mcboCatCode.Text = item.CatDesc;
                        mcbLock.Checked = item.IsLocked;
                        item.LastUpdated = DateTime.Now;

                        if (mcbLock.Checked)
                        {
                            item.LockedDate = DateTime.Now;
                        }

                        item.UpdatedDate = DateTime.Now;
                        int subsyearused = UserSettings.LogInYear;
                        if (!IsNewItem)
                            subsyearused = _yearused;
                        LoadItem(item);
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
            try 
            {
                FormHelpers.CursorWait(true);
                if (IsValid())
                {
                    var isSuccess = false;
                    var msg = "";
                    RenewLists();
                    AssignRecord(true, true);
                    switch (MyState)
                    {
                        case FormState.Add:
                            msg = "Saving";
                            if (itembal.Save(item))

                                isSuccess = true;
                            break;
                        case FormState.Edit:
                            msg = "Updating";
                            if (itembal.Update(item))
                            {
                                isSuccess = true;
                            }
                            break;
                    }
                    if (isSuccess)
                    {
                        MessageHelpers.ShowInfo(msg + " Successful!");
                        MyCaller.RefreshGrid();
                        this.Close();
                    }
                    else
                    {
                        MessageHelpers.ShowWarning(msg + " Failed!");
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
        private Boolean IsValid()
        {
            try
            {
                return err.CheckAndShowSummaryErrorMessage();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowWarning(ex.Message);
                return false;
            }
        }
        public void LoadGridCL()
        {
            var newitem_comlist = new List<tbl_000_H_ITEM_PART>();
            com = combal.GetByID(yearused, partnoCL);
            bool isExists = false;
            if (bitem_comlist != null && bitem_comlist.Count > 0)
            {
                foreach (tbl_000_H_ITEM_PART bic in bitem_comlist)
                {
                    if (bic.PartNo == com.PartNo)
                    {
                        MessageHelpers.ShowError("PartNo " + bic.PartNo + " was loaded already!");
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                if (com != null)
                {
                    if (bitem_comlist == null)
                    {
                        var itmcom = new tbl_000_H_ITEM_PART();
                        itmcom.PartNo = com.PartNo;
                        itmcom.PartName = com.PartName;
                        newitem_comlist.Add(itmcom);
                        bitem_comlist = new BindingList<tbl_000_H_ITEM_PART>(newitem_comlist);
                        mgridListCL.DataSource = bitem_comlist;
                    }
                    else
                    {
                        var newbitem_comlist = bitem_comlist.AddNew();
                        newbitem_comlist.PartNo = com.PartNo;
                        newbitem_comlist.PartName = com.PartName;
                    }
                }
            }
        }
        public void LoadGridPI()
        {
            var newitem_pilist = new List<tbl_000_H_ITEM_TABULATION>();
            pi = pibal.GetByID(yearused, moldno);
            bool isExists = false;
            if (bitem_pilist != null && bitem_pilist.Count > 0)
            {
                foreach (tbl_000_H_ITEM_TABULATION bipi in bitem_pilist)
                {
                    if (bipi.PartNo == pi.MoldNo)
                    {
                        MessageHelpers.ShowError("MoldNo "+ bipi.PartNo + " was loaded already!");
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                if (pi != null)
                {
                    if (bitem_pilist == null)
                    {
                        var itmpi = new tbl_000_H_ITEM_TABULATION();
                        itmpi.PartNo = pi.MoldNo;
                        itmpi.PartName = pi.MoldName;
                        itmpi.ESTPCSHR = pi.SPH;
                        itmpi.Cavity = pi.Cavity;
                        itmpi.ESTPCSHR = pi.SPH;
                        itmpi.Oz = pi.Oz;
                        itmpi.Purge_G = pi.PurgePerG;
                        newitem_pilist.Add(itmpi);
                        bitem_pilist = new BindingList<tbl_000_H_ITEM_TABULATION>(newitem_pilist);
                        mgridListPI.DataSource = bitem_pilist;
                    }
                    else
                    {
                        var newbitem_pilist = bitem_pilist.AddNew();
                        newbitem_pilist.PartNo = pi.MoldNo;
                        newbitem_pilist.PartName = pi.MoldName;
                        newbitem_pilist.ESTPCSHR = pi.SPH;
                        newbitem_pilist.Cavity = pi.Cavity;
                        newbitem_pilist.ESTPCSHR = pi.SPH;
                        newbitem_pilist.Oz = pi.Oz;
                        newbitem_pilist.Purge_G = pi.PurgePerG;
                    }
                }
            }
        }
        public void LoadGridVP()
        {
            var newitem_vplist = new List<tbl_000_H_ITEM_TABULATION_VP>();
            vp = vpbal.GetByID(yearused, partnoVP);
            bool isExists = false;
            if (bitem_vplist != null && bitem_vplist.Count > 0)
            {
                foreach (tbl_000_H_ITEM_TABULATION_VP biv in bitem_vplist)
                {
                    if (biv.PartNo == vp.PartNo)
                    {
                        MessageHelpers.ShowError("PartNo " + biv.PartNo + " was loaded already!");
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                if (vp != null)
                {
                    if (bitem_vplist == null)
                    {
                        var itmvp = new tbl_000_H_ITEM_TABULATION_VP();
                        itmvp.PartNo = vp.PartNo;
                        itmvp.PartName = vp.PartName;
                        itmvp.SourceData = vp.SourceData;
                        newitem_vplist.Add(itmvp);
                        bitem_vplist = new BindingList<tbl_000_H_ITEM_TABULATION_VP>(newitem_vplist);
                        mgridListVP.DataSource = bitem_vplist;
                    }
                    else
                    {
                        var newbitem_vplist = bitem_vplist.AddNew();
                        newbitem_vplist.PartNo = vp.PartNo;
                        newbitem_vplist.PartName = vp.PartName;
                        newbitem_vplist.SourceData = vp.SourceData;
                    }
                }
            }
        }
        public void LoadGridAssy()
        {
            var newitem_assylist = new List<tbl_000_H_ITEM_TABULATION_ASSY>();
            assy = assybal.GetByID(yearused, partnoAssy);
            bool isExists = false;
            if (bitem_assylist != null && bitem_assylist.Count > 0)
            {
                foreach (tbl_000_H_ITEM_TABULATION_ASSY bias in bitem_assylist)
                {
                    if (bias.PartNo == assy.PartNo)
                    {
                        MessageHelpers.ShowError("PartNo " + bias.PartNo + " was loaded already!");
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                if (assy != null)
                {
                    if (bitem_assylist == null)
                    {
                        var itmassy = new tbl_000_H_ITEM_TABULATION_ASSY();
                        itmassy.PartNo = assy.PartNo;
                        itmassy.PartName = assy.PartName;
                        newitem_assylist.Add(itmassy);
                        bitem_assylist = new BindingList<tbl_000_H_ITEM_TABULATION_ASSY>(newitem_assylist);
                        mgridListAssy.DataSource = bitem_assylist;
                    }
                    else
                    {
                        var newbitem_assylist = bitem_assylist.AddNew();
                        newbitem_assylist.PartNo = assy.PartNo;
                        newbitem_assylist.PartName = assy.PartName;
                    }
                }
            }
        }
        public void LoadGridMPT()
        {
            var newitem_mptlist = new List<tbl_000_H_ITEM_MPT>();
            modrc = mrbal.GetByID(sectioncode);
            bool isExists = false;
            if (bitem_mptlist != null && bitem_mptlist.Count > 0)
            {
                foreach (tbl_000_H_ITEM_MPT bimpt in bitem_mptlist)
                {
                    if (bimpt.SectionCode == modrc.SectionCode)
                    {
                        MessageHelpers.ShowError("SectionCode " + bimpt.SectionCode + " was loaded already!");
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                if (modrc != null)
                {
                    if (bitem_mptlist == null)
                    {
                        var itmmpt = new tbl_000_H_ITEM_MPT();
                        itmmpt.SectionCode = modrc.SectionCode;
                        itmmpt.SectionName = modrc.Description;
                        itmmpt.ProductionTime = modrc.Time;
                        newitem_mptlist.Add(itmmpt);
                        bitem_mptlist = new BindingList<tbl_000_H_ITEM_MPT>(newitem_mptlist);
                        mgridListMPT.DataSource = bitem_mptlist;
                    }
                    else
                    {
                        var newbitem_mptlist = bitem_mptlist.AddNew();
                        newbitem_mptlist.SectionCode = modrc.SectionCode;
                        newbitem_mptlist.SectionName = modrc.Description;
                        newbitem_mptlist.ProductionTime = modrc.Time;
                    }
                }
            }
        }
        public void ChbxSetting(Boolean IsChecked)
        {
            if (mcbLock.Checked == IsChecked)
            {
                mcbLock.Text = "Locked";
            }
            else
            {
                mcbLock.Text = "UnLocked";
            }
        }
        public frmItem()
        {
            InitializeComponent();
            pibal = new PlasticInjectionBAL();
            vpbal = new VacuumPlatingBAL();
            assybal = new AssymblyBAL();
            mrbal = new MODRCBAL();
            combal = new ComponentBAL();
            catbal = new CategoryBAL();
            itembal = new ItemBAL();
            item_combal = new ItemCompositionBAL();
            item_pibal = new ItemTabulationPIBAL();
            item_vpbal = new ItemTabulationVPBAL();
            item_assybal = new ItemTabulationAssyBAL();
            item_mptbal = new ItemMPTBAL();
            item_fdcbal = new ItemFDCBAL();

            pi = new tbl_000_H_PI();
            vp = new tbl_000_H_VP();
            assy = new tbl_000_H_ASSY();
            modrc = new tbl_000_MODRC();
            com = new tbl_000_H_PART();
            item = new tbl_000_H_ITEM();
            cat = new tbl_000_H_CATEGORY();

            item_comlist = new List<tbl_000_H_ITEM_PART>();
            item_pilist = new List<tbl_000_H_ITEM_TABULATION>();
            item_vplist = new List<tbl_000_H_ITEM_TABULATION_VP>();
            item_assylist = new List<tbl_000_H_ITEM_TABULATION_ASSY>();
            item_mptlist = new List<tbl_000_H_ITEM_MPT>();
            item_fdclist = new List<tbl_000_H_ITEM_FDC>();

            err = new ErrorProviderExtended();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            PanelSetup();
            Init_Form();
            this.Width = 1200;
            ChbxSetting(true);
            FilltxtAutoComplete();
        }
        private void AddRow(string ListToAdd, string FormHeader)
        {
            var frm = new frm_DynamicList();
            frm.KindOfList = ListToAdd;
            frm.Text = FormHeader;
            frm.MyCaller = this;
            FormHelpers.ShowDialog(frm);
        }
        private void mbtnAddPI_Click(object sender, EventArgs e)
        {
            AddRow("MT_PI", "List of MT: Plastic Injection");
        }

        private void mbtnAddVP_Click(object sender, EventArgs e)
        {
            AddRow("MT_VP", "List of MT: Vacuum Plating");
        }

        private void mbtnAddAssy_Click(object sender, EventArgs e)
        {
            AddRow("MT_ASSY", "List of MT: Assembly");
        }
        private void mbtnAddMPT_Click(object sender, EventArgs e)
        {
            AddRow("MPT", "List of MOD/RC");
        }
        private void mbtnAddCL_Click(object sender, EventArgs e)
        {
            AddRow("CL", "List of Components");
        }
        private void RemoveRow(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    if (MessageHelpers.ShowQuestion("Are you sure you want to remove selected record?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dgv.SelectedRows)
                        {
                            dgv.Rows.RemoveAt(item.Index);
                        }
                    }
                }
                else
                {
                    MessageHelpers.ShowError("Number of selected record must be greater than 0!");
                }
            }
            catch
            {

            }
        }
        private void mbtnRemoveMPT_Click(object sender, EventArgs e)
        {
            RemoveRow(mgridListMPT);
        }
        private void mbtnRemoveCL_Click(object sender, EventArgs e)
        {
            RemoveRow(mgridListCL);
        }
        private void mbtnRemovePI_Click(object sender, EventArgs e)
        {
            RemoveRow(mgridListPI);
        }

        private void mbtnRemoveVP_Click(object sender, EventArgs e)
        {
            RemoveRow(mgridListVP);
        }
        private void mbtnRemoveAssy_Click(object sender, EventArgs e)
        {
            RemoveRow(mgridListAssy);
        }
        private void mcbLock_CheckedChanged(object sender, EventArgs e)
        {
            ChbxSetting(true);
        }
        private void CleanSaving()
        {
            string msg = "";
            switch (MyState)
            {
                case FormState.Add:
                case FormState.Edit:
                    msg = "save";
                    if (MyState == FormState.Edit)
                    {
                        msg = "update";
                    }
                    if (MessageHelpers.ShowQuestion("Are you sure you want to " + msg + " record?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        SaveRecord();
                    }
                    break;
                case FormState.View:
                    MyState = FormState.Edit;
                    Init_Form();
                    break;
            }
        }
        private List<string> ExcemptedColumns()
        {
            var Headers = new List<string>();
            Headers.Add("Bagging");
            Headers.Add("Vendor");
            return Headers;
        }
        private void CheckGridCell(DataGridView dgv)
        {
            var emptmsg = "";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (!dgv.Rows[i].IsNewRow)
                {
                    for (int x = 0; x < dgv.ColumnCount; x++)
                    {
                        //Excemptions
                        if (dgv.Columns[x].Visible == false) continue;
                        if (ExcemptedColumns().Contains(dgv.Columns[x].HeaderText)) continue;
                        //
                        if (BPSUtilitiesV1.NZ(dgv[x, i].Value, "").ToString() == "")
                        {
                            if (emptmsg == "")
                            {
                                emptmsg = "Empty Fields\n";
                            }
                            int rowno = i + 1;
                            emptmsg += "\r\n>" + dgv.Columns[x].HeaderText + " (row " + rowno + ")";
                        }
                    }
                    if (emptmsg != "")
                    {
                        throw new Exception(emptmsg);
                    }
                }
            }
        }
        private void mbtnSave_Click(object sender, EventArgs e)
        {
            //Trapping errors before saving
            err.Clear();
            try
            {
                if (mtxtItemNo.Text != "" && mtxtItemDesc.Text != "")
                {
                    if (mtcItem.SelectedTab == mtpCompositionList)
                    {
                        if (mgridListCL.RowCount > 0)
                        {
                            CheckGridCell(mgridListCL);
                        }
                        CleanSaving();
                    }
                    else if (mtcItem.SelectedTab == mtpTabulationData)
                    {
                        if (mgridListPI.RowCount > 0 || mgridListVP.RowCount > 0 || mgridListAssy.RowCount > 0)
                        {
                            if (mgridListPI.RowCount > 0)
                            {
                                CheckGridCell(mgridListPI);
                            }
                            if (mgridListVP.RowCount > 0)
                            {
                                CheckGridCell(mgridListVP);
                            }
                            if (mgridListAssy.RowCount > 0)
                            {
                                CheckGridCell(mgridListAssy);
                            }
                        }
                        CleanSaving();
                    }
                    else if (mtcItem.SelectedTab == mtpManufacturingPT)
                    {
                        if (mgridListMPT.RowCount > 0)
                        {
                            CheckGridCell(mgridListMPT);
                        }
                        CleanSaving();
                    }
                    else if (mtcItem.SelectedTab == mtpDepreciationCost)
                    {
                        if (mgridListFDC.RowCount > 1)
                        {
                            CheckGridCell(mgridListFDC);
                        }
                        CleanSaving();
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (mtxtItemNo.Text == "" && mtxtItemDesc.Text == "")
                    {
                        err.SetError(mtxtItemNo, "Required!");
                        err.SetError(mtxtItemDesc, "Required!");
                    }
                    else if (mtxtItemDesc.Text == "")
                    {
                        err.SetError(mtxtItemDesc, "Required!");
                    }
                    else
                    {
                        err.SetError(mtxtItemNo, "Required!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }

        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mgridListCL_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListCL, sender, e);
        }

        private void mgridListPI_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListPI, sender, e);
        }

        private void mgridListVP_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListVP, sender, e);
        }

        private void mgridListAssy_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListAssy, sender, e);
        }

        private void mgridListMPT_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListMPT, sender, e);
        }

        private void mgridListFDC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            NumbersOnly.DatagridView(mgridListFDC, sender, e);
        }

        private void mgridListFDC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void mgridListMPT_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        public void RefreshForm()
        {
            foreach (TabPage page in mtcItem.TabPages)
            {
                var grids = page.Controls.OfType<MetroGrid>().ToList();
                foreach (MetroGrid grid in grids)
                {
                    grid.Rows.Clear();
                }
            }
            mtxtItemDesc.Text = "";
        }
        public void LoadExistingItem()
        {
            try
            {
                if ((_itemno != null) &&
                    (_yearused != 0 && _itemno != "")) 
                {
                    FormHelpers.CursorWait(true);
                    AssignRecord(false, false);
                    FormHelpers.CursorWait(false);
                }
                else
                {
                    mtxtItemNo.Text = "";
                    mtxtItemDesc.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void KeyHandler(string selecteditemno)
       {

                item = itembal.GetAll().Where(w => w.ItemNo == selecteditemno && w.YEARUSED == UserSettings.LogInYear).FirstOrDefault();
                if (item != null)
                {
                    mtxtItemDesc.Text = BPSUtilitiesV1.NZ(item.Description, "").ToString();
                        if (MyState == FormState.Add)
                        {
                            FormHelpers.CursorWait(true);
                            frmExistingItemLoad frm = new frmExistingItemLoad();
                            frm.itemno = item.ItemNo;
                            frm.MyCaller = this;
                            FormHelpers.ShowDialog(frm);
                            FormHelpers.CursorWait(false);
                        }
                }
                else
                {
                    RefreshForm();
                }
        }
        private void mtxtItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyState == FormState.Add)
            {
                string selecteditemno = BPSUtilitiesV1.NZ(mtxtItemNo.Text, "").ToString();
                if (e.KeyCode == Keys.Enter)
                {
                    KeyHandler(selecteditemno);
                }
            }
        }
        private void mgridListAssy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    int ophc = Convert.ToInt32(mgridListAssy.Rows[e.RowIndex].Cells["colOPHC"].Value);
                    int qty = Convert.ToInt32(mgridListAssy.Rows[e.RowIndex].Cells["colOPQTY"].Value);
                    if (ophc != 0  && qty != 0)
                    {
                        var answer = (double) ophc / qty;
                        mgridListAssy.Rows[e.RowIndex].Cells["colSTDRATEperHour"].Value = Convert.ToDecimal(answer);
                    }
                }
                lblTotalSTDRateHour.Text = CalculateTotal(mgridListAssy, "colSTDRATEperHour").ToString();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }

        }

        private void mgridListPI_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 18)
                {
                    lblTotalDepn.Text = CalculateTotal(mgridListPI, "colDepnMold").ToString();
                }
                else if (e.ColumnIndex == 19)
                {
                    lblTotalOPTime.Text = CalculateTotal(mgridListPI, "colOperatingTime").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }

        private void mtcItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSetup();
        }
    }
}
