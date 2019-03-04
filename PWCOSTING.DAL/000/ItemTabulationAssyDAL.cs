using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class ItemTabulationAssyDAL
    {
        AppDBContext db;
        public ItemTabulationAssyDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM_TABULATION_ASSY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemTabulationAssyList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_ASSY GetByID(long docid)
        {
            try
            {
                return db.ItemTabulationAssyList.Where(m => m.DocID == docid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_TABULATION_ASSY> GetByNo(int yearused, string itemno)
        {
            try
            {
                return db.ItemTabulationAssyList.AsNoTracking().Where(w => w.YEARUSED == yearused && w.ItemNo == itemno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_ASSY GetByPartName(string partname)
        {
            try
            {
                return db.ItemTabulationAssyList.Where(m => m.PartName == partname).FirstOrDefault();
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
        public Boolean Save(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.ItemTabulationAssyList.Add(record);
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
        public Boolean Update(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo);
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
        public Boolean Delete(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.DocID);
                    db.ItemTabulationAssyList.Remove(existrecord);
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