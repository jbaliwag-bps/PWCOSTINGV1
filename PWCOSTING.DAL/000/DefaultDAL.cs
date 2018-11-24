using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class DefaultDAL
    {
        AppDBContext db;
        public DefaultDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_DEFAULT> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.DefaultList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
