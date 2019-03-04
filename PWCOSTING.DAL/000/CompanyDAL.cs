using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;

namespace PWCOSTING.DAL._000
{
    public class CompanyDAL
    {
        AppDBContext db;
        public CompanyDAL()
        {
            db = new AppDBContext();
        }

        public List<tbl_000_COMPANY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.CompanyList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_COMPANY GetByID(int id)
        {
            try
            {
                return db.CompanyList.Where(m => m.ID == id).FirstOrDefault();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistID(int id)
        {
            try
            {                
                return GetByID(id) != null;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_000_COMPANY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.CompanyList.Add(record);
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

        public Boolean Update(tbl_000_COMPANY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.ID);
                    db.Entry(existrecord).CurrentValues.SetValues(record);
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

        public Boolean Delete(int id)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(id);
                    db.CompanyList.Remove(existrecord);
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
