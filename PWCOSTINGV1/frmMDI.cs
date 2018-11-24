using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using PWCOSTINGV1.Classes;
using PWCOSTINGV1.Forms;

namespace PWCOSTINGV1
{
    public partial class frmMDI : MetroForm
    {
        private void Init_Form()
        {
            this.Text = AppSettings.CompanyProfile.SHORTNAME.ToUpper() + " " + AppSettings.AppName + " v" + AppSettings.AppVersion;
            //initialize MDIForms.MyParent
            MDIForms.MyParentForm = this;
            //change the background
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    if (this.Theme == MetroFramework.MetroThemeStyle.Light)
                    {
                        client.BackColor = Color.Black;
                    }
                    else
                    {
                        client.BackColor = Color.White;
                    }
                    
                    var intwidth = client.Width-10;
                    var intheight = client.Height-10;
                    ListWindowSettings.WindowSize = new Size(intwidth-100, intheight-100);
                    MenuWindowSettings.WindowSize = new Size(intwidth, intheight);
                    // 4#
                    break;
                }
            }
        }

        private void ShowMenus()
        {
            try
            {
                //clear menustrip items
                mnsMain.Items.Clear();
                //Add DEFAULT USER MENUS
                //add signoff menu
                var sigofftsmi = new ToolStripMenuItem("SIGN OFF", ListHelper.FormatImage((Image)ListHelper.GetResources("signofficon"), 40, 40));
                FormatToolStripMenuItem(sigofftsmi, new PWCOSTING.BO.Default.tbl_MENU() { MenuID = 2000, MenuName = "Sign Off", IsLeftAlign = false });
                sigofftsmi.Click += new EventHandler(this.SignOff);
                mnsMain.Items.Add(sigofftsmi);
                //add change password menu
                var changepasstsmi = new ToolStripMenuItem("CHANGE PASSWORD", ListHelper.FormatImage((Image)ListHelper.GetResources("changepasswordicon"), 40, 40));
                FormatToolStripMenuItem(changepasstsmi, new PWCOSTING.BO.Default.tbl_MENU() { MenuID = 3000, MenuName = "Change Password", IsLeftAlign = false });
                changepasstsmi.Click += new EventHandler(this.ChangePassword);
                mnsMain.Items.Add(changepasstsmi);

                //iterate the main menus with parentmenuid == 0
                foreach(var mainmenu in UserSettings.CurrentUser.MenuList.Where(m=>m.ParentMenuID == 0 && m.IsActive == true).OrderBy(n=>n.MenuOrder).ToList()){
                    var newtsmi = new ToolStripMenuItem(mainmenu.MenuName, ListHelper.FormatImage((Image)ListHelper.GetResources(mainmenu.ImageName), 40, 40));
                   FormatToolStripMenuItem(newtsmi, mainmenu);
                    //add sub menus
                   AddMenus(newtsmi, mainmenu.MenuID);
                   mnsMain.Items.Add(newtsmi);
                }
                //Add DEFAULT MENUS
                //add window menu
                var windowtsmi = new ToolStripMenuItem("WINDOWS", ListHelper.FormatImage((Image)ListHelper.GetResources("metrouiicon"),40,40));
                FormatToolStripMenuItem(windowtsmi, new PWCOSTING.BO.Default.tbl_MENU() { MenuID = 1000, MenuName = "Windows", IsLeftAlign = false });
                var clrwindowtsmi = new ToolStripMenuItem("CLEAR WINDOWS", imglstMain.Images["metrouiicon"]);
                FormatToolStripMenuItem(clrwindowtsmi, new PWCOSTING.BO.Default.tbl_MENU() { MenuID = 1001, MenuName = "Clear Windows", IsLeftAlign = true }, true);
                windowtsmi.DropDownItems.Add(clrwindowtsmi);
                windowtsmi.DropDownItems.Add("-");                
                mnsMain.Items.Add(windowtsmi);
                mnsMain.MdiWindowListItem = windowtsmi;


            }catch(Exception ex)
            {
                throw ex;
            }
        }
        //format toolstripmenuitem with preferred setup.
        private void FormatToolStripMenuItem(ToolStripMenuItem tsmi, PWCOSTING.BO.Default.tbl_MENU mainmenu, Boolean isSub = false)
        {
            try
            {
                tsmi.Tag = mainmenu.MenuID;
                if (mainmenu.IsLeftAlign == false)
                {
                    tsmi.Alignment = ToolStripItemAlignment.Right;
                }
                tsmi.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                tsmi.ToolTipText = mainmenu.MenuName;
                if (isSub)
                {
                    tsmi.TextImageRelation = TextImageRelation.ImageBeforeText;
                    tsmi.Click += new EventHandler(FormHelpers.OpenMenu);
                }
                else
                {
                    tsmi.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    tsmi.ImageScaling = ToolStripItemImageScaling.None;
                    tsmi.Size = new System.Drawing.Size(40, 40);
                    tsmi.TextImageRelation = TextImageRelation.ImageAboveText;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //recursive methods to add submenus.
        private void AddMenus(ToolStripMenuItem tsmi, int intparentId)
        {
            try
            {
                var usrmenus =UserSettings.CurrentUser.MenuList.Where(m=>m.ParentMenuID == intparentId && m.IsActive == true).OrderBy(n=>n.MenuOrder).ToList();
                if (usrmenus != null)
                {
                    foreach (var mainmenu in usrmenus)
                    {
                        if (UserSettings.CurrentUser.UserGroup.MenuList.Where(n => n.MenuID == mainmenu.MenuID).FirstOrDefault() != null)
                        {
                            var newtsmi = new ToolStripMenuItem(mainmenu.MenuName, imglstMain.Images[mainmenu.ImageName]);
                            FormatToolStripMenuItem(newtsmi, mainmenu, true);
                            AddMenus(newtsmi, mainmenu.MenuID);
                            tsmi.DropDownItems.Add(newtsmi);
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SignOff(object sender, EventArgs e)
        {
            if (MessageHelpers.ShowQuestion("Logging Off?") == System.Windows.Forms.DialogResult.Yes)
            {
                UserSettings.IsAuthenticated = false;
                FormHelpers.CloseForms(this, true);
                this.AuthenticateUser();
            }       
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            frmUserPassword frm = new frmUserPassword();
            frm.MyCaller = this;
            FormHelpers.ShowForm(frm);    
        }

        public void AuthenticateUser()
        {
            if (UserSettings.IsAuthenticated == true)
            {
                Init_Form();
                ShowMenus();
                ShowMenuList();
            }
            else
            {
                this.Hide();
                var frm = new frmLogin();
                frm.MyCaller = this;
                FormHelpers.ShowForm(frm);            
            }
        }

        public void CloseAllChildForm()
        {
            try
            {
                foreach (var frm in this.MdiChildren)
                {
                    if (!frm.Name.ToLower().Equals("frmMenus"))
                    {
                        frm.Close();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowError(ex.Message);
            }
        }

        private void ShowMenuList()
        {
            var frm = new frmMenus();
            frm.Tag = "menu";
            frm.MyCaller = this;
            FormHelpers.ShowForm(frm, this);
        }

        public frmMDI()
        {
            InitializeComponent();
            this.msmMain.Theme = MyFormStyles.MyStyle;
            this.msmMain.Style = MyFormStyles.MyColor;
            this.StyleManager = msmMain;
            FormHelpers.FormatForm(this.Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                AuthenticateUser();               
        }

        private void companyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCompanyProfile();
            FormHelpers.ShowForm(frm,this);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUserList();
            FormHelpers.ShowForm(frm, this);
        }

        private void userGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUserGroupList();
            FormHelpers.ShowForm(frm, this);
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new section form
            var frm = new frmSectionList();
            FormHelpers.ShowForm(frm, this);
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCategoryList();
            FormHelpers.ShowForm(frm, this);
        }

        private void fXAndSPRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmFXandSPList();
            FormHelpers.ShowForm(frm, this);
        }

        private void componentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmComponentList();
            FormHelpers.ShowForm(frm, this);
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmItemList();
            FormHelpers.ShowForm(frm, this);
        }

    }
}
