using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using BPSolutionsTools.BPSUtilities;
using BPSolutionsTools;
using System.Data.Entity;

namespace PWCOSTING.DAL._100
{
    public class WIPCostingDAL
    {
        AppDBContext db;
        public WIPCostingDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_COST> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.WIPCostingList.AsNoTracking().ToList();
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
                return db.WIPCostingList.AsNoTracking().Where(w => w.RecID == recid).FirstOrDefault();
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
                return GetAll().Where(w => w.YEARUSED == yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COST> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COST record in records)
                    {
                        db.WIPCostingList.Add(record);
                        db.SaveChanges();
                    }
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
        public Boolean Update(List<tbl_100_WIP_COST> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COST record in records)
                    {
                        db.WIPCostingList.Attach(record);
                        db.Entry(record).State = EntityState.Modified;
                        db.SaveChanges();
                    }
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
        public Boolean Delete(List<tbl_100_WIP_COST> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COST record in records)
                    {
                        var existrecord = GetByID(record.RecID);
                        db.WIPCostingList.Remove(existrecord);
                        db.SaveChanges();
                    }
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
