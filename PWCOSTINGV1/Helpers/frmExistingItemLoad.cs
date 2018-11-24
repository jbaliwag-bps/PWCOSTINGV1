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
    public partial class frmExistingItemLoad : MetroForm
    {
        public frmItem MyCaller { get; set; }
        public string itemno { get; set; }
        ItemBAL itmbal;
        List<tbl_000_H_ITEM> itmlist;
        int _yearused = 0;
        string _itemno = "";
        public Boolean isNoOtherActivity = true;
        public void RefreshGrid()
        {
            try
            {
                var list = itmbal.GetAll().Select(s => new {s.YEARUSED, s.ItemNo, Selection = "Load"}).Where(w => w.ItemNo == itemno).ToList();
                mgridList.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        public frmExistingItemLoad()
        {
            InitializeComponent();
            itmbal = new ItemBAL();
            itmlist = new List<tbl_000_H_ITEM>();
        }
        private void BeautifyGrid()
        {
            Color darkpurple = System.Drawing.ColorTranslator.FromHtml("#7C4199");
            Color selectedpurple = System.Drawing.ColorTranslator.FromHtml("#AA83CB");

            //Header
            mgridList.Columns["colchkSelection"].HeaderCell.Style.BackColor = darkpurple;
            //

            //Selection
            mgridList.Columns["colchkSelection"].DefaultCellStyle.SelectionBackColor = selectedpurple;
            //
            mgridList.Columns["colchkSelection"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void frmExistingItemLoad_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            BeautifyGrid();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            MyCaller._itemno = "";
            MyCaller._yearused = 0;
            MyCaller.LoadExistingItem();
        }

        private void mgridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in mgridList.SelectedRows)
                {
                    _yearused = Convert.ToInt32(row.Cells[0].Value);
                    _itemno = row.Cells[1].Value.ToString();
                }
                MyCaller._yearused = _yearused;
                MyCaller._itemno = _itemno;
                MyCaller.LoadExistingItem();
                isNoOtherActivity = false;
                this.Close();
            }
        }

        private void frmExistingItemLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isNoOtherActivity)
            {
                MyCaller.mtxtItemNo.Text = "";
                MyCaller.RefreshForm();
            }
        }
    }
}
