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
    public class VacuumPlatingDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public VacuumPlatingDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_VP> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.VacuumPlatingList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_VP GetByID(int yearused, string partno)
        {
            try
            {
                return db.VacuumPlatingList.Where(m => m.YEARUSED == yearused && m.PartNo == partno).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_VP> GetByNo(int yearused, string partno)
        {
            try
            {
                return db.VacuumPlatingList.Where(m => m.YEARUSED == yearused && m.PartNo == partno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_VP GetByName(int yearused, string partname)
        {
            try
            {
                return db.VacuumPlatingList.Where(m => m.YEARUSED == yearused && m.PartName == partname).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_VP> GetByYear(int yearused)
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
        public Boolean IsExistID(int yearused, string partno)
        {
            try
            {
                return GetByID(yearused, partno) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistName(int yearused, string partname)
        {
            try
            {
                return GetByName(yearused, partname) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_VP record)
        {
            try
            {
                db.VacuumPlatingList.Add(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_VP> record_list)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record_list, "").ToString() != null)
                    {
                        foreach (tbl_000_H_VP v in record_list)
                        {
                            db.VacuumPlatingList.Add(v);
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
        public Boolean Update(tbl_000_H_VP record)
        {
            try
            {
                var existrecord = GetByID(record.YEARUSED, record.PartNo);
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_VP record)
        {
            try
            {
                var existrecord = GetByID(record.YEARUSED, record.PartNo);
                db.VacuumPlatingList.Remove(existrecord);
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
                string spname = "sp_CopyVPByYear";
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
