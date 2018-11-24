using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Reflection;

namespace PWCOSTINGV1.Classes
{
    public static class ObjectFinder
    {
        private static object CreateObjectInstance(string objectname)
        {
            object obj;
            try
            {
                if (objectname.LastIndexOf(".") == -1)
                {
                    var assym = Assembly.GetEntryAssembly().GetName().Name;
                    objectname = assym + ".Forms." + objectname;
                }
                obj = Assembly.GetExecutingAssembly().CreateInstance(objectname);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public static MetroForm CreateForm(string FormName)
        {
            try
            {
                return (MetroForm)CreateObjectInstance(FormName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Boolean isFormOpen(string FormName)
        {
            try
            {
                var isopen = false;
                foreach (var frm in Application.OpenForms)
                {
                    var f = (Form)frm;
                    if (f.Name.Equals(FormName))
                    {
                        f.BringToFront();
                        isopen = true;
                        break;
                    }

                }
                return isopen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string ReportPath
        {
            get { return Application.StartupPath + "\\Reports\\"; }
        }
    }
}
