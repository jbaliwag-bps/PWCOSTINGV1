using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class CategoryBAL
    {
        CategoryDAL catdal;
        public CategoryBAL()
        {
            catdal = new CategoryDAL();
        }
        public List<tbl_000_H_CATEGORY> GetAll()
        {
            try
            {
                return catdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY GetByID(string catcode, int yearused)
        {
            try
            {
                if (catcode == null || yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = catdal.GetByID(catcode, yearused);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY GetByCatDesc(string catdesc)
        {
            try
            {
                if (catdesc == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = catdal.GetByCatDesc(catdesc);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_CATEGORY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (catdal.IsExistID(record.CATCODE, record.YEARUSED))
                {
                    throw new Exception("Code already taken!");
                }
                return catdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_CATEGORY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!catdal.IsExistID(record.CATCODE, record.YEARUSED))
                {
                    throw new Exception("Record does not exist!");
                }
                return catdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_CATEGORY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!catdal.IsExistID(record.CATCODE, record.YEARUSED))
                {
                    throw new Exception("Record does not exist!");
                }
                return catdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetCatCodes(int yearused)
        {
            try
            {
                return catdal.GetCatCodes(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyByCat(int yearusedfrom, int yearusedto, string catcode, Boolean IsOverwrite)
        {
            try
            {
                var exist = GetByID(catcode, yearusedto);
                if (!IsOverwrite)
                {
                    if (exist != null)
                    {
                        throw new Exception("Record already exists!");
                    }
                }
                return catdal.CopyByCat(yearusedfrom, yearusedto, catcode, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyCatByYear(int yearusedfrom, int yearusedto, Boolean IsOverwrite)
        {
            try
            {
                return catdal.CopyCatByYear(yearusedfrom, yearusedto, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
