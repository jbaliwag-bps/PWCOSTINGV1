using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPLabBaggingBAL
    {
        WIPLabBaggingDAL wipbagdal;
        public WIPLabBaggingBAL()
        {
            wipbagdal = new WIPLabBaggingDAL();
        }
        public List<tbl_100_WIP_COSTING_LABOR_BAGG> GetAll()
        {
            try
            {
                return wipbagdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_LABOR_BAGG GetByID(long recid)
        {
            try
            {
                var exist = wipbagdal.GetByID(recid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_BAGG> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return wipbagdal.GetByNo(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_BAGG> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipbagdal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_BAGG> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipbagdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_BAGG> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipbagdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_BAGG> records)
        {
            try
            {
                return wipbagdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
