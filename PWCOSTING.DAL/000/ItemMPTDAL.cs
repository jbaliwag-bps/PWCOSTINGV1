using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class ItemMPTDAL
    {
        AppDBContext db;
        public ItemMPTDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM_MPT> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemMPTList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_MPT GetByID(long docid)
        {
            try
            {
                return db.ItemMPTList.Where(m => m.DocID == docid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_MPT> GetByNo(int yearused, string itemno)
        {
            try
            {
                return db.ItemMPTList.AsNoTracking().OrderBy(o => o.DocID).Where(w => w.YEARUSED == w.YEARUSED && w.ItemNo == itemno).ToList();
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
        public Boolean Save(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                db.ItemMPTList.Add(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.SectionCode);
                var existrecord = GetByID(record.DocID);
                db.Entry(existrecord).GetDatabaseValues().SetValues(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.SectionCode);
                var existrecord = GetByID(record.DocID);
                db.ItemMPTList.Remove(existrecord);
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
