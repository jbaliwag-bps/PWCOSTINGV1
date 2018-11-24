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
    public class PlasticInjectionDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public PlasticInjectionDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_PI> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.PlasticInjectionList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PI GetByID(int yearused, string moldno)
        {
            try
            {
                return db.PlasticInjectionList.Where(m => m.YEARUSED == yearused && m.MoldNo == moldno).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_PI> GetByNo(int yearused, string moldno)
        {
            try
            {
                return db.PlasticInjectionList.Where(m => m.YEARUSED == yearused && m.MoldNo == moldno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PI GetByName(int yearused, string moldname)
        {
            try
            {
                return db.PlasticInjectionList.Where(m => m.YEARUSED == yearused && m.MoldName == moldname).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_PI> GetByYear(int yearused)
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
        public Boolean IsExistID(int yearused, string moldno)
        {
            try
            {
                return GetByID(yearused, moldno) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistName(int yearused, string moldname)
        {
            try
            {
                return GetByName(yearused, moldname) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_PI record)
        {
            try
            {
                db.PlasticInjectionList.Add(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_PI> record_list)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record_list, "").ToString() != null)
                    {
                        foreach (tbl_000_H_PI p in record_list)
                        {
                            db.PlasticInjectionList.Add(p);
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
        public Boolean Update(tbl_000_H_PI record)
        {
            try
            {
                var existrecord = GetByID(record.YEARUSED, record.MoldNo);
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_PI record)
        {
            try
            {
                var existrecord = GetByID(record.YEARUSED, record.MoldNo);
                db.PlasticInjectionList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteAll(tbl_000_H_PI record)
        {
            try
            {
                db.PlasticInjectionList.Remove(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyPIByYear";
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
