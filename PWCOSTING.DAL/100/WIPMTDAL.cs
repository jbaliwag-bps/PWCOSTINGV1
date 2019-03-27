using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._100
{
    public class WIPMTDAL
    {
        AppDBContext db;
        public WIPMTDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_MT> GetAll()
        {
            try
            {
                return db.WIPMTList.AsNoTracking().ToList();
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
                return GetAll().Where(w => w.YEARUSED == yearused).ToList();
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
                return db.WIPMTList.Where(w => w.YEARUSED == yearused && w.PartNo == partno).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(int yearused, string partno)
        {
            try
            {
                return GetByID(yearused, partno) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_100_WIP_MT record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.WIPMTList.Add(record);
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }
        public Boolean Update(tbl_100_WIP_MT record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.PartNo);
                    db.Entry(existrecord).GetDatabaseValues().SetValues(record);
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }
        public Boolean Delete(tbl_100_WIP_MT record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.PartNo);
                    db.WIPMTList.Attach(existrecord);
                    db.WIPMTList.Remove(existrecord);
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
