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
using PWCOSTING.BAL.Default;
using PWCOSTING.BO.Default;
using PWCOSTING.BO._000;

namespace PWCOSTINGV1.Forms
{
    public partial class frmSearchListMenu : MetroForm
    {
        #region "properties and declarations"
        MenuBAL menubal;
        public List<tbl_000_USERGROUP_MENUS> AddedList { get; set; }
        public frmUserGroup UserGroupCaller { get; set; }
        #endregion
        #region "user-defined methods"
        private void LoadList()
        {
            try
            {
                var list = menubal.GetSearchList();
                var filteredlist = FilterList(list);
                mgMenuList.DataSource = new List<tbl_MENU_Search>();
                mgMenuList.DataSource = filteredlist;
            }catch(Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        //remove already added menus. 
        private List<tbl_MENU_Search> FilterList(List<tbl_MENU_Search> lst)
        {
            try
            {
                if (AddedList != null)
                {
                    if (AddedList.Count > 0)
                    {
                        tbl_MENU_Search existmenu;
                        foreach (tbl_000_USERGROUP_MENUS menu in AddedList)
                        {
                            existmenu = lst.SingleOrDefault(m => m.MenuID == menu.MenuID);
                            lst.Remove(existmenu);
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public frmSearchListMenu()
        {
            InitializeComponent();
            menubal = new MenuBAL();
        }

        private void frmSearchListMenu_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mchkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in mgMenuList.Rows)
            {
                drow.Cells["colCheckBox"].Value = mchkSelectAll.Checked;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelpers.CursorWait(true);
                if (mgMenuList.Rows.Count > 0)
                {
                    var lst = new List<tbl_000_USERGROUP_MENUS>();
                    foreach(DataGridViewRow drow in mgMenuList.Rows)
                    {
                        Boolean blnSelected = (Boolean)drow.Cells["colCheckBox"].Value;
                        if (blnSelected == true)
                        {
                            lst.Add(new tbl_000_USERGROUP_MENUS() { MenuID = (int)drow.Cells["colMenuID"].Value, MenuName = drow.Cells["colMenuName"].Value.ToString(), 
                                                                                                            CanAdd = true, CanEdit =true, CanView = true, CanDelete = true, CanPreview = true, CanPrint=true});
                        }
                    }
                    if (lst.Count > 0)
                    {
                        UserGroupCaller.AddRights(lst);
                        this.Close();
                    }
                    else
                    {
                        MessageHelpers.ShowWarning("Please select at least 1 record!");
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
    }
}
