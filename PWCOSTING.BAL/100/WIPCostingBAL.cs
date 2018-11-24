using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPCostingBAL
    {
        WIPCostingDAL wipcostdal;
        public WIPCostingBAL()
        {
            wipcostdal = new WIPCostingDAL();
        }
        public List<tbl_100_WIP_COST> GetAll()
        {
            try
            {
                return wipcostdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COST GetByID(long recid)
        {
            try
            {
                return wipcostdal.GetByID(recid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COST> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcostdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COST> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcostdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COST> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipcostdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COST> records)
        {
            try
            {
                return wipcostdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
