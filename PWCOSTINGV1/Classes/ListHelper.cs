using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Drawing;

namespace PWCOSTINGV1.Classes
{
    public static class ListHelper
    {
        public static void FillMetroCombo(MetroComboBox mcbo, Object dtSource, string strValue, string strDisplay)
        {
            mcbo.DataSource = dtSource;
            mcbo.ValueMember = strValue;
            mcbo.DisplayMember = strDisplay;
        }

        public static object GetResources(string strResouceName)
        {
            object obj = null;
            switch(strResouceName.ToLower()){
                case "filesicon":
                    obj = PWCOSTINGV1.Properties.Resources.filesicon40;
                    break;
                case "filesbicon":
                    obj = PWCOSTINGV1.Properties.Resources.filesbicon40;
                    break;
                case "reportsicon":
                    obj = PWCOSTINGV1.Properties.Resources.reportsicon40;
                    break;
                case "reportsbicon":
                    obj = PWCOSTINGV1.Properties.Resources.reportsbicon40;
                    break;
                case "settingsicon":
                    obj = PWCOSTINGV1.Properties.Resources.settingsicon40;
                    break;
                case "settingsbicon":
                    obj = PWCOSTINGV1.Properties.Resources.settingsbicon40;
                    break;
                case "tpilogoicon":
                    obj = PWCOSTINGV1.Properties.Resources.tpilogoicon40;
                    break;
                case "hobbyicon":
                    obj = PWCOSTINGV1.Properties.Resources.hobbyicon;
                    break;
                case "wipicon":
                    obj = PWCOSTINGV1.Properties.Resources.WIPicon;
                    break;
                case "utilitiesicon":
                    obj = PWCOSTINGV1.Properties.Resources.utilitiesicon40;
                    break;
                case "utilitiesbicon":
                    obj = PWCOSTINGV1.Properties.Resources.utilitiesbicon40;
                    break;
                case "metrouiicon":
                    obj = PWCOSTINGV1.Properties.Resources.metrouiicon40;
                    break;
                case "signofficon":
                    obj = PWCOSTINGV1.Properties.Resources.signofficon40;
                    break;
                case "changepasswordicon":
                    obj = PWCOSTINGV1.Properties.Resources.changepassicon40;
                    break;
            }       
            return obj;
        }

        public static Image FormatImage(Image imgobj, int h, int w)
        {
            Image byteimg = null;
            if(imgobj != null){
                //resize image to 40,40 dimension
                byteimg = new Bitmap(imgobj, new Size(w,h));                
            }
            return byteimg;
        }
    }
}
