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
    public class WIPMatDAL
    {
        AppDBContext db;
        public WIPMatDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_COSTING_MATERIALS> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.WIPMaterialList.AsNoTracking().ToList();
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
                return db.WIPMaterialList.AsNoTracking().Where(w => w.RecID == recid).FirstOrDefault();
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
                return GetAll().Where(w => w.ItemNo == itemno && w.YEARUSED == yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_MATERIALS record in records)
                    {
                        db.WIPMaterialList.Add(record);
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
        public Boolean Update(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_MATERIALS record in records)
                    {
                        db.WIPMaterialList.Attach(record);
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
        public Boolean Delete(List<tbl_100_WIP_COSTING_MATERIALS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_MATERIALS record in records)
                    {
                        var existrecord = GetByID(record.RecID);
                        db.WIPMaterialList.Remove(existrecord);
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
