using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPCostingItemBAL
    {
        WIPCostingItemDAL wipcitemdal;
        public WIPCostingItemBAL()
        {
            wipcitemdal = new WIPCostingItemDAL();            
        }
        public List<tbl_100_WIP_COSTING_ITEM> GetAll()
        {
            try
            {
                return wipcitemdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_ITEM GetByID(int yearused, string itemno, string partno, string ref_add)
        {
            try
            {
                return wipcitemdal.GetByID(yearused, itemno, partno, ref_add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_ITEM> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcitemdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcitemdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcitemdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            try
            {
                return wipcitemdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
