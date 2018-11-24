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
        SectionBAL sectbal;
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
        tbl_000_SECTION sect;
        tbl_000_H_PART com;

        tbl_000_H_ITEM item;
        tbl_000_H_ITEM_PART item_com;
        tbl_000_H_ITEM_TABULATION item_pi;
        tbl_000_H_ITEM_TABULATION_VP item_vp;
        tbl_000_H_ITEM_TABULATION_ASSY item_assy;
        tbl_000_H_ITEM_MPT item_mpt;
        tbl_000_H_ITEM_FDC item_fdc;
        tbl_000_H_CATEGORY cat;

        List<tbl_000_H_ITEM_PART> item_comlist;
        List<tbl_000_H_ITEM_TABULATION> item_pilist;
        List<tbl_000_H_ITEM_TABULATION_VP> item_vplist;
        List<tbl_000_H_ITEM_TABULATION_ASSY> item_assylist;
        List<tbl_000_H_ITEM_MPT> item_mptlist;
        List<tbl_000_H_ITEM_FDC> item_fdclist;

        public List<tbl_000_H_PART> comlist { get; set; }
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
                switch (MyState)
                {
                    case FormState.Add:
                        LockFields(false);
                        LockColumn(false);
                        HideButton(false);
                        PanelSetup();
                        strheader += " - New";
                        mtcItem.SelectedIndex = 0;
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        AssignRecord(false, true);
                        LockFields(false);
                        LockColumn(false);
                        HideButton(true);
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
                            mgridListFDC.Columns["colType"].ReadOnly = true;
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
            LoadGridPI();
            LoadGridVP();
            LoadGridAssy();
            LoadGridMPT();
            LoadGridCL();
            lblTotalDepn.Text = CalculateTotal(mgridListPI, "colDepnMold").ToString();
            lblTotalOPTime.Text = CalculateTotal(mgridListPI, "colOperatingTime").ToString();
            lblTotalSTDRateHour.Text = CalculateTotal(mgridListAssy, "colSTDRATEperHour").ToString();
            lblTotalAmount.Text = CalculateTotal(mgridListCL, "colAmount").ToString();


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
            mgridListFDC.AllowUserToAddRows = !IsLock;
        }
        private void HideButton(Boolean IsHidden)
        {
            mbtnAddCL.Visible = !IsHidden;
            mbtnRemoveCL.Visible = !IsHidden;
            mbtnAddAssy.Visible = !IsHidden;
            mbtnRemoveAssy.Visible = !IsHidden;
            mbtnAddVP.Visible = !IsHidden;
            mbtnRemoveVP.Visible = !IsHidden;
            mbtnAddPI.Visible = !IsHidden;
            mbtnRemovePI.Visible = !IsHidden;
            mbtnAddMPT.Visible = !IsHidden;
            mbtnRemoveMPT.Visible = !IsHidden;
            mbtnRemoveMPT.Visible = !IsHidden;
            if (MyState == FormState.Edit || MyState == FormState.View)
            {
                //Adjust Grids
                mgridListCL.Location = mbtnAddCL.Location;
                mgridListMPT.Location = mbtnAddMPT.Location;
            }
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

        private void AssignCom()
        {
            item_comlist = new List<tbl_000_H_ITEM_PART>();
            for (int i = 0; i < mgridListCL.Rows.Count; i++)
            {
                item_com = item_combal.GetByID(Convert.ToInt64(mgridListCL.Rows[i].Cells["colDocIDCL"].Value));
                if (item_com == null)
                {
                    item.Type = Convert.ToInt16(ItemComposition.Components);
                    item_com = new tbl_000_H_ITEM_PART();
                    item_com.YEARUSED = UserSettings.LogInYear;
                    item_com.ItemNo = mtxtItemNo.Text;
                    item_com.PartNo = mgridListCL.Rows[i].Cells["colPartNoCL"].Value.ToString();
                    item_com.IsCopied = false;
                    item_com.CopyDate = DateTime.Now;
                    item_com.ImportDate = DateTime.Now;
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
        }
        private void AssignPI()
        {
            for (int i = 0; i < mgridListPI.RowCount; i++)
            {
                item_pi = item_pibal.GetByID(Convert.ToInt64(mgridListPI.Rows[i].Cells["colDocIDPI"].Value));
                if (item_pi == null)
                {
                    item.Type = Convert.ToInt16(ItemComposition.PlasticInjection);
                    item_pi = new tbl_000_H_ITEM_TABULATION();
                    item_pi.YEARUSED = UserSettings.LogInYear;
                    item_pi.ItemNo = mtxtItemNo.Text;
                    item_pi.PartNo = mgridListPI.Rows[i].Cells["colMoldNo"].Value.ToString();
                    item_pi.IsCopied = false;
                    item_pi.CopyDate = DateTime.Now;
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

                item_pi.Cavity = mgridListPI.Rows[i].Cells["colCavity"].Value.ToString();
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
        }
        private void AssignVP()
        {
            for (int i = 0; i < mgridListVP.RowCount; i++)
            {
                item_vp = item_vpbal.GetByID(Convert.ToInt64(mgridListVP.Rows[i].Cells["colDocIDVP"].Value));
                if (item_vp == null)
                {
                    if (mgridListPI.RowCount > 0)
                    {
                        item.Type = Convert.ToInt16(ItemComposition.PlasticInjection_VacuumPlating);
                    }
                    else
                    {
                        item.Type = Convert.ToInt16(ItemComposition.VacuumPlating);
                    }
                    item_vp = new tbl_000_H_ITEM_TABULATION_VP();
                    item_vp.YEARUSED = UserSettings.LogInYear;
                    item_vp.ItemNo = mtxtItemNo.Text;
                    item_vp.PartNo = mgridListVP.Rows[i].Cells["colPartNoVP"].Value.ToString();
                    item_vp.CreatedDate = DateTime.Now;
                    item_vp.CreatedBy = UserSettings.Username;
                    item_vp.IsCopied = false;
                    item_vp.CopyDate = DateTime.Now;
                }
                item_vp.PartName = mgridListVP.Rows[i].Cells["colPartNameVP"].Value.ToString();
                item_vp.SourceData = mgridListVP.Rows[i].Cells["colSourceData"].Value.ToString();
                item_vp.ActualTimePerUnit = Convert.ToDecimal(mgridListVP.Rows[i].Cells["colATperUnit"].Value);
                //Temporary
                item_vp.VP_Operation = mgridListVP.Rows[i].Cells["colHC"].Value.ToString();
                item_vp.TotalQty = Convert.ToDecimal(mgridListVP.Rows[i].Cells["colQty"].Value);
                item_vp.TotalTime = 0;
                //
                item_vplist.Add(item_vp);
            }
            if (item_vplist.Count > 0)
            {
                item.itemVP = item_vplist;
            }
        }
        private void AssignAssy()
        {
            for (int i = 0; i < mgridListAssy.Rows.Count; i++)
            {
                item_assy = item_assybal.GetByID(Convert.ToInt64(mgridListAssy.Rows[i].Cells["colDocIDAssy"].Value));
                if (item_assy == null)
                {
                    if (mgridListPI.RowCount > 0 && mgridListVP.RowCount <= 0)
                    {
                        item.Type = Convert.ToInt16(ItemComposition.PlasticInjection_Assembly);
                    }
                    else if (mgridListVP.RowCount > 0 && mgridListPI.RowCount <= 0)
                    {
                        item.Type = Convert.ToInt32(ItemComposition.VacuumPlating_Assembly);
                    }
                    else if (mgridListPI.RowCount > 0 && mgridListVP.RowCount > 0)
                    {
                        item.Type = Convert.ToInt16(ItemComposition.AllTabulation);
                    }
                    else
                    {
                        item.Type = Convert.ToInt16(ItemComposition.Assembly);
                    }
                    item_assy = new tbl_000_H_ITEM_TABULATION_ASSY();
                    item_assy.YEARUSED = UserSettings.LogInYear;
                    item_assy.ItemNo = mtxtItemNo.Text;
                    item_assy.PartNo = mgridListAssy.Rows[i].Cells["colPartNoAssy"].Value.ToString();
                    item_assy.CreatedDate = DateTime.Now;
                    item_assy.CreatedBy = UserSettings.Username;
                    item_assy.IsCopied = false;
                    item_assy.CopyDate = DateTime.Now;
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
        }
        private void AssignMPT()
        {
            for (int i = 0; i < mgridListMPT.Rows.Count; i++)
            {
                item_mpt = item_mptbal.GetByID(Convert.ToInt64(mgridListMPT.Rows[i].Cells["colDocIDMPT"].Value.ToString()));
                if (item_mpt == null)
                {
                    item.Type = Convert.ToInt16(ItemComposition.ManufacturingProcessTIME);
                    item_mpt = new tbl_000_H_ITEM_MPT();
                    item_mpt.YEARUSED = UserSettings.LogInYear;
                    item_mpt.ItemNo = mtxtItemNo.Text;
                    item_mpt.SectionCode = mgridListMPT.Rows[i].Cells["colSectionCode"].Value.ToString();
                    item_mpt.CreatedDate = DateTime.Now;
                    item_mpt.CreatedBy = UserSettings.Username;
                    item_mpt.IsCopied = false;
                    item_mpt.CopyDate = DateTime.Now;
                }
                item_mpt.SectionName = mgridListMPT.Rows[i].Cells["colSectionName"].Value.ToString();
                item_mpt.ProductionTime = Convert.ToDecimal(mgridListMPT.Rows[i].Cells["colProductionTime"].Value);
                item_mptlist.Add(item_mpt);
            }
            if (item_mptlist.Count > 0)
            {
                item.itemMPT = item_mptlist;
            }
        }
        private void AssignFDC()
        {
            for (int i = 0; i < mgridListFDC.RowCount; i++)
            {
                if (mgridListFDC.Rows[i].IsNewRow) continue;
                item_fdc = item_fdcbal.GetByID(UserSettings.LogInYear, mtxtItemNo.Text, mgridListFDC.Rows[i].Cells["colType"].Value.ToString());
                if (item_fdc == null)
                {
                    item.Type = Convert.ToInt16(ItemComposition.FilmDepreciationCost);
                    item_fdc = new tbl_000_H_ITEM_FDC();
                    item_fdc.YEARUSED = UserSettings.LogInYear;
                    item_fdc.ItemNo = mtxtItemNo.Text;
                    item_fdc.DepnType = mgridListFDC.Rows[i].Cells["colType"].Value.ToString();
                    item_fdc.CreatedDate = DateTime.Now;
                    item_fdc.CreatedBy = UserSettings.Username;
                    item_fdc.IsCopied = false;
                    item_fdc.CopyDate = DateTime.Now;
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

        //End Assigning Subs
        private void AssignRecord(Boolean IsSave, Boolean IsNewItem)
        {
            try
            {
                if (IsSave)
                {
                    item = itembal.GetByID(UserSettings.LogInYear, mtxtItemNo.Text);
                    if (item == null)
                    {
                        item = new tbl_000_H_ITEM();
                        item.YEARUSED = UserSettings.LogInYear;
                        item.ItemNo = mtxtItemNo.Text;
                        item.CreatedDate = DateTime.Now;
                        item.CreatedBy = UserSettings.Username;
                        item.LockedDate = DateTime.Now;
                        item.IsCopied = false;
                        item.CopyDate = DateTime.Now;
                        item.ImportDate = DateTime.Now;
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
                    if (mtcItem.SelectedTab == mtpCompositionList)
                    {
                        //Compositition List
                        if (mgridListCL.RowCount > 0)
                        {
                            AssignCom();
                        }
                    }
                    else if (mtcItem.SelectedTab == mtpTabulationData)
                    {
                        //Tabulation Data
                        //PI
                        if (mgridListPI.RowCount > 0)
                        {
                            AssignPI();
                        }
                        //VP
                        if (mgridListVP.RowCount > 0)
                        {
                            AssignVP();
                        }
                        //Assy
                        if (mgridListAssy.RowCount > 0)
                        {
                            AssignAssy();
                        }
                    }
                    else if (mtcItem.SelectedTab == mtpManufacturingPT)
                    {
                        //Manufacturing Process Time
                        if (mgridListMPT.RowCount > 0)
                        {
                            AssignMPT();
                        }
                    }
                    else if (mtcItem.SelectedTab == mtpDepreciationCost)
                    {
                        //Film Depreciation Cost
                        if (mgridListFDC.RowCount > 1)
                        {
                            AssignFDC();
                        }
                    }
                    else
                    {

                    }
                    if (item.Type == 0)
                    {
                        item.Type = Convert.ToInt16(ItemComposition._NULL);
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

                        var item_comdata = item_combal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_PART> comlist = new BindingList<tbl_000_H_ITEM_PART>(item_comdata);
                        if (comlist.Count > 0)
                        {
                            mgridListCL.DataSource = comlist;
                            mtcItem.SelectedTab = mtpCompositionList;
                        }

                        var item_pidata = item_pibal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_TABULATION> pilist = new BindingList<tbl_000_H_ITEM_TABULATION>(item_pidata);

                        var item_vpdata = item_vpbal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_TABULATION_VP> vplist = new BindingList<tbl_000_H_ITEM_TABULATION_VP>(item_vpdata);

                        var item_assydata = item_assybal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_TABULATION_ASSY> assylist = new BindingList<tbl_000_H_ITEM_TABULATION_ASSY>(item_assydata);
                        mgridListAssy.DataSource = assylist;

                        if (pilist.Count > 0)
                        {
                            mgridListPI.DataSource = pilist;
                        }
                        if (vplist.Count > 0)
                        {
                            mgridListVP.DataSource = vplist;
                        }
                        if (assylist.Count > 0)
                        {
                            mgridListAssy.DataSource = assylist;
                        }

                        if (pilist.Count > 0
                            || vplist.Count > 0
                            || assylist.Count > 0)
                        {
                            mtcItem.SelectedTab = mtpTabulationData;
                        }
                        var item_mptdata = item_mptbal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_MPT> mptlist = new BindingList<tbl_000_H_ITEM_MPT>(item_mptdata);

                        if (mptlist.Count > 0)
                        {
                            mgridListMPT.DataSource = mptlist;
                            mtcItem.SelectedTab = mtpManufacturingPT;
                        }

                        var item_fdcdata = item_fdcbal.GetByNo(subsyearused, itemno).ToList();
                        BindingList<tbl_000_H_ITEM_FDC> fdclist = new BindingList<tbl_000_H_ITEM_FDC>(item_fdcdata);

                        if (fdclist.Count > 0)
                        {
                            mgridListFDC.DataSource = fdclist;
                            mtcItem.SelectedTab = mtpDepreciationCost;
                        }
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
                    AssignRecord(true, true);
                    switch (MyState)
                    {
                        case FormState.Add:
                            msg = "Saving";
                            if (itembal.Save(item))
                            {
                                isSuccess = true;
                            }
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
            List<tbl_000_H_PART> comlist = new List<tbl_000_H_PART>();
            comlist = combal.GetByNo(yearused, partnoCL).ToList();
            foreach (var item in comlist)
            {
                var index = mgridListCL.Rows.Add();
                mgridListCL.Rows[index].Cells["colPartNoCL"].Value = item.PartNo;
                mgridListCL.Rows[index].Cells["colDescriptionCL"].Value = item.PartName;
            }

        }
        public void LoadGridPI()
        {
            List<tbl_000_H_PI> pilist = new List<tbl_000_H_PI>();
            pilist = pibal.GetByNo(yearused, moldno).ToList();
            foreach (var item in pilist)
            {
                var index = mgridListPI.Rows.Add();
                mgridListPI.Rows[index].Cells["colMoldNo"].Value = item.MoldNo;
                mgridListPI.Rows[index].Cells["colPartNamePI"].Value = item.MoldName;
                mgridListPI.Rows[index].Cells["colSPH"].Value = item.SPH;
                mgridListPI.Rows[index].Cells["colCavity"].Value = item.Cavity;
                mgridListPI.Rows[index].Cells["colPPH"].Value = item.PPH;
                mgridListPI.Rows[index].Cells["colOz"].Value = item.Oz;
                mgridListPI.Rows[index].Cells["colPurge"].Value = item.PurgePerG;
            }
        }
        public void LoadGridVP()
        {
            List<tbl_000_H_VP> vplist = new List<tbl_000_H_VP>();
            vplist = vpbal.GetByNo(yearused, partnoVP).ToList();
            foreach (var item in vplist)
            {
                var index = mgridListVP.Rows.Add();
                mgridListVP.Rows[index].Cells["colPartNoVP"].Value = item.PartNo;
                mgridListVP.Rows[index].Cells["colPartNameVP"].Value = item.PartName;
                mgridListVP.Rows[index].Cells["colSourceData"].Value = item.SourceData;
            }
        }
        public void LoadGridAssy()
        {
            List<tbl_000_H_ASSY> assylist = new List<tbl_000_H_ASSY>();
            assylist = assybal.GetByNo(yearused, partnoAssy).ToList();
            foreach (var item in assylist)
            {
                var index = mgridListAssy.Rows.Add();
                mgridListAssy.Rows[index].Cells["colPartNoAssy"].Value = item.PartNo;
                mgridListAssy.Rows[index].Cells["colPartNameAssy"].Value = item.PartName;
            }
        }
        public void LoadGridMPT()
        {
            List<tbl_000_SECTION> sectionlist = new List<tbl_000_SECTION>();
            sectionlist = sectbal.GetByNo(sectioncode).ToList();
            foreach (var item in sectionlist)
            {
                var index = mgridListMPT.Rows.Add();
                mgridListMPT.Rows[index].Cells["colSectionCode"].Value = item.SECTIONCODE;
                mgridListMPT.Rows[index].Cells["colSectionName"].Value = item.SECTIONDESC;
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
            sectbal = new SectionBAL();
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
            sect = new tbl_000_SECTION();
            com = new tbl_000_H_PART();
            item = new tbl_000_H_ITEM();
            item_com = new tbl_000_H_ITEM_PART();
            item_pi = new tbl_000_H_ITEM_TABULATION();
            item_vp = new tbl_000_H_ITEM_TABULATION_VP();
            item_assy = new tbl_000_H_ITEM_TABULATION_ASSY();
            item_mpt = new tbl_000_H_ITEM_MPT();
            item_fdc = new tbl_000_H_ITEM_FDC();
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
            AddRow("MPT", "List of Sections");
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

                item = itembal.GetAll().Where(w => w.ItemNo == selecteditemno && w.YEARUSED < UserSettings.LogInYear).FirstOrDefault();
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
