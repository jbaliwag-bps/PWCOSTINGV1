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
using PWCOSTINGV1.Classes;

namespace PWCOSTINGV1
{
    public partial class frmMenus : MetroForm
    {
        #region "properties and declarations"
        public frmMDI MyCaller { get; set; }
        #endregion

        private void ShowMenus()
        {
            try
            {
                //clear menustrip items
                this.flpMenu.Controls.Clear();
                //iterate the main menus with parentmenuid == 0
                foreach (var mainmenu in UserSettings.CurrentUser.MenuList.Where(m => m.IsShortCut == true).OrderBy(n => n.MenuID).OrderBy(o=>o.MenuOrder).ToList())
                {
                    if (UserSettings.CurrentUser.UserGroup.MenuList.Where(n => n.MenuID == mainmenu.MenuID).FirstOrDefault() != null)
                    {
                        //var newtsmi = new ToolStripMenuItem(mainmenu.MenuName, imglstMain.Images[mainmenu.ImageName]);
                        //FormatToolStripMenuItem(newtsmi, mainmenu);
                        var comptile = new MetroTile() { Text = mainmenu.ShortcutName, TileImageAlign=ContentAlignment.MiddleCenter, TextAlign=ContentAlignment.BottomCenter, UseTileImage=true , TileImage=ListHelper.FormatImage((Image)ListHelper.GetResources(mainmenu.ImageName),40,40), Size = MenuTileSize.SmallTileSize, Style = MyFormStyles.MyColor, Theme = MyFormStyles.MyStyle, Margin = new Padding(5, 5, 5, 5) };
                        comptile.Tag = mainmenu.MenuID;
                        comptile.Click += new EventHandler(FormHelpers.OpenMenu);
                        flpMenu.Controls.Add(comptile);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }         
        
        public void FillMenus()
        {
            //Company Profile
            var comptile = new MetroTile() { Text = "Company", Size = MenuTileSize.SmallTileSize, Style = MyFormStyles.MyColor, Theme = MyFormStyles.MyStyle , Margin = new Padding(5,5,5,5)};
            comptile.Click += new EventHandler(Menu_Click);
            this.flpMenu.Controls.Add(comptile);
            //Employee Profile
            var emptile = new MetroTile() { Text = "Employee", Size = MenuTileSize.MeduimTileSize, Style = MyFormStyles.MyColor, Theme = MyFormStyles.MyStyle, Margin = new Padding(5, 5, 5, 5) };
            emptile.Click += new EventHandler(Menu_Click);
            this.flpMenu.Controls.Add(emptile);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var myfrm = (MetroTile)sender;
            if (myfrm != null)
            {
                var stag = myfrm.Text.ToLower();
                switch (stag)
                {
                    case "company" :
                        var frm = new PWCOSTINGV1.Forms.frmCompanyProfile();
                        FormHelpers.ShowForm(frm, (MetroForm)this.MdiParent);
                        break;
                }
            }
        }
        public frmMenus()
        {
            InitializeComponent();    
        }
        private void Init_Form()
        {
            mlblUsername.Text = UserSettings.Username;
            mlblFullName.Text = UserSettings.CurrentUser.FullName;
            mlblUserGroup.Text = UserSettings.CurrentUser.UserGroupDesc;
            mlblLogInYear.Text = UserSettings.LogInYear.ToString();
            mlblCompName.Text = UserSettings.ComputerName;
            mlblCompIP.Text = UserSettings.ComputerIP;
            mlblServer.Text = UserSettings.ServerName;
            mlblDBName.Text = UserSettings.DatabaseName;
            if (UserSettings.CurrentUser.UserPhoto != null)
            {
                picUserPhoto.BackgroundImage = BPSolutionsTools.BPSUtilitiesV1.BytesToImage(UserSettings.CurrentUser.UserPhoto);
            }
        }

        private void frmMenus_Load(object sender, EventArgs e)
        {
            Init_Form();
            ShowMenus();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
                
        }
    }
}
