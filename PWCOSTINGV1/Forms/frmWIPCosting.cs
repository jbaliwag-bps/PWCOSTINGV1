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
using PWCOSTING.BAL._000;
using PWCOSTING.BO._000;
using PWCOSTING.BAL._100;
using PWCOSTING.BO._100;
using BPSolutionsTools;
using FastMember;

namespace PWCOSTINGV1.Forms
{
    public partial class frmWIPCosting : MetroForm
    {

        ItemBAL itembal;
        ItemCompositionBAL itemcombal;
        tbl_000_H_ITEM item;
        tbl_000_H_ITEM_PART itemcom;
        CategoryBAL catbal;

        tbl_100_WIP wip;
        WIPBAL wipbal;
        WIPMaterialsBAL wipmatbal;
        List<tbl_100_WIP_Materials> wipmatlist;
        DataTable dt;

        ErrorProviderExtended err;

        public long recid { get; set; }
        public FormState MyState { get; set; }
        public frmWIPCostingList MyCaller { get; set; }
        public string itemno { get; set; }
        public string partcode { get; set; }

        public frmWIPCosting()
        {
            InitializeComponent();
            itembal = new ItemBAL();
            itemcombal = new ItemCompositionBAL();
            item = new tbl_000_H_ITEM();
            itemcom = new tbl_000_H_ITEM_PART();
            catbal = new CategoryBAL();

            wip = new tbl_100_WIP();
            wipbal = new WIPBAL();
            wipmatbal = new WIPMaterialsBAL();
            wipmatlist = new List<tbl_100_WIP_Materials>();
            dt = new DataTable();

            err = new ErrorProviderExtended();
        }
        private void GetComponents()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var itemno = BPSUtilitiesV1.NZ(mtxtItemNo.Text, "").ToString();
                var partscode = BPSUtilitiesV1.NZ(mtxtPartCode.Text, "").ToString();
                ListHelper.FillMetroCombo(mcboCatCode, catbal.GetAll().Select(i => new { i.CATCODE, i.CATDESC }).
                    Where(w => w.CATCODE == "BULK").Distinct().ToList(), "CATCODE", "CATCODE");
                var catcode = BPSUtilitiesV1.NZ(mcboCatCode.SelectedValue, "").ToString();
                item = itembal.GetWithCat(UserSettings.LogInYear, itemno, catcode);

                GetRefCompDetails();
                if (item != null && item.itemCom.Count > 0)
                {
                    if (partscode != "")
                    {
                        itemcom = item.itemCom.Where(w => w.PartNo == partscode).OrderBy(o => o.ItemAddress).FirstOrDefault();
                        if (itemcom != null)
                        {
                            var sourceTable = item.itemCom.Where(w => w.ItemAddress.StartsWith(itemcom.ItemAddress) && w.ItemAddress != itemcom.ItemAddress).ToList();
                            using (var reader = ObjectReader.Create(sourceTable,
                                "DocID",
                                "MatCode",
                                "MatDescription",
                                "ItemUsage",
                                "UnitPrice",
                                "Amount",
                                "Address"))
                            {
                                dt.Load(reader);
                                mgridMatList.DataSource = dt;
                            }
                        }
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
        private void GetRefCompDetails()
        {
            var comp = itemcombal.GetByNo(UserSettings.LogInYear, mtxtItemNo.Text).FirstOrDefault();
            if (comp != null)
            {
                mtxtPartName.Text = comp.PartType;
            }
        }
        private void AssignMain()
        {
            wip = wipbal.GetByRecID(recid);
            if (wip == null)
            {
                wip = new tbl_100_WIP();
                wip.YEARUSED = UserSettings.LogInYear;
                wip.ItemNo = mtxtItemNo.Text;
                wip.PartCode = mtxtPartCode.Text;
                GetRefCompDetails();
                wip.PartName = mtxtPartName.Text;
                wip.CatCode = BPSUtilitiesV1.NZ(mcboCatCode.SelectedValue, "").ToString();
                wip.MaterialLabor = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtSubTotal.Text, 0));
                wip.ProfitRate = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtProfitRate.Text, 0));
                wip.SellingPrice = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtSellingPrice.Text, 0));
                wip.ForexRate = Convert.ToDecimal(BPSUtilitiesV1.NZ(mtxtForex.Text, 0));
                wip.CreatedBy = UserSettings.Username;
                wip.UpdatedBy = UserSettings.Username;
                wip.Remarks = mtxtRemarks.Text;
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
                MessageHelpers.ShowError(ex.Message);
                return false;
            }
        }
        private void AssignRecord()
        {
            try
            {
                AssignMain();
                for (int i = 0; i < mgridMatList.RowCount; i++)
                {
                    if (mgridMatList.Rows[i].IsNewRow) continue;
                    var wmrecid = Convert.ToInt64(BPSUtilitiesV1.NZ(mgridMatList.Rows[i].Cells["colDocID"].Value.ToString(), 0));
                    var wipmat = wipmatbal.GetByRecID(wmrecid);
                    if (wipmat == null)
                    {
                        wipmat = new tbl_100_WIP_Materials();
                        wipmat.state = "add";
                    }
                    else
                    {
                        wipmat.state = "update";
                    }
                    wipmat.YEARUSED = UserSettings.LogInYear;
                    wipmat.ItemNo = mtxtItemNo.Text;
                    wipmat.PartNo = mtxtPartCode.Text;
                    wipmat.MatCode = mgridMatList.Rows[i].Cells["colMoldNo"].Value.ToString();
                    wipmat.MatDescroption = mgridMatList.Rows[i].Cells["colMatDescription"].Value.ToString();
                    wipmat.Usage = Convert.ToDecimal(mgridMatList.Rows[i].Cells["colUsage"].Value);
                    wipmat.UnitType = mgridMatList.Rows[i].Cells["colUnitType"].Value.ToString();
                    wipmat.UnitPrice = Convert.ToDecimal(mgridMatList.Rows[i].Cells["colUnitPrice"].Value);
                    wipmat.Amount = Convert.ToDecimal(mgridMatList.Rows[i].Cells["colAmount"].Value);
                    wipmat.Address = mgridMatList.Rows[i].Cells["colAddress"].Value.ToString();
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
                if (IsValid())
                {
                    var isSuccess = false;
                    string msg = "";
                    AssignRecord();
                    switch (MyState)
                    {
                        case FormState.Add:
                            msg = "Saving";
                            if (wipbal.Save(wip))
                            {
                                isSuccess = true;
                            }
                            break;
                        case FormState.Edit:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void mbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
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
                        break;
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

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            GetComponents();
        }

        private void frmWIPCosting_Load(object sender, EventArgs e)
        {
            GetComponents();
        }
    }
}
