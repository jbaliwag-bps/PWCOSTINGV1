using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{

    public class WIPLabPIBAL
    {
        WIPLabPIDAL wippidal;
        public WIPLabPIBAL()
        {
            wippidal = new WIPLabPIDAL();
        }
        public List<tbl_100_WIP_COSTING_LABOR_PI> GetAll()
        {
            try
            {
                return wippidal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_LABOR_PI GetByID(long recid)
        {
            try
            {
                var exist = wippidal.GetByID(recid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_PI> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return wippidal.GetByNo(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_PI> GetByYear(string itemno, int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wippidal.GetByYear(itemno, yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_PI> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wippidal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_PI> records)
        {
            try
            {
                if (records == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wippidal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_PI> records)
        {
            try
            {
                return wippidal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
