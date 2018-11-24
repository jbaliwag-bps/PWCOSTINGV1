using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class tmp_CompositionBAL
    {
        tmp_CompositionDAL tmpcomdal;
        public tmp_CompositionBAL()
        {
            tmpcomdal = new tmp_CompositionDAL();
        }
        public Boolean Save(List<tbl_tmp_H_ITEM_PART> records)
        {
            try 
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return tmpcomdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DistributeCompo(int yearused, string itemno, string user)
        {
            try
            {
                if (yearused == 0 || itemno == null || user == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return tmpcomdal.DistributeCompo(yearused, itemno, user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
