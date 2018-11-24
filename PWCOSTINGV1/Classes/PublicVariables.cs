using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PWCOSTING.BO._000;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework;

namespace PWCOSTINGV1.Classes
{
    public static class AppSettings
    {
        public static string AppName { get; set; }
        public static string AppVersion { get; set; }
        public static string AppVendor { get; set; }
        public static string AppTitle { get; set; }
        public static string AppCopyright { get; set; }
        public static string AppTrademark { get; set; }
        public static tbl_000_COMPANY CompanyProfile { get; set; }
        public static Boolean AppConnected { get; set; }
    }

    public static class UserSettings
    {
        public static string Username { get; set; }
        public static int LogInYear { get; set; }
        public static Boolean IsAuthenticated { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerIP { get; set; }
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static tbl_000_USER CurrentUser { get; set; }
    }

    public static class AppConnectionString
    {
        public static string ServerName { get; set; }
        public static Boolean IsTrusted { get; set; }
        public static string ServerUserID { get; set; }
        public static string ServerPassword { get; set; }
        public static string DBName { get; set; }
        public static string UpdateSourcePath { get; set; }

        public static string ConnectionString
        {
            get
            {
                string conn = "Data Source=" + ServerName + ";";
                if (IsTrusted == true)
                {
                    conn = conn + "Initial catalog=" + DBName + ";Integrated Security=true;";
                }
                else
                {
                    conn = conn + "Initial catalog=" + DBName + ";User ID=" + ServerUserID + ";Password=" + ServerPassword + ";Integrated Security=false;";
                }
                return conn;
            }
        }
    }

    public static class ListWindowSettings
    {
        public static Size WindowSize { get; set; }
    }

    public static class EntryWindowSettings
    {
        public static Size WindowSize { get { return new Size(800, 600); } }
    }

    public static class MenuWindowSettings
    {
        public static Size WindowSize { get; set; }
    }

    public static class MenuTileSize
    {
        public static Size SmallTileSize { get { return new Size(100, 100); } }
        public static Size MeduimTileSize { get { return new Size(150, 100); } }
        public static Size LargeTileSize { get { return new Size(200, 100); } }
    }

    public static class MDIForms
    {
        public static MetroForm MyParentForm { get; set; }
    }

    public static class MyFormStyles
    {
        public static MetroColorStyle MyColor { get; set; }
        public static MetroThemeStyle MyStyle { get; set; }
        public static MetroStyleManager GetStyleManager(MetroForm myOwner)
        {
            MetroStyleManager mymsm = new MetroStyleManager();
            mymsm.Style = MyColor;
            mymsm.Theme = MyStyle;
            mymsm.Owner = myOwner;
            return mymsm;
        }
    }


    public enum FormState
    {
        Add = 1,
        Edit = 2,
        View = 3,
        Delete = 4,
        Search = 5,
        Refresh = 6,
        //Additional Operations
        Print,
        Preview,
        ViewAll
    }

    public enum YearsOf
    {
        Components = 1,
        MaintainanceTable = 2,
        ProcessSetup = 3,
        Items = 4
    }
    public enum MaintainanceTableSub
    {
        PlasticInjection = 1,
        VacuumPlating = 2,
        Assembly = 3
    }
    public enum ItemComposition
    {
        Components = 1,
        PlasticInjection = 2,
        VacuumPlating = 3,
        Assembly = 4,
        PlasticInjection_VacuumPlating = 5,
        PlasticInjection_Assembly = 6,
        VacuumPlating_Assembly = 7,
        AllTabulation = 8,
        ManufacturingProcessTIME = 9,
        FilmDepreciationCost = 10,
        _NULL = 11
    }
}
