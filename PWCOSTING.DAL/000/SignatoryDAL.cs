using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using System.Data.Entity;

namespace PWCOSTING.DAL._000
{
    public class SignatoryDAL
    {
        AppDBContext db;
        public SignatoryDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_SIGNATORY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.SignatoryList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_SIGNATORY GetByID(Int64 recid)
        {
            try
            {
                return db.SignatoryList.Where(w => w.RecID == recid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(Int64 recid)
        {
            try
            {
                return GetByID(recid) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Boolean Save(List<tbl_SIGNATORY> record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {

                try
                {
                    foreach (tbl_SIGNATORY s in record)
                    {
                        db.SignatoryList.Add(s);
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
        public Boolean Update(List<tbl_SIGNATORY> record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {

                try
                {
                    foreach (tbl_SIGNATORY s in record)
                    {
                        var existrecord = GetByID(s.RecID);
                        db.Entry(existrecord).CurrentValues.SetValues(s);
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
