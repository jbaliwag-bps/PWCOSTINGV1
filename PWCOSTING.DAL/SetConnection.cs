using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.DAL;

namespace PWCOSTING.DAL
{
    public static class SetDALConnection
    {
        public static void SetConnectionString(string cnstring)
        {
            Common.ConnectionString = cnstring;
        }
    }
}
