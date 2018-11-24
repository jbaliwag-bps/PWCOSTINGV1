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
    public class WIPLabPlatingDAL
    {
        AppDBContext db;
        public WIPLabPlatingDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_COSTING_LABOR_PLATED> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.WIPLaborPlatedList.AsNoTracking().ToList();
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
                return db.WIPLaborPlatedList.AsNoTracking().Where(w => w.RecID == recid).FirstOrDefault();
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
                return GetAll().Where(w => w.ItemNo == itemno && w.YEARUSED == yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_PLATED record in records)
                    {
                        db.WIPLaborPlatedList.Add(record);
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
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_PLATED record in records)
                    {
                        db.WIPLaborPlatedList.Attach(record);
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
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_PLATED> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_PLATED record in records)
                    {
                        var existrecord = GetByID(record.RecID);
                        db.WIPLaborPlatedList.Remove(existrecord);
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
