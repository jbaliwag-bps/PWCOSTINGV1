using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPMTBAL
    {
        WIPMTDAL mtdal;
        public WIPMTBAL()
        {
            mtdal = new WIPMTDAL();
        }
        public List<tbl_100_WIP_MT> GetAll()
        {
            try
            {
                return mtdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_MT> GetByYear(int yearused)
        {
            try
            {
                return mtdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_MT GetByID(int yearused, string partno)
        {
            try
            {
                return mtdal.GetByID(yearused, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_100_WIP_MT record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (mtdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("No. already taken!");
                }
                return mtdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_100_WIP_MT record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!mtdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return mtdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_100_WIP_MT record)
        {
            try
            {
                return mtdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
