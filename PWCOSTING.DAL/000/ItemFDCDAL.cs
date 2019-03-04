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
    public class ItemFDCDAL
    {
        AppDBContext db;
        public ItemFDCDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM_FDC> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemFDCList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_FDC GetByID(int yearused, string itemno, string depntype)
        {
            try
            {
                return db.ItemFDCList.Where(m => m.YEARUSED == yearused && m.ItemNo == itemno && m.DepnType == depntype).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_FDC> GetByNo(int yearused, string itemno)
        {
            try
            {
                return db.ItemFDCList.AsNoTracking().OrderBy(o => o.DocID).Where(w => w.YEARUSED == yearused && w.ItemNo == itemno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_FDC GetByDesc(string description)
        {
            try
            {
                return db.ItemFDCList.Where(m => m.Description == description).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistDesc(string partname)
        {
            try
            {
                return GetByDesc(partname) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(int yearused, string itemno, string partno)
        {
            try
            {
                return GetByID(yearused, itemno, partno) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM_FDC record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.ItemFDCList.Add(record);
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
        public Boolean Update(tbl_000_H_ITEM_FDC record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.DepnType);
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
        public Boolean Delete(tbl_000_H_ITEM_FDC record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.DepnType);
                    db.ItemFDCList.Remove(existrecord);
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