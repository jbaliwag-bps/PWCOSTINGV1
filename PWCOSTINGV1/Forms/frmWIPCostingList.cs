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
    public partial class frmWIPCostingList : MetroForm
    {
        WIPCostingBAL wipcostbal;
        public void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            try
            {
                var wipcostlist = wipcostbal.GetByYear(UserSettings.LogInYear);
                DataTable wipitemTable = new DataTable();
                using (var reader = ObjectReader.Create(wipcostlist,
                    "RecID",
                    "ItemNo",
                    "PartNo",
                    "MatLaborCost",
                    "ProfitRate",
                    "Forex",
                    "Ref_Add"
                    ))
                {
                    wipitemTable.Load(reader);
                    mgridList.DataSource = wipitemTable;
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        public frmWIPCostingList()
        {
            InitializeComponent();
            wipcostbal = new WIPCostingBAL();
        }
        private void ShowEntryForm(FormState MyState)
        {
            try
            {
                var frm = new frmWIPCosting();
                var ext = frm.Text;
                switch (MyState)
                {
                    case FormState.Add:
                        ext += " - New";
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var recid = Convert.ToInt64(mgridList.SelectedRows[0].Cells["colRecID"].Value);
                        frm.recid = recid;
                        if (MyState == FormState.Edit)
                            ext = " - Edit";
                        else
                            ext = " - View";
                        break;
                    case FormState.Delete:
                        Delete();
                        break;
                }
                frm.Text = ext;
                frm.MyState = MyState;
                frm.MyCaller = this;
                FormHelpers.ShowForm(frm, (MetroForm)this.MdiParent);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void Delete()
        {
            try
            {
                FormHelpers.CursorWait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FormHelpers.CursorWait(false);
            }
        }
        private void listTS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
              var strtag = e.ClickedItem.Tag;
              if (BPSolutionsTools.BPSUtilitiesV1.NZ(strtag, "").ToString() != "")
              {
                  switch (strtag.ToString().ToLower())
                  {
                      case "new":
                          ShowEntryForm(FormState.Add);
                          break;
                      case "edit":
                          ShowEntryForm(FormState.Edit);
                          break;
                      case "delete":
                         
                          break;
                      case "view":
                          ShowEntryForm(FormState.View);
                          break;
                      case "refresh":
                          RefreshGrid();
                          break;
                  }
              }
        }

    }
}
