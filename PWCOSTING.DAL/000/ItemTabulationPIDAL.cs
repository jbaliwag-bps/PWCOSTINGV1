﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class ItemTabulationPIDAL
    {
        AppDBContext db;
        public ItemTabulationPIDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM_TABULATION> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemTabulationPIList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION GetByID(long docid)
        {
            try
            {
                return db.ItemTabulationPIList.Where(m => m.DocID == docid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_TABULATION> GetByNo(int yearused, string itemno)
        {
            try
            {
                return db.ItemTabulationPIList.AsNoTracking().OrderBy(o => o.DocID).Where(w => w.YEARUSED == yearused && w.ItemNo == itemno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION GetByPartName(string partname)
        {
            try
            {
                return db.ItemTabulationPIList.Where(m => m.PartName == partname).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistPartName(string partname)
        {
            try
            {
                return GetByPartName(partname) != null;
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
        public Boolean Save(tbl_000_H_ITEM_TABULATION record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.ItemTabulationPIList.Add(record);
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
        public Boolean Update(tbl_000_H_ITEM_TABULATION record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo);
                    var existrecord = GetByID(record.DocID);
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
        public Boolean Delete(tbl_000_H_ITEM_TABULATION record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo);
                    var existrecord = GetByID(record.DocID);
                    db.ItemTabulationPIList.Remove(existrecord);
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