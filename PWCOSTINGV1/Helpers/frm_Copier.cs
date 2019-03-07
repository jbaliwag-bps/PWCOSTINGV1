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
    public partial class frm_Copier : MetroForm
    {
        public frmItemList MyCaller_itm { get; set; }
        ItemBAL itmbal;
        tbl_000_H_ITEM itm;
        int selyear;
        string msg = "";
        string msgval_success = "Copying Successful!";
        private void FilltxtAutoComplete()
        {
            selyear = Convert.ToInt32(BPSUtilitiesV1.NZ(mcboYear.SelectedValue, 0));
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var source = itmbal.GetItemNos(selyear);
            foreach (string i in source)
            {
                collection.Add(i);
            }
            mtxtItemNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtxtItemNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mtxtItemNo.AutoCompleteCustomSource = collection;
        }
        private void mtxtItemNo_TextChanged(object sender, EventArgs e)
        {
            string selecteditemno = BPSUtilitiesV1.NZ(mtxtItemNo.Text, "").ToString();
            itm = itmbal.GetByID(selyear, selecteditemno);
            if (itm != null)
            {
                mtxtItemDesc.Text = BPSUtilitiesV1.NZ(itm.Description, "").ToString();
            }
        }
        private void RefreshCBox()
        {
            try
            {
              ListHelper.FillMetroCombo(mcboYear, itmbal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        public frm_Copier()
        {
            InitializeComponent();
            itmbal = new ItemBAL();
            itm = new tbl_000_H_ITEM();
        }
        private void frm_Copier_Load(object sender, EventArgs e)
        {
            RefreshCBox();
            FilltxtAutoComplete();
            metroLabel2.Text = "NOTE: If Overwrite Existing is checked it will overwrite all data \r\n that are in the previous and also in the current logged in year.";
            mtxtCurLogYear.Text = UserSettings.LogInYear.ToString();
            mtxtCurLogYear.Height = 30;
            metroRadioButton2.Checked = true;
            if (mcboYear.Items.Count < 1)
            {
                mbtnOk.Enabled = false;
            }
        }
        private void forRDO(RadioButton rdbtn)
        {
            if (rdbtn.Checked)
            {
                if (rdbtn.Name == "metroRadioButton1")
                {
                    mtxtItemNo.Enabled = false;
                    mtxtItemDesc.Enabled = false;
                    mbtnViewList.Enabled = false;
                }
                else
                {
                    mtxtItemNo.Enabled = true;
                    mtxtItemDesc.Enabled = true;
                    mbtnViewList.Enabled = true;
                }
            }
        }
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked)
            {
                if (MessageHelpers.ShowQuestion("This operation is crucial, do you want to continue?") == System.Windows.Forms.DialogResult.Yes)
                {
                    forRDO(metroRadioButton1);
                }
                else
                {
                    metroRadioButton1.Checked = false;
                    forRDO(metroRadioButton2);
                    metroRadioButton2.Checked = true;
                }
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            forRDO(metroRadioButton2);
        }
        private void CopyByItem(Boolean IsOverwrite)
        {

            if (itmbal.CopyByItem(selyear, UserSettings.LogInYear, mtxtItemNo.Text, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_itm.Init_Form();
            }
        }
        private void CopyByYear(Boolean IsOverwrite)
        {

            if (itmbal.CopyItemByYear(selyear, UserSettings.LogInYear, UserSettings.Username, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_itm.Init_Form();
            }
        }
        private void CopyItem()
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (!mcbOverWrite.Checked)
                {
                    msg = "This process will copy previous items from the selected year to the current logged in year. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                        if (metroRadioButton2.Checked)
                        {
                            CopyByItem(false);
                        }
                        else
                        {
                            CopyByYear(false);
                        }
                        this.Close();
                    }
                }
                else
                {
                    msg = "This process will remove the existing items and replace it. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                        if (metroRadioButton2.Checked)
                        {
                            CopyByItem(true);
                        }
                        else
                        {
                            CopyByYear(true);
                        }
                        this.Close();
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
        private void mbtnOk_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnViewList_Click(object sender, EventArgs e)
        {
            var frm = new frm_DynamicList();
            frm.KindOfList = "ITEM";
            frm.Text = "List of Items in Year " +selyear.ToString();
            frm.IsPrevious = true;
            frm.PreviousYear = selyear;
            frm.MyCaller_Copier = this;
            FormHelpers.ShowDialog(frm);
        }
    }
}
