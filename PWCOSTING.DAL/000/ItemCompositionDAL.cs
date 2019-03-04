using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class ItemCompositionDAL
    {
        AppDBContext db;
        public ItemCompositionDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM_PART> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemPartList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_PART GetByID(long docid)
        {
            try
            {
                return db.ItemPartList.Where(m => m.DocID == docid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_PART> GetByNo(int yearused, string itemno)
        {
            try
            {
                return db.ItemPartList.AsNoTracking().Where(m => m.YEARUSED == yearused && m.ItemNo == itemno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_PART GetByPartName(string partname)
        {
            try
            {
                return db.ItemPartList.Where(m => m.PartName == partname).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_PART> GetByYear(int yearused)
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
        public Boolean IsExistPartName(string partname)
        {
            try
            {
                return GetByPartName(partname) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(long docid)
        {
            try
            {
                return GetByID(docid) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetItemNos(int yearused)
        {
            try
            {
                var hashed = new HashSet<string>(db.ItemPartList.AsNoTracking().Distinct().OrderBy(o => o.ItemNo).
                    Where(w => w.YEARUSED == yearused).Select(s => s.ItemNo).ToList());
                return hashed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetMoldNos(int yearused, string itemno, string partno)
        {
            try
            {
                var hashed = new HashSet<string>(db.ItemPartList.AsNoTracking().Distinct().
                    Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartNo == partno).Select(s => s.MoldNo).ToList());
                return hashed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.ItemPartList.Add(record);
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
        public Boolean Update(tbl_000_H_ITEM_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.DocID);
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
        public Boolean Delete(tbl_000_H_ITEM_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo);
                    var existrecord = GetByID(record.DocID);
                    db.ItemPartList.Remove(existrecord);
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
