using System;
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
    public partial class _frmWIPCosting : MetroForm
    {
        ItemCompositionBAL itmcombal;
        ItemBAL itmbal;
        tbl_000_H_ITEM itm;

        WIPMatBAL wipmatbal;
        WIPLabPIBAL wippibal;
        WIPLabBaggingBAL wipbagbal;
        #region Panels and Table Layouts
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

            //Labor
            var sourcelist_labPI = wippibal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear);
            BindingList<tbl_100_WIP_COSTING_LABOR_PI> blist_labPI = new BindingList<tbl_100_WIP_COSTING_LABOR_PI>(sourcelist_labPI);
            mgridLabPI.DataSource = blist_labPI;

            var sourcelist_labBagg = wipbagbal.GetByYear(mtxtItemNo.Text, UserSettings.LogInYear).Select(s => new
            {
                s.RecID,
                aProcessName = s.ProcessName,
                bHC = s.HC,
                cQTY = s.QTY,
                s.T_Time
            }).ToList();

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
        public _frmWIPCosting()
        {
            InitializeComponent();
            itmcombal = new ItemCompositionBAL();
            itmbal = new ItemBAL();
            itm = new tbl_000_H_ITEM();

            wipmatbal = new WIPMatBAL();
            wippibal = new WIPLabPIBAL();
            wipbagbal = new WIPLabBaggingBAL();
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
            PanelSetup();
            RefreshGrid();
            State(FormState.View);
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
            var txtboxes = Controls.OfType<MetroTextBox>().Where(w => w.Name.StartsWith("_")).ToList();
            foreach (MetroTextBox mtxt in txtboxes)
            {
                mtxt.ReadOnly = IsLocked;
            }
        }
        private void AssignRecord()
        {
            try
            {

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
        private void State(FormState MyState)
        {
            //Using enum "FormState" an Operations
            switch (MyState)
            {
                case FormState.Add:
                    break;

                case FormState.Edit:
                    ControlsManager(false);
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    break;

                case FormState.Delete:
                    break;

                case FormState.View:
                    var tsitems = listTS.Items.OfType<ToolStripButton>().ToList();
                    foreach (ToolStripButton item in tsitems)
                    {
                        item.Enabled = true;
                    }
                    ControlsManager(true);
                    mbtnSave.Enabled = true;
                    break;

                case FormState.Refresh:
                    State(FormState.View);
                    break;

                case FormState.Print:
                    break;

                case FormState.Preview:
                    break;

                case FormState.ViewAll:
                    break;
            }
        }
        private void listTS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var strtag = e.ClickedItem.Tag;
            if (strtag != null)
            {
                if (strtag.ToString() != "")
                {
                    switch (strtag.ToString().ToLower())
                    {
                        case "new":
                            State(FormState.Add);
                            break;
                        case "edit":
                            State(FormState.Edit);
                            break;
                        case "delete":
                            State(FormState.Delete);
                            break;
                        case "refresh":
                            State(FormState.Refresh);
                            break;
                        case "print":
                            State(FormState.Print);
                            break;
                        case "preview":
                            State(FormState.Preview);
                            break;
                        case "all records":
                            State(FormState.ViewAll);
                            break;
                    }

                }

            }
        }
        private void mtcforGrids_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSetup();
        }

        private void mtxtItemNo_TextChanged(object sender, EventArgs e)
        {
            ItemDesc();
        }
        private void _AssignMat()
        {
            var unboundedlist = ((IEnumerable<tbl_100_WIP_COSTING_MATERIALS>)mgridMaterials.DataSource).Cast<tbl_100_WIP_COSTING_MATERIALS>().ToList();
            if (wipmatbal.Update(unboundedlist))
            {
                MessageHelpers.ShowInfo("Success!");
            }
            //var unboundedlist = ((IEnumerable<tbl_100_WIP_COSTING_LABOR_PI>)mgridLabPI.DataSource).Cast<tbl_100_WIP_COSTING_LABOR_PI>().ToList();
            //if (wippibal.Save(unboundedlist))
            //{
            //    MessageHelpers.ShowInfo("Success!");
            //}
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            _AssignMat();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void mbtnViewList_Click(object sender, EventArgs e)
        {
            //var frm = new frm_DynamicList();
            //frm.KindOfList = "ITEM";
            //frm.Text = "List of Items in Year " + UserSettings.LogInYear.ToString();
            //frm.MyCaller_WIP = this;
            //FormHelpers.ShowDialog(frm);
        }
    }
}
