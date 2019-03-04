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
    public class ComponentDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public ComponentDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_PART> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ComponentList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PART GetByID(int yearused, string partno)
        {
            try
            {
                return db.ComponentList.Where(m => m.YEARUSED == yearused && m.PartNo == partno).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_PART> GetByNo(int yearused, string partno)
        {
            try
            {
                return db.ComponentList.Where(m => m.YEARUSED == yearused && m.PartNo == partno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PART GetByName(int yearused, string name)
        {
            try
            {
                return db.ComponentList.Where(m => m.YEARUSED == yearused && m.PartName == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_PART> GetByYear(int yearused)
        {
            try
            {
                return db.ComponentList.AsNoTracking().Where(w => w.YEARUSED == yearused).ToList();
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
        public Boolean IsExistName(int yearused, string name)
        {
            try
            {
                return GetByName(yearused, name) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.ComponentList.Add(record);
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
        public Boolean Save_List(List<tbl_000_H_PART> record_list)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record_list, "").ToString() != null)
                    {
                        foreach (tbl_000_H_PART c in record_list)
                        {
                            db.ComponentList.Add(c);
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
        public Boolean Update(tbl_000_H_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.PartNo);
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
        public Boolean Delete(tbl_000_H_PART record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.PartNo);
                    db.ComponentList.Remove(existrecord);
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
        public Boolean CopyByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyMaterialByYear";
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
