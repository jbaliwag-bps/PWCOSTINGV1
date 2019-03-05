﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PWCOSTING.DAL._000
{
    public class CategoryDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public CategoryDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_CATEGORY> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.CategoryList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY GetByID(string catcode, int yearused)
        {
            try
            {
                return db.CategoryList.Where(m => m.CATCODE == catcode && m.YEARUSED == yearused).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY GetByCatDesc(string catdesc)
        {
            try
            {
                return db.CategoryList.Where(m => m.CATDESC == catdesc).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistCatDesc(string catdesc)
        {
            try
            {
                return GetByCatDesc(catdesc) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(string catcode, int yearused)
        {
            try
            {
                return GetByID(catcode, yearused) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_CATEGORY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.CategoryList.Add(record);
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
        public Boolean Update(tbl_000_H_CATEGORY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.CATCODE, record.YEARUSED);
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
        public Boolean Delete(tbl_000_H_CATEGORY record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.CATCODE, record.YEARUSED);
                    db.CategoryList.Remove(existrecord);
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
        public HashSet<string> GetCatCodes(int yearused)
        {
            try
            {
                var hashed = new HashSet<string>(db.CategoryList.AsNoTracking().Distinct().OrderBy(o => o.CATCODE).
                    Where(w => w.YEARUSED == yearused).Select(s => s.CATCODE).ToList());
                return hashed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyByCat(int yearusedfrom, int yearusedto, string catcode, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyByCat";
                using (con = new SqlConnection(Common.ConnectionString))
                {
                    con.Open();
                    using (cmd = new SqlCommand(spname, con))
                    {
                        var prms = cmd.Parameters;
                        prms.Clear();
                        prms.Add(new SqlParameter("@YEARUSEDFROM", yearusedfrom));
                        prms.Add(new SqlParameter("@YEARUSEDTO", yearusedto));
                        prms.Add(new SqlParameter("@CatCode", catcode));
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
        public Boolean CopyCatByYear(int yearusedfrom, int yearusedto, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyCatByYear";
                using (con = new SqlConnection(Common.ConnectionString))
                {
                    con.Open();
                    using (cmd = new SqlCommand(spname, con))
                    {
                        var prms = cmd.Parameters;
                        prms.Clear();
                        prms.Add(new SqlParameter("@YEARUSEDFROM", yearusedfrom));
                        prms.Add(new SqlParameter("@YEARUSEDTO", yearusedto));
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
