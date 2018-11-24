using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO.Default;
using PWCOSTING.BO._000;

namespace PWCOSTING.DAL.Default
{
    public class YearDAL
    {
        AppDBContext db;
        public YearDAL()
        {
            db = new AppDBContext();
        }

        public List<tbl_YEAR> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.YearList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_YEAR GetByYear(int RecYear)
        {
            try
            {
                return db.YearList.Where(m => m.RecYear == RecYear).FirstOrDefault();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistID(int RecYear)
        {
            try
            {
                return GetByYear(RecYear) != null;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_YEAR record)
        {
            try
            {
                db.YearList.Add(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_YEAR record)
        {
            try
            {
                var existrecord = GetByYear(record.RecYear);               
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Delete(int RecYear)
        {
            try
            {
                var existrecord = GetByYear(RecYear);                
                db.YearList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Lock(tbl_YEAR record)
        {
            try
            {
                var existrecord = GetByYear(record.RecYear);
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_FXSP CheckFXSPYear(int RecYear)
        {
            try
            {
                return db.FXSPList.Where(m => m.YearUsed == RecYear).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY CheckCatYear(int RecYear)
        {
            try
            {
                return db.CategoryList.Where(m => m.YEARUSED == RecYear).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Remove(int RecYear)
        {
            try
            {
                var existrecord = GetByYear(RecYear);
                db.YearList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
