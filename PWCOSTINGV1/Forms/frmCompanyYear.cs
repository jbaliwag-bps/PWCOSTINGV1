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
using PWCOSTING.BO.Default;
using PWCOSTING.BAL.Default;

namespace PWCOSTINGV1.Forms
{
    public partial class frmCompanyYear : MetroForm
    {
        public frmCompanyProfile MyCaller { get; set; }
        YearBAL yearbal;
        tbl_YEAR year;
        ErrorProviderExtended err;
        private void AssignRecord()
        {
            try
            {
                year.RecYear = Convert.ToInt32(mtxtYear.Text);
                year.IsLocked = false;
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
                    AssignRecord();
                    if (yearbal.Save(year))
                    {
                        MessageHelpers.ShowInfo("Saving Successful!");
                        MyCaller.RefreshGrid();
                        this.Close();
                    }
                    else
                        MessageHelpers.ShowWarning("Saving Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
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
        public frmCompanyYear()
        {
            InitializeComponent();
            yearbal = new YearBAL();
            year = new tbl_YEAR();
            err = new ErrorProviderExtended();

        }
        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            if (MessageHelpers.ShowQuestion("Are you sure you want to add this record?") == DialogResult.Yes)
                SaveRecord();
        }

        private void frmCompanyYear_Load(object sender, EventArgs e)
        {

        }

        private void mtxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly._KeyPress_NoPoint(sender, e);
        }
    }
}

