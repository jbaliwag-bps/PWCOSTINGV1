using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;
namespace PWCOSTING.BAL._100
{
    public class WIPCCodeBAL
    {
        WIPCCodeDAL wipccdal;
        public WIPCCodeBAL()
        {
            wipccdal = new WIPCCodeDAL();
        }
        public List<tbl_100_WIP_COSTING_CC> GetAll()
        {
            try
            {
                return wipccdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_CC GetByID(long recid)
        {
            try
            {
                var exist = wipccdal.GetByID(recid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_CC> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipccdal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_CC> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipccdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_CC> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipccdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_CC> records)
        {
            try
            {
                return wipccdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
