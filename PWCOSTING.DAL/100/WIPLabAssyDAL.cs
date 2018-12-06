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
    public class WIPLabAssyDAL
    {
        AppDBContext db;
        public WIPLabAssyDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.WIPLaborAssyList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_COSTING_LABOR_ASSY GetByID(long recid)
        {
            try
            {
                return db.WIPLaborAssyList.AsNoTracking().Where(w => w.RecID == recid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return db.WIPLaborAssyList.AsNoTracking().Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartNo == partno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_COSTING_LABOR_ASSY> GetByYear(string itemno, int yearused)
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
        public Boolean Save(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_ASSY record in records)
                    {
                        db.WIPLaborAssyList.Add(record);
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
        public Boolean Update(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_ASSY record in records)
                    {
                        if (record.state == "update")
                        {
                            db.Entry(record).State = EntityState.Modified;
                            db.SaveChanges();   
                        }
                        else if (record.state == "add")
                        {
                            db.WIPLaborAssyList.Add(record);
                            db.SaveChanges();
                        }
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
        public Boolean Delete(List<tbl_100_WIP_COSTING_LABOR_ASSY> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_COSTING_LABOR_ASSY record in records)
                    {
                        var existrecord = GetByID(record.RecID);
                        db.WIPLaborAssyList.Attach(existrecord);
                        db.WIPLaborAssyList.Remove(existrecord);
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
