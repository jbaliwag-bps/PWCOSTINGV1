﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using MetroFramework.Forms;
using MetroFramework.Controls;
using PWCOSTINGV1.Classes;
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL._100;
using PWCOSTING.BO._100;
using BPSolutionsTools;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPCosting : MetroForm
    {
        public frmWIPCostingList MyCaller { get; set; }
        public FormState MyState { get; set; }
        public long recid { get; set; }

        ItemCompositionBAL itmcombal;
        ItemTabulationPIBAL itmpibal;

        ItemBAL itmbal;
        tbl_000_H_ITEM itm;
        WIPCostingBAL wipcostbal;
        tbl_100_WIP_COST wipcost;
        WIPMatBAL wipmatbal;
        WIPLabPIBAL wippibal;
        WIPLabBaggingBAL wipbagbal;
        WIPLabAssyBAL wipassybal;
        WIPLabPlatingBAL wipplatbal;
        WIPCCodeBAL wipccbal;

        List<tbl_100_WIP_COSTING_MATERIALS> wipmatlist;
        List<tbl_100_WIP_COSTING_LABOR_PI> wiplabpilist;
        List<tbl_100_WIP_COSTING_LABOR_BAGG> wiplabbagglist;
        List<tbl_100_WIP_COSTING_LABOR_ASSY> wiplabassylist;
        List<tbl_100_WIP_COSTING_LABOR_PLATED> wiplabplatedlist;
        List<tbl_100_WIP_COSTING_CC> wipccodelist;

        private void Init_Form()
        {
            try
            {
                ReColorColumn(mgridMaterials, "colUnitType");
                ReColorColumn(mgridColorCode, "colUnitTypeCC");
                switch (MyState)
                {
                    case FormState.Add:
                        //ClearDgvRow();
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        if(MyState == FormState.Edit)
                            ControlsManager(false);
                        else
                        {
                            ControlsManager(true);
                            mbtnSave.Enabled = false;
                        }
                        //RefreshGrid();
                        break;
                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Panels and Table Layouts
        private void ReColorColumn(DataGridView dgv, string colname)
        {
            //ReColor Specific Column
            Color darkpurple = System.Drawing.ColorTranslator.FromHtml("#7C4199");
            Color selectedpurple = System.Drawing.ColorTranslator.FromHtml("#AA83CB");
            dgv.Columns[colname].HeaderCell.Style.BackColor = darkpurple;
            dgv.Columns[colname].DefaultCellStyle.SelectionBackColor = selectedpurple;
            //

        }
        private void PanelSetup()
        {
            var bluetheme = ColorTranslator.FromHtml("#00AEDB");
            TabPage page = mtcforGrids.SelectedTab;

            //Panels and their Labels
            var panels = page.Controls.OfType<Panel>();
            foreach (var p in panels)
            {
                p.BackColor = bluetheme;
                var plabels = p.Controls.OfType<Label>();
                foreach (var plbl in plabels)
                {
                    plbl.ForeColor = Color.White;
                    plbl.BackColor = Color.Transparent;
                }
            }

            //Table Layouts and their Labels
            var tlpanels = page.Controls.OfType<TableLayoutPanel>();
            foreach (var tlp in tlpanels)
            {
                tlp.BackColor = bluetheme;
                var tlplabels = tlp.Controls.OfType<Label>();
                foreach (var tlplbl in tlplabels)
                {
                    tlplbl.ForeColor = Color.White;
                }
            }

            //Override TableLayout(bottom)
            _tableLayoutPanel3.BackColor = Color.White;
            var tlp3labels = _tableLayoutPanel3.Controls.OfType<Label>();
            foreach (var l in tlp3labels)
            {
                l.ForeColor = Color.Black;
            }
        }
        private void RefreshGrid()
        {
            //Materials
            var sourcelist_mat = wipmatbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_MATERIALS> blist_mat = new BindingList<tbl_100_WIP_COSTING_MATERIALS>(sourcelist_mat);
            mgridMaterials.DataSource = blist_mat;

            //Labor Tables
            var sourcelist_labPI = wippibal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_LABOR_PI> blist_labPI = new BindingList<tbl_100_WIP_COSTING_LABOR_PI>(sourcelist_labPI);
            mgridLabPI.DataSource = blist_labPI;

            var sourcelist_labBagg = wipbagbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_LABOR_BAGG> blist_labBagg = new BindingList<tbl_100_WIP_COSTING_LABOR_BAGG>(sourcelist_labBagg);
            mgridLabBagg.DataSource = blist_labBagg;

            var sourcelist_labassy = wipassybal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_LABOR_ASSY> blistlab_assy = new BindingList<tbl_100_WIP_COSTING_LABOR_ASSY>(sourcelist_labassy);
            mgridLabAssy.DataSource = blistlab_assy;

            var sourcelist_labplat = wipplatbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_LABOR_PLATED> blistlab_plat = new BindingList<tbl_100_WIP_COSTING_LABOR_PLATED>(sourcelist_labplat);
            mgridLabPlated.DataSource = blistlab_plat;
            //

            //Color Codes
            var sourcelist_CC = wipccbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_CC> blist_ccode = new BindingList<tbl_100_WIP_COSTING_CC>(sourcelist_CC);
            mgridColorCode.DataSource = blist_ccode;
            //
        }
        #endregion
        private void ItemDesc()
        {
            string selecteditemno = BPSUtilitiesV1.NZ(mtxtItemNo.Text, "").ToString();
            itm = itmbal.GetByID(UserSettings.LogInYear, selecteditemno);
            if (itm != null)
            {
                mtxtItemDesc.Text = BPSUtilitiesV1.NZ(itm.Description, "").ToString();
            }
            else
                mtxtItemDesc.Text = "";
        }
        private void TableLayoutPainter(object sender, TableLayoutCellPaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.CellBounds;

            using (Pen pen = new Pen(Color.White, 0 /*1px width despite of page scale, dpi, page units*/ ))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                // define border style
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                // decrease border rectangle height/width by pen's width for last row/column cell
                if (e.Row == (tableLayoutPanel1.RowCount - 1))
                {
                    r.Height -= 1;
                }

                if (e.Column == (tableLayoutPanel1.ColumnCount - 1))
                {
                    r.Width -= 1;
                }

                // use graphics mehtods to draw cell's border
                e.Graphics.DrawRectangle(pen, r);
            }
        }
        public frmWIPCosting()
        {
            InitializeComponent();
            itmcombal = new ItemCompositionBAL();
            itmpibal = new ItemTabulationPIBAL();
            itmbal = new ItemBAL();
            itm = new tbl_000_H_ITEM();

            wipcostbal = new WIPCostingBAL();
            wipcost = new tbl_100_WIP_COST();
            wipmatbal = new WIPMatBAL();
            wippibal = new WIPLabPIBAL();
            wipbagbal = new WIPLabBaggingBAL();
            wipassybal = new WIPLabAssyBAL();
            wipplatbal = new WIPLabPlatingBAL();
            wipccbal = new WIPCCodeBAL();

            wipmatlist = new List<tbl_100_WIP_COSTING_MATERIALS>();
            wiplabpilist = new List<tbl_100_WIP_COSTING_LABOR_PI>();
            wiplabassylist = new List<tbl_100_WIP_COSTING_LABOR_ASSY>();
            wiplabbagglist = new List<tbl_100_WIP_COSTING_LABOR_BAGG>();
            wiplabassylist = new List<tbl_100_WIP_COSTING_LABOR_ASSY>();
            wiplabplatedlist = new List<tbl_100_WIP_COSTING_LABOR_PLATED>();
            wipccodelist = new List<tbl_100_WIP_COSTING_CC>();
        }

        private void FilltxtAutoComplete()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var source = itmcombal.GetItemNos(UserSettings.LogInYear).Intersect(itmbal.GetItemNos(UserSettings.LogInYear));
            foreach (string i in source)
            {
                collection.Add(i);
            }
            mtxtItemNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtxtItemNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mtxtItemNo.AutoCompleteCustomSource = collection;
        }
        private void frmWIPCosting_Load(object sender, EventArgs e)
        {
            Init_Form();
            PanelSetup();
            FilltxtAutoComplete();
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            TableLayoutPainter(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void ControlsManager(Boolean IsLocked)
        {
            //loop that makes the textbox readonly except for item and desc
            var txtboxes = Controls.OfType<MetroTextBox>().Where(w => w.Name.StartsWith("_")).ToList();
            foreach (MetroTextBox mtxt in txtboxes)
            {
                mtxt.ReadOnly = IsLocked;
            }

            //loop that disable all datagridview
            TabPage page = mtcforGrids.SelectedTab;
            var dgvs = page.Controls.OfType<DataGridView>();
            foreach (DataGridView dgv in dgvs)
            {
                dgv.ReadOnly = IsLocked;
            }
        }
        private void ClearDgvRow()
        {
            //loop that clears the dgv rows for adding
            TabPage page = mtcforGrids.SelectedTab;
            var dgvs = page.Controls.OfType<DataGridView>();
            foreach (DataGridView dgv in dgvs)
            {
                dgv.Rows.Clear();
            }
        }
        private void mtxtItemNo_TextChanged(object sender, EventArgs e)
        {
            ItemDesc();
            var partnolist = wipmatbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            DataTable pnoTable = new DataTable();
            using (var reader = ObjectReader.Create(partnolist,
                "PartNo"))
            {
                pnoTable.Load(reader);
                mgridPartNos.DataSource = pnoTable;
            }
        }
        private void CheckMmainWIPItem()
        {
            wipcost = wipcostbal.GetByID(recid);
            if (wipcost == null)
            {
                wipcost = new tbl_100_WIP_COST();
                wipcost.YEARUSED = UserSettings.LogInYear;
                wipcost.ItemNo = mtxtItemNo.Text;
                //For Testing
                wipcost.PartNo = _mtxtProcess1.Text;
                wipcost.PartName = _mtxtPartDesc.Text;
                //
                wipcost.MatLaborCost = Convert.ToDecimal(mtxtSTCost.Text);
                wipcost.ProfitRate = Convert.ToDecimal(mtxtAPRate.Text);
                wipcost.SellingPrice = Convert.ToDecimal(mtxtTSelPrice.Text);
                wipcost.Forex = Convert.ToDecimal(mtxtForex.Text);
                //For Testing
                wipcost.Ref_Add = "TEST";

            }
        }
        private void AssignRecord(Boolean IsSave)
        {
            try
            {
                if (IsSave)
                {
                    //Materials
                    for (int i = 0; i < mgridMaterials.RowCount; i++)
                    {
                        if (mgridMaterials.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridMaterials.Rows[i].Cells["colRecIDMat"].Value, 0));
                        var wipmat = wipmatbal.GetByID(recid);
                        if (wipmat == null)
                        {
                            wipmat = new tbl_100_WIP_COSTING_MATERIALS();
                            wipmat.YEARUSED = UserSettings.LogInYear;
                            wipmat.ItemNo = mtxtItemNo.Text;
                            wipmat.PartNo = _mtxtProcess1.Text;
                        }
                        wipmat.MatCode = mgridMaterials.Rows[i].Cells["colMatCode"].Value.ToString();
                        wipmat.MatDescription = mgridMaterials.Rows[i].Cells["colMatDescription"].Value.ToString();
                        wipmat.Usage = Convert.ToInt32(mgridMaterials.Rows[i].Cells["colUsage"].Value);
                        wipmat.UnitType = BPSUtilitiesV1.NZ(mgridMaterials.Rows[i].Cells["colUnitType"].Value, "").ToString(); ;
                        wipmat.UnitPrice = Convert.ToInt32(mgridMaterials.Rows[i].Cells["colUnitPrice"].Value);
                        wipmat.Amount = Convert.ToInt32(mgridMaterials.Rows[i].Cells["colTotal"].Value);
                        //For the sake of Testing
                        wipmat.Address = "TEST";
                        wipmat.KartCode = "TEST";
                        //
                        wipmatlist.Add(wipmat);
                    }

                    //Labor
                    //PI
                    for (int i = 0; i < mgridLabPI.RowCount; i++)
                    {
                        if (mgridLabPI.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridLabPI.Rows[i].Cells["colRecIDPI"].Value, 0));
                        var wippi = wippibal.GetByID(recid);
                        if (wippi == null)
                        {
                            wippi = new tbl_100_WIP_COSTING_LABOR_PI();
                            wippi.YEARUSED = UserSettings.LogInYear;
                            wippi.ItemNo = mtxtItemNo.Text;
                            wippi.Partno = _mtxtProcess1.Text;
                        }
                        wippi.MoldNo = mgridLabPI.Rows[i].Cells["colMoldNoPI"].Value.ToString();
                        wippi.SPH = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colSPH"].Value);
                        wippi.Cavity = Convert.ToInt32(mgridLabPI.Rows[i].Cells["colCavity"].Value);
                        wippi.Usage = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colUsagePI"].Value);
                        wippi.ComputationSPH = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colCompSPH"].Value);
                        wippi.ComputationCavity = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colCompCavity"].Value);
                        wippi.TUsage = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colCompTUsage"].Value);
                        wippi.Allowance = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colCompAllowance"].Value);
                        wippi.TotalTime = Convert.ToDecimal(mgridLabPI.Rows[i].Cells["colCompTotalTime"].Value);
                        //For the sake of Testing
                        wippi.PartNoMem = "";
                        wippi.TmStmp = DateTime.Now;
                        //
                        wiplabpilist.Add(wippi);
                    }
                    //Bagging
                    for (int i = 0; i < mgridLabBagg.RowCount; i++)
                    {
                        if (mgridLabBagg.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridLabBagg.Rows[i].Cells["colRecIDBagg"].Value, 0));
                        var wipbagg = wipbagbal.GetByID(recid);
                        if (wipbagg == null)
                        {
                            wipbagg = new tbl_100_WIP_COSTING_LABOR_BAGG();
                            wipbagg.YEARUSED = UserSettings.LogInYear;
                            wipbagg.ItemNo = mtxtItemNo.Text;
                            wipbagg.PartNo = _mtxtProcess1.Text;
                        }
                        wipbagg.ProcessName = mgridLabBagg.Rows[i].Cells["colProcessNameBagg"].Value.ToString();
                        wipbagg.HC = Convert.ToDecimal(mgridLabBagg.Rows[i].Cells["colHCBagg"].Value);
                        wipbagg.QTY = Convert.ToDecimal(mgridLabBagg.Rows[i].Cells["colQtyBagg"].Value);
                        wipbagg.T_Time = Convert.ToDecimal(mgridLabBagg.Rows[i].Cells["colTTimeBagg"].Value);
                        wiplabbagglist.Add(wipbagg);
                    }
                    //Assembled
                    for (int i = 0; i < mgridLabAssy.RowCount; i++)
                    {
                        if (mgridLabAssy.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridLabAssy.Rows[i].Cells["colRecIDAssy"].Value, 0));
                        var wipassy = wipassybal.GetByID(recid);
                        if (wipassy == null)
                        {
                            wipassy = new tbl_100_WIP_COSTING_LABOR_ASSY();
                            wipassy.YEARUSED = UserSettings.LogInYear;
                            wipassy.ItemNo = mtxtItemNo.Text;
                            wipassy.PartNo = _mtxtProcess1.Text;
                        }
                        wipassy.ProcessName = mgridLabAssy.Rows[i].Cells["colProcessNameAssy"].Value.ToString();
                        wipassy.HC = Convert.ToDecimal(mgridLabAssy.Rows[i].Cells["colHCAssy"].Value);
                        wipassy.QTY = Convert.ToDecimal(mgridLabAssy.Rows[i].Cells["colQtyAssy"].Value);
                        wipassy.T_Time = Convert.ToDecimal(mgridLabAssy.Rows[i].Cells["colTTimeAssy"].Value);
                        wiplabassylist.Add(wipassy);
                    }
                    //Plated Parts
                    for (int i = 0; i < mgridLabPlated.RowCount; i++)
                    {
                        if (mgridLabPlated.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridLabPlated.Rows[i].Cells["colRecIDPP"].Value, 0));
                        var wipplated = wipplatbal.GetByID(recid);
                        if (wipplated == null)
                        {
                            wipplated = new tbl_100_WIP_COSTING_LABOR_PLATED();
                            wipplated.YEARUSED = UserSettings.LogInYear;
                            wipplated.ItemNo = mtxtItemNo.Text;
                            wipplated.PartNo = _mtxtProcess1.Text;
                        }
                        wipplated.ProcessName = mgridLabPlated.Rows[i].Cells["colProcessNamePP"].Value.ToString();
                        wipplated.PlatingTime = Convert.ToDecimal(mgridLabPlated.Rows[i].Cells["colPlatingTime"].Value);
                        wiplabplatedlist.Add(wipplated);
                    }

                    //Color Codes
                    for (int i = 0; i < mgridColorCode.RowCount; i++)
                    {
                        if (mgridColorCode.Rows[i].IsNewRow) continue;
                        var recid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridColorCode.Rows[i].Cells["colRecIDCC"].Value, 0));
                        var wipccodes = wipccbal.GetByID(recid);
                        if (wipccodes == null)
                        {
                            wipccodes = new tbl_100_WIP_COSTING_CC();
                            wipccodes.YEARUSED = UserSettings.LogInYear;
                            wipccodes.ItemNo = mtxtItemNo.Text;
                            wipccodes.PartNo = _mtxtProcess3.Text;
                        }
                        wipccodes.MatCode = mgridColorCode.Rows[i].Cells["colMatCodeCC"].Value.ToString();
                        wipccodes.MatDescription = mgridColorCode.Rows[i].Cells["colMatDescriptionCC"].Value.ToString();
                        wipccodes.Usage = Convert.ToDecimal(mgridColorCode.Rows[i].Cells["colUsageCC"].Value);
                        wipccodes.UnitType = BPSUtilitiesV1.NZ(mgridColorCode.Rows[i].Cells["colUnitTypeCC"].Value, "").ToString();
                        wipccodes.UnitPrice = Convert.ToDecimal(mgridColorCode.Rows[i].Cells["colUnitPriceCC"].Value);
                        wipccodes.Total = Convert.ToDecimal(mgridColorCode.Rows[i].Cells["colTotalCC"].Value);
                        //For the sake of Testing
                        wipccodes.Address = "TEST";
                        wipccodes.KartCode = "TEST";
                        wipccodes.Ref_Add = "TEST";
                        wipccodelist.Add(wipccodes);
                    }
                }
                else
                {

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
                var isSuccess = false;
                var msg = "";
                AssignRecord(true);
                switch (MyState)
                {
                    case FormState.Add:
                        msg = "Saving";
                        if (wipmatbal.Save(wipmatlist))
                            if (wippibal.Save(wiplabpilist))
                                if (wipbagbal.Save(wiplabbagglist))
                                    if (wipassybal.Save(wiplabassylist))
                                        if (wipplatbal.Save(wiplabplatedlist))
                                            if (wipccbal.Save(wipccodelist))
                                                isSuccess = true;
                                           
                                       
                        break;
                    case FormState.Edit:
                        msg = "Updating";
                       if(wipmatbal.Update(wipmatlist)){
                           if (wippibal.Update(wiplabpilist))
                           {
                               if (wipbagbal.Update(wiplabbagglist))
                               {
                                   if (wipassybal.Update(wiplabassylist))
                                   {
                                       if (wipplatbal.Update(wiplabplatedlist))
                                       {
                                           if (wipccbal.Update(wipccodelist))
                                           {
                                               isSuccess = true;
                                           }
                                       }
                                   }
                               }
                           }
                       }
                        break;
                }
                if (isSuccess)
                {
                    MessageHelpers.ShowInfo(msg + " Successful!");
                    RefreshGrid();
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

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void mbtnViewList_Click(object sender, EventArgs e)
        {
            var frm = new frm_DynamicList();
            frm.KindOfList = "ITEM";
            frm.Text = "List of Items in Year " + UserSettings.LogInYear.ToString();
            frm.MyCaller_WIP = this;
            FormHelpers.ShowDialog(frm);
        }
        private void mtxtItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefreshGrid();
            }
        }

        private void mtcforGrids_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSetup();
            ReColorColumn(mgridMaterials, "colUnitType");
            ReColorColumn(mgridColorCode, "colUnitTypeCC");
        }
    }
}
