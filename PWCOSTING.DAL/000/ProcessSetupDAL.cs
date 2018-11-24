using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PWCOSTING.DAL._000
{
    public class ProcessSetupDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public ProcessSetupDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_PROCESS> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ProcessList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_PROCESS GetByID(int yearused, string subprocessCode)
        {
            try
            {
                return db.ProcessList.Where(w => w.YEARUSED == yearused && w.SubProcessCode == subprocessCode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_PROCESS> GetByYear(int yearused)
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
        public Boolean IsExistID(int yearused, string subproccesscode)
        {
            try
            {
                return GetByID(yearused, subproccesscode) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_000_PROCESS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_000_PROCESS p in records)
                    {
                        db.ProcessList.Add(p);
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
        public Boolean Update(List<tbl_000_PROCESS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_000_PROCESS p in records)
                    {
                        var existrecord = GetByID(p.YEARUSED, p.SubProcessCode);
                        db.Entry(existrecord).CurrentValues.SetValues(p);
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
        public Boolean Delete(List<tbl_000_PROCESS> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_000_PROCESS p in records)
                    {
                        var existrecord = GetByID(p.YEARUSED, p.SubProcessCode);
                        db.ProcessList.Remove(existrecord);
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
        public Boolean CopyByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyProcessByYear";
                using (con = new SqlConnection(Common.ConnectionString))
                {
                    con.Open();
                    using (cmd = new SqlCommand(spname, con))
                    {
                        var prms = cmd.Parameters;
                        prms.Clear();
                        prms.Add(new SqlParameter("@YEARUSEDFROM", yearusedfrom));
                        prms.Add(new SqlParameter("@YEARUSEDTO", yearusedto));
                        prms.Add(new SqlParameter("@User", user));
                        prms.Add(new SqlParameter("@IsOverwrite", IsOverwrite));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
