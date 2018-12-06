using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPMatBAL
    {
        WIPMatDAL wipmatdal;
        public WIPMatBAL()
        {
            wipmatdal = new WIPMatDAL();
        }
        public List<tbl_100_WIP_COSTING_MATERIALS> GetAll()
        {
            try
            {
                return wipmatdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_MATERIALS GetByID(long recid)
        {
            try
            {
                var exist = wipmatdal.GetByID(recid);
                return exist;                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_MATERIALS> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return wipmatdal.GetByNo(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_MATERIALS> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipmatdal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipmatdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipmatdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            try
            {
                return wipmatdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
