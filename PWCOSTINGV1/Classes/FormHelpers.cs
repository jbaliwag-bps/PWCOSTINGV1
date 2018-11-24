using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;


namespace PWCOSTINGV1.Classes
{
    public static class FormHelpers
    {
        public static void CursorWait(Boolean blnIsWait)
        {
            if (blnIsWait)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public static void FormatForm(Control.ControlCollection ctls)
        {
            foreach (var ctl in ctls)
            {
                if (ctl is MenuStrip)
                {
                    var myctl = (MenuStrip)ctl;
                    foreach(var itm in myctl.Items)
                    {
                        if(itm is ToolStripMenuItem){
                            var myitm = (ToolStripMenuItem)itm;
                            myitm.ForeColor = ChangeForeColor();
                        }
                    }
                }
                if(ctl is ToolStrip)
                {
                    var myctl = (ToolStrip)ctl;
                    foreach (var itm in myctl.Items)
                    {
                        if (itm is ToolStripButton)
                        {
                            var myitm = (ToolStripButton)itm;
                            myitm.ForeColor = ChangeForeColor();
                        }
                    }
                }
            }
        }

        private static Color ChangeForeColor()
        {
            if (MyFormStyles.MyStyle == MetroFramework.MetroThemeStyle.Dark)
            {
               return Color.WhiteSmoke;
            }
            else
            {
               return Color.Black;
            }
        }

        public static void ShowForm(MetroForm myfrm, MetroForm myparentfrm = null)
        {
            if (myparentfrm != null)
            {
                myfrm.MdiParent = myparentfrm;                
            }
            ShowForm(myfrm);
        }

        public static void CloseForms(MetroForm parentform, Boolean isLogOff)
        {
            try
            {
                var strname = "a";
                var isclose = true;
                foreach (var frm in parentform.MdiChildren)
                {
                    isclose = true;
                    strname = frm.Name;
                    if (!isLogOff)
                    {
                        if (strname == "frmMenus")
                        {
                            isclose = false;
                        }
                    }
                    if (isclose)
                    {
                        frm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ClearWindows()
        {
            CloseForms(MDIForms.MyParentForm, false);
        }

        public static void OpenMenu(object sender, EventArgs e)
        {
            try
            {
                int intTag = 0; 
                Type t = sender.GetType();
                if (t.Equals(typeof(ToolStripMenuItem)))
                {
                    var objsender = (ToolStripMenuItem)sender;
                    intTag = (int)objsender.Tag;
                }
                else if (t.Equals(typeof(MetroTile)))
                {
                    var objsender = (MetroTile)sender;
                    intTag = (int)objsender.Tag;
                }

                if (UserSettings.CurrentUser.UserGroup.MenuList.Where(m => m.MenuID == intTag).FirstOrDefault() != null)
                {
                    var mainmenu = UserSettings.CurrentUser.MenuList.Where(n => n.MenuID == intTag).FirstOrDefault();
                    if (!ObjectFinder.isFormOpen(mainmenu.FormName))
                    {
                        var frm = ObjectFinder.CreateForm(mainmenu.FormName);
                        frm.Tag = mainmenu.MenuID;
                        FormHelpers.ShowForm(frm, MDIForms.MyParentForm);
                    }
                }
                else
                {
                    if (intTag == 1001)
                    {
                        //for clear windows
                        ClearWindows();
                    }
                    else
                    {
                        throw new Exception("Module doesn't exist!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageHelpers.ShowWarning(ex.Message);
            }
        }

        public static void ShowForm(MetroForm myfrm)
        {
            var mymsm = MyFormStyles.GetStyleManager(myfrm);
            //check tagging of the form specific size.
            if (myfrm.Tag != null)
            {
                switch (myfrm.Tag.ToString().ToLower())
                {
                    case "menu"://for the menu list for short cuts.
                        myfrm.Size = MenuWindowSettings.WindowSize;
                        if (MyFormStyles.MyStyle == MetroFramework.MetroThemeStyle.Light)
                        {
                            mymsm.Theme = MetroFramework.MetroThemeStyle.Dark;
                        }
                        else
                        {
                            mymsm.Theme = MetroFramework.MetroThemeStyle.Light;
                        }
                        break;
                    case "list"://for the menu list for short cuts.
                        myfrm.Size = ListWindowSettings.WindowSize;
                        break;
                    default:                        
                        break;
                }
            }
            myfrm.StyleManager = mymsm;
            myfrm.StartPosition = FormStartPosition.CenterScreen;
            myfrm.ShadowType = MetroFormShadowType.DropShadow;
            myfrm.BorderStyle = MetroFormBorderStyle.FixedSingle;
            myfrm.Show();
        }

        public static void ShowDialog(MetroForm myfrm)
        {
            myfrm.StyleManager = MyFormStyles.GetStyleManager(myfrm);
            myfrm.StartPosition = FormStartPosition.CenterScreen;
            myfrm.ShadowType = MetroFormShadowType.DropShadow;
            myfrm.BorderStyle = MetroFormBorderStyle.FixedSingle;
            myfrm.ShowDialog();
        }

        public static DialogResult GetShowDialog(MetroForm myfrm)
        {
            myfrm.StyleManager = MyFormStyles.GetStyleManager(myfrm);
            myfrm.StartPosition = FormStartPosition.CenterScreen;
            myfrm.ShadowType = MetroFormShadowType.DropShadow;
            myfrm.BorderStyle = MetroFormBorderStyle.FixedSingle;
            return myfrm.ShowDialog();
        }

        private static void ResizeForm(MetroForm myfrm)
        {
            if (myfrm.Tag != null)
            {
                if (myfrm.Tag.ToString() == "list")
                {
                    myfrm.Size = ListWindowSettings.WindowSize;
                }
            }
            
        }
    }

    public static class MessageHelpers
    {
        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInfo(string msg)
        {
            MessageBox.Show(msg, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowQuestion(string msg)
        {
           return MessageBox.Show(msg, "Just asking...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
