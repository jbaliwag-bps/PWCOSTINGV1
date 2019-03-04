using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class FXSPDAL
    {
        AppDBContext db;

        public FXSPDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_FXSP> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.FXSPList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_FXSP GetByID(string rectype, DateTime effectivedate)
        {
            try
            {
                return db.FXSPList.Where(m => m.RecType == rectype && m.EffectiveDate == effectivedate).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_FXSP GetByType(string rectype)
        {
            try
            {
                return db.FXSPList.Where(m => m.RecType == rectype).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistType(string rectype)
        {
            try
            {
                return GetByType(rectype) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(string rectype, DateTime effectivedate)
        {
            try
            {
                return GetByID(rectype, effectivedate) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_FXSP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.FXSPList.Add(record);
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
        public Boolean Update(tbl_000_FXSP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.RecType, record.EffectiveDate);
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
        public Boolean Delete(tbl_000_FXSP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.RecType, record.EffectiveDate);
                    db.FXSPList.Remove(existrecord);
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Commit();
                    throw ex;
                }
            }
        }
    }
}
