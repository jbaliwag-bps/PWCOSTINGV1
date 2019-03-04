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
using PWCOSTING.BAL._000;
using PWCOSTINGV1.Classes;
using PWCOSTING.BO._000;

namespace PWCOSTINGV1.Forms
{
    public partial class frmUserGroupList : MetroForm
    {
        #region "properties and declarations"
        UserGroupBAL usergroupbal;
        #endregion
        #region "user-defined methods"
        private void Init_Form()
        {
            FormHelpers.FormatForm(this.Controls);
            RefreshGrid();
            mgridList.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        public void RefreshGrid()
        {
            try
            {
                var list = usergroupbal.GetAll().OrderBy(m => m.UserGroupDesc).ToList();
                DataTable usrgrpTable = new DataTable();
                using (var reader = ObjectReader.Create(list,
                    "GroupID",
                    "UserGroupCode",
                    "UserGroupDesc",
                    "IsActive"))
                {
                    usrgrpTable.Load(reader);
                    mgridList.DataSource = usrgrpTable;
                }
                Grid.ListCheck(mgridList, listTS);
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }

        private void DeleteEntry()
        {
            try
            {
                FormHelpers.CursorWait(true);
                var selgrp = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colUserGroupDesc"].Value;
                string selgrpcode = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colUserGroupCode"].Value.ToString();
                if (MessageHelpers.ShowQuestion("Do want to delete " + selgrp + " group?") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (usergroupbal.Delete(selgrpcode))
                    {
                        MessageHelpers.ShowInfo(selgrp + " group deleted successfully!");
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
        public void SearchGrid()
        {
            try
            {
                string strtosearch = toolStriptxtSearch.Text;
                try
                {
                    (mgridList.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserGroupCode LIKE '%{0}%' or UserGroupDesc LIKE '%{0}%'", BPSolutionsTools.BPSUtilitiesV1.NZ(strtosearch, ""));
                }
                catch (Exception ex)
                {
                    MessageHelpers.ShowError(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }
        private void ShowEntryForm(FormState Mystate)
        {
            try
            {
                FormHelpers.CursorWait(true);
                var frm = new frmUserGroup();
                switch (Mystate)
                {
                    case FormState.Add:
                    case FormState.Delete:
                        break;
                    case FormState.Edit:
                    case FormState.View:
                        var gcode = mgridList.Rows[mgridList.SelectedCells[0].RowIndex].Cells["colUserGroupCode"].Value.ToString();
                        frm.groupid = gcode;
                        break;
                }
                frm.MyState = Mystate;
                frm.MyCaller = this;
                FormHelpers.ShowForm(frm, (MetroForm)this.MdiParent);
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
        #endregion
        public frmUserGroupList()
        {
            InitializeComponent();
            usergroupbal = new UserGroupBAL();
            FormHelpers.FormatForm(this.Controls);
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
                            ShowEntryForm(FormState.Add);
                            break;
                        case "edit":
                            ShowEntryForm(FormState.Edit);
                            break;
                        case "delete":
                            DeleteEntry();
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

        private void frmUserGroupList_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchGrid();
        }

        private void mgridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEntryForm(FormState.View);
        }
    }
}
