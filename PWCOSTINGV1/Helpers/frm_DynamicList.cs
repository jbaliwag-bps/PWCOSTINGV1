using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Install-Package FastMember -Version 1.3.0
using FastMember;

using MetroFramework.Forms;
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Helpers;
using PWCOSTING.BO._000;
using PWCOSTING.BAL;

namespace PWCOSTINGV1.Forms
{
    public partial class frm_DynamicList : MetroForm
    {
        public frmWIPCosting MyCaller_WIP { get; set; }
        public frm_Copier MyCaller_Copier { get; set; }
        public frmItem MyCaller { get; set; }
        public frmStandardCostingReport MyCaller_scr { get; set; }
        ComponentBAL combal;
        tbl_000_H_PART com;
        PlasticInjectionBAL pibal;
        tbl_000_H_PI pi;
        VacuumPlatingBAL vpbal;
        tbl_000_H_VP vp;
        AssymblyBAL assybal;
        tbl_000_H_ASSY assy;
        SectionBAL sectbal;
        tbl_000_SECTION sect;
        ItemBAL itembal;
        tbl_000_H_ITEM item;

        public Boolean IsPrevious = false;
        public int PreviousYear { get; set; }
        List<tbl_000_H_PART> comlist;
        public string KindOfList { get; set; }
        int yused = UserSettings.LogInYear;
        string colname = "";
        string no = "";

        private void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            try
            {
                switch (KindOfList)
                {
                    #region Materials/ Compo
                    case "CL":
                        var list_CL = combal.GetAll().Select(i => new
                        {
                            i.DocID,
                            i.YEARUSED,
                            Part_No = i.PartNo,
                            Name = i.PartName,
                            Whddd_Qty = i.WholeQty,
                            Whddd_Unit = i.WholeUnit,
                            Conddd_Qty = i.ConversionQty,
                            Conddd_Unit = i.ConversionUnit,
                            Whddd_Price = i.WholePrice,
                            Conddd_Price = i.ConversionPrice,
                            Prevddd_Price = i.PreviousPrice,
                            Locked = i.IsLocked,
                        }
                        ).OrderBy(m => m.DocID).Where(r => r.YEARUSED == UserSettings.LogInYear).ToList();
                        this.mgridList.DataSource = list_CL;
                        break;
                    #endregion
                    #region Plastic Injection
                    case "MT_PI":
                        var list_PI = pibal.GetAll().Select(i => new
                        {
                            i.DocID,
                            i.YEARUSED,
                            Mold_No = i.MoldNo,
                            Mold_Name = i.MoldName,
                            i.Oz,
                            Purge_Per_Gram = i.PurgePerG,
                            Shots_Per_Hour = i.SPH,
                            Cavity = i.Cavity,
                            Pieces_Per_Hour = i.PPH,
                        }).OrderBy(m => m.DocID).Where(r => r.YEARUSED == UserSettings.LogInYear).ToList();
                        mgridList.DataSource = list_PI;
                        break;
                      #endregion
                    #region Vacuum Plating
                    case "MT_VP":
                        var list_VP = vpbal.GetAll().Select(i => new
                        {
                            DocID = i.DocID,
                            YEARUSED = i.YEARUSED,
                            Part_No = i.PartNo,
                            Part_Name = i.PartName,
                            Source_Data = i.SourceData,
                        }).OrderBy(m => m.DocID).Where(r => r.YEARUSED == UserSettings.LogInYear).ToList();
                        mgridList.DataSource = list_VP;
                        break;
                    #endregion
                    #region Assymbly
                    case "MT_ASSY":
                        var list_ASSY = assybal.GetAll().Select(i => new
                        {
                            DocID = i.DocID,
                            YEARUSED = i.YEARUSED,
                            Part_No = i.PartNo,
                            Part_Name = i.PartName,
                            Rate_Per_Hour = i.RATEPERHOUR,
                        }).OrderBy(m => m.DocID).Where(r => r.YEARUSED == UserSettings.LogInYear).ToList();
                        mgridList.DataSource = list_ASSY;
                        break;
                    #endregion
                    #region MPT
                    case "MPT":
                        var list_SECT = sectbal.GetAll().Select(i => new
                        {
                            Code = i.SECTIONCODE,
                            Description = i.SECTIONDESC,
                            Active = i.IsActive,
                            ISCOSTING = i.ISCOSTING
                        }).Distinct().OrderBy(m => m.Code).ToList();
                        this.mgridList.DataSource = list_SECT;
                        break;
                    #endregion
                    #region Items
                    case "ITEM":
                        int yeartouse = UserSettings.LogInYear;
                        if (IsPrevious)
                        {
                            yeartouse = PreviousYear;
                        }
                        var list_ITEM = itembal.GetAll().Select(i => new
                        {
                            i.DocID,
                            a_YEARUSED = i.YEARUSED,
                            b_ItemNo = i.ItemNo,
                            c_Description = i.Description,
                            d_IsLocked = i.IsLocked
                        }).Where(w => w.a_YEARUSED == yeartouse).Distinct().OrderBy(m => m.c_Description).ToList();
                        DataTable itmTable = new DataTable();
                        using (var reader = ObjectReader.Create(list_ITEM))
                        {
                            itmTable.Load(reader);
                            mgridList.DataSource = itmTable;
                        }
                        break;
                    #endregion
                }
                ColumnManager();
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void ColumnManager()
        {
            foreach (DataGridViewColumn c in mgridList.Columns)
            {
                c.HeaderText = c.HeaderText.Replace("a_", " ");
                c.HeaderText = c.HeaderText.Replace("b_", " ");
                c.HeaderText = c.HeaderText.Replace("c_", " ");
                c.HeaderText = c.HeaderText.Replace("d_", " ");
                c.HeaderText = c.HeaderText.Replace("e_", " ");
                c.HeaderText = c.HeaderText.Replace("_", " ");
                c.HeaderText = c.HeaderText.Replace("ddd", ".");
            }
            //
            switch (KindOfList)
            {
                case "MT_PI":
                case "MT_VP":
                case "MT_ASSY":
                case "MPT":
                case "ITEM":
                    mgridList.Columns[1].Visible = false;
                    mgridList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
            }
        }
        public frm_DynamicList()
        {
            InitializeComponent();
            combal = new ComponentBAL();
            com = new tbl_000_H_PART();
            pibal = new PlasticInjectionBAL();
            pi = new tbl_000_H_PI();
            vpbal = new VacuumPlatingBAL();
            vp = new tbl_000_H_VP();
            assybal = new AssymblyBAL();
            assy = new tbl_000_H_ASSY();
            sectbal = new SectionBAL();
            sect = new tbl_000_SECTION();
            itembal = new ItemBAL();
            item = new tbl_000_H_ITEM();

            comlist = new List<tbl_000_H_PART>();
        }

        private void frm_DynamicList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        private void GridRefresh()
        {
            switch (KindOfList)
            {
                case "CL":
                    MyCaller.mgridListCL.Rows.Clear();
                    break;
                case "MT_PI":
                    MyCaller.mgridListPI.Rows.Clear();
                    break;
                case "MT_VP":
                    MyCaller.mgridListVP.Rows.Clear();
                    break;
                case "MT_ASSY":
                    MyCaller.mgridListAssy.Rows.Clear();
                    break;
                case "MPT":
                    MyCaller.mgridListMPT.Rows.Clear();
                    break;
            }
        }
        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            //GridRefresh();
            try
            {
                FormHelpers.CursorWait(true);
                Int32 selectedRowCount = mgridList.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    colname = this.mgridList.Columns[2].Name;
                    no = mgridList.SelectedRows[i].Cells[colname].Value.ToString();
                    if (MyCaller != null)
                    {
                        MyCaller.yearused = yused;
                    }
                    switch (KindOfList)
                    {
                        case "CL":
                            MyCaller.partnoCL = no;
                            MyCaller.LoadGridCL();
                            break;
                        case "MT_PI":
                            MyCaller.moldno = no;
                            MyCaller.LoadGridPI();
                            break;
                        case "MT_VP":
                            MyCaller.partnoVP = no;
                            MyCaller.LoadGridVP();
                            break;
                        case "MT_ASSY":
                            MyCaller.partnoAssy = no;
                            MyCaller.LoadGridAssy();
                            break;
                        case "MPT":
                            var scode = mgridList.SelectedRows[i].Cells[2].Value.ToString();
                            MyCaller.sectioncode = scode.ToString();
                            MyCaller.LoadGridMPT();
                            break;
                        case "ITEM":
                            var icode = mgridList.SelectedRows[i].Cells[2].Value.ToString();
                            var item = itembal.GetAll().Where(w => w.YEARUSED == yused && w.ItemNo == icode).FirstOrDefault();
                            if (MyCaller_Copier != null)
                            {
                                item = itembal.GetAll().Where(w => w.YEARUSED == PreviousYear && w.ItemNo == icode).FirstOrDefault();
                                MyCaller_Copier.mtxtItemNo.Text = item.ItemNo;
                            }
                            else if (MyCaller_scr != null)
                            {
                            MyCaller_scr.mtxtItemNo.Text = item.ItemNo;
                            MyCaller_scr.mtxtItemDesc.Text = item.Description;
                            }
                            else if(MyCaller_WIP != null)
                            {
                                MyCaller_WIP.mtxtItemNo.Text = item.ItemNo;
                                MyCaller_WIP.mtxtItemDesc.Text = item.Description;
                            }
                            break;
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
            this.Close();
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strtosearch = tstxtSearch.Text;
            try
            {
                switch (KindOfList)
                {
                    case "ITEM":
                        (mgridList.DataSource as DataTable).DefaultView.RowFilter = string.Format("b_ItemNo LIKE '{0}%' or c_Description LIKE '{0}%'", BPSolutionsTools.BPSUtilitiesV1.NZ(strtosearch, ""));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
    }
}
