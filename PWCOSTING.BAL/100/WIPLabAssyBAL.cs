using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPLabAssyBAL
    {
        WIPLabAssyDAL wipassydal;
        public WIPLabAssyBAL()
        {
            wipassydal = new WIPLabAssyDAL();
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetAll()
        {
            try
            {
                return wipassydal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_LABOR_ASSY GetByID(long recid)
        {
            try
            {
                var exist = wipassydal.GetByID(recid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return wipassydal.GetByNo(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipassydal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipassydal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipassydal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            try
            {
                return wipassydal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
