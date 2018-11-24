using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPLabPlatingBAL
    {
        WIPLabPlatingDAL wipplatdal;
        public WIPLabPlatingBAL()
        {
            wipplatdal = new WIPLabPlatingDAL();
        }
        public List<tbl_100_WIP_COSTING_LABOR_PLATED> GetAll()
        {
            try
            {
                return wipplatdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_LABOR_PLATED GetByID(long recid)
        {
            try
            {
                var exist = wipplatdal.GetByID(recid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_PLATED> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipplatdal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipplatdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipplatdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            try
            {
                return wipplatdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

