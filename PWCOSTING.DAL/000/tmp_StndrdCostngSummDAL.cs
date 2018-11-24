using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;

namespace PWCOSTING.DAL._000
{
    public class tmp_StndrdCostngSummDAL
    {
        AppDBContext db;
        public tmp_StndrdCostngSummDAL()
        {
            db = new AppDBContext();
        }

        public List<tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.tmp_StndardCostngSummList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
