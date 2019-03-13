using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using BPSolutionsTools;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PWCOSTING.DAL._000
{
    public class MODRCDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;

        public MODRCDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_MODRC> GetAll()
        {
            try
            {
                return db.MODRCList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_MODRC GetByID(string modrccode)
        {
            try
            {
                return db.MODRCList.Where(w => w.MODRCCode == modrccode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_MODRC GetByDesc(string desc)
        {
            try
            {
                return db.MODRCList.Where(w => w.Description == desc).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(string modrccode)
        {
            try
            {
                return GetByID(modrccode) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistDesc(string desc)
        {
            try
            {
                return GetByDesc(desc) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_MODRC record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.MODRCList.Add(record);
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
        public Boolean Update(tbl_000_MODRC record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.MODRCCode);
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
        public Boolean Delete(tbl_000_MODRC record)
        {
            using (var dbContextTranaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.MODRCCode);
                    db.MODRCList.Remove(existrecord);
                    db.SaveChanges();
                    dbContextTranaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTranaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
