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
    public class WIPCostingItemDAL
    {
        AppDBContext db;
        public WIPCostingItemDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_COSTING_ITEM> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.WIPCostingItemList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_ITEM GetByID(int yearused, string itemno, string partno, string ref_add)
        {
            try
            {
                return db.WIPCostingItemList.AsNoTracking().Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartNo == partno && w.Ref_Add == ref_add).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_ITEM> GetByYear(int yearused)
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
        public Boolean Save(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_ITEM record in records)
                    {
                        db.WIPCostingItemList.Add(record);
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
        public Boolean Update(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_ITEM record in records)
                    {
                        db.WIPCostingItemList.Attach(record);
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
        public Boolean Delete(List<tbl_100_WIP_COSTING_ITEM> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_ITEM record in records)
                    {
                        var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo, record.Ref_Add);
                        db.WIPCostingItemList.Remove(existrecord);
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
