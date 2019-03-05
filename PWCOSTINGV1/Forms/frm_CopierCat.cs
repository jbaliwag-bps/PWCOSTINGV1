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
    public partial class frm_CopierCat : MetroForm
    {
        public frmCategoryList MyCaller_cat { get; set; }
        CategoryBAL catbal;
        tbl_000_H_CATEGORY cat;
        int selyear;
        string msg = "";
        string msgval_success = "Copying Successful!";
        private void FilltxtAutoComplete()
        {
            selyear = Convert.ToInt32(BPSUtilitiesV1.NZ(mcboYear.SelectedValue, 0));
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var source = catbal.GetCatCodes(selyear);
            foreach (string i in source)
            {
                collection.Add(i);
            }
            mtxtCatCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtxtCatCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mtxtCatCode.AutoCompleteCustomSource = collection;
        }
        private void mtxtCatCode_TextChanged(object sender, EventArgs e)
        {
            string selectedcatcode = BPSUtilitiesV1.NZ(mtxtCatCode.Text, "").ToString();
            cat = catbal.GetByID(selectedcatcode, selyear);
            if (cat != null)
            {
                mtxtCatDesc.Text = BPSUtilitiesV1.NZ(cat.CATDESC, "").ToString();
            }
        }
        private void RefreshCBox()
        {
            try
            {
                ListHelper.FillMetroCombo(mcboYear, catbal.GetAll().Select(i => new { i.YEARUSED }).Distinct().OrderByDescending(m => m.YEARUSED).Where(i => i.YEARUSED != UserSettings.LogInYear && i.YEARUSED < UserSettings.LogInYear).ToList(), "YEARUSED", "YEARUSED");
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        public frm_CopierCat()
        {
            InitializeComponent();
            catbal = new CategoryBAL();
            cat = new tbl_000_H_CATEGORY();
        }

        private void frm_CopierCat_Load(object sender, EventArgs e)
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
                    mtxtCatCode.Enabled = false;
                    mtxtCatDesc.Enabled = false;
                    mbtnViewList.Enabled = false;
                }
                else
                {
                    mtxtCatCode.Enabled = true;
                    mtxtCatDesc.Enabled = true;
                    mbtnViewList.Enabled = true;
                }
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            forRDO(metroRadioButton2);
        }
        private void CopyByCat(Boolean IsOverwrite)
        {
            if (catbal.CopyByCat(selyear, UserSettings.LogInYear, mtxtCatCode.Text, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
            }
        }
        private void CopyCatByYear(Boolean IsOverwrite)
        {
            if (catbal.CopyCatByYear(selyear, UserSettings.LogInYear, IsOverwrite))
            {
                MessageHelpers.ShowInfo(msgval_success);
                MyCaller_cat.Init_Form();
            }
        }
        private void CopyCategory()
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (!mcbOverWrite.Checked)
                {
                    msg = "This process will copy previous category from the selected year to the current logged in year. Do you want to continue?";
                    if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                    {
                        if (metroRadioButton2.Checked)
                        {
                            CopyByCat(false);
                            this.Close();
                        }
                        else
                        {
                            CopyCatByYear(false);
                            this.Close();
                        }
                    }
                    else
                    {
                        msg = "This process will remove the existing categories and replace it. Do you want to continue?";
                        if (MessageHelpers.ShowQuestion(msg) == DialogResult.Yes)
                        {
                            if (metroRadioButton2.Checked)
                            {
                                CopyByCat(true);
                                this.Close();
                            }
                            else
                            {
                                CopyCatByYear(true);
                                this.Close();
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
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnViewList_Click(object sender, EventArgs e)
        {
            var frm = new frm_DynamicList();
            frm.KindOfList = "CAT";
            frm.Text = "List of Categories in Year " + selyear.ToString();
            frm.IsPrevious = true;
            frm.PreviousYear = selyear;
            frm.MyCaller_CopierCat = this;
            FormHelpers.ShowDialog(frm);
        }

        private void mbtnOk_Click(object sender, EventArgs e)
        {
            CopyCategory();
        }
    }
}
