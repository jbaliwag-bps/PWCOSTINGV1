using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using BPSolutionsTools;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace PWCOSTING.DAL._000
{
    public class ItemDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public ItemDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_000_H_ITEM> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.ItemList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM GetByID(int yearused, string itemno)
        {
            try
            {
                return db.ItemList.AsNoTracking().Where(m => m.YEARUSED == yearused && m.ItemNo == itemno).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM GetByItemDesc(int yearused, string itemdesc)
        {
            try
            {
                return db.ItemList.Where(m => m.Description == itemdesc && m.YEARUSED == yearused).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM> GetByYear(int yearused)
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
        public Boolean IsExistItemDesc(int yearused, string itemdesc)
        {
            try
            {
                return GetByItemDesc(yearused, itemdesc) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(int yearused, string itemno)
        {
            try
            {
                return GetByID(yearused, itemno) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetAllItemNos()
        {
            try
            {
                var hashed = new HashSet<string>(db.ItemList.AsNoTracking().Distinct().OrderBy(o => o.ItemNo).Select(s => s.ItemNo).ToList());
                return hashed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetItemNos(int yearused)
        {
            try
            {
                var hashed = new HashSet<string>(db.ItemList.AsNoTracking().Distinct().OrderBy(o => o.ItemNo).
                    Where(w => w.YEARUSED == yearused).Select(s => s.ItemNo).ToList());
                return hashed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record.itemCom, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_PART item in record.itemCom)
                        {
                            db.ItemPartList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemPI, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION item in record.itemPI)
                        {
                            db.ItemTabulationPIList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemVP, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION_VP item in record.itemVP)
                        {
                            db.ItemTabulationVPList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemAssy, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION_ASSY item in record.itemAssy)
                        {
                            db.ItemTabulationAssyList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemMPT, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_MPT item in record.itemMPT)
                        {
                            db.ItemMPTList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemFDC, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_FDC item in record.itemFDC)
                        {
                            db.ItemFDCList.Add(item);
                            db.SaveChanges();
                        }
                    }
                    db.ItemList.Add(record);
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
        public Boolean Save_List(List<tbl_000_H_ITEM> record_list)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_000_H_ITEM record in record_list)
                    {
                        if (BPSUtilitiesV1.NZ(record.itemCom, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_PART item in record.itemCom)
                            {
                                db.ItemPartList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        if (BPSUtilitiesV1.NZ(record.itemPI, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_TABULATION item in record.itemPI)
                            {
                                db.ItemTabulationPIList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        if (BPSUtilitiesV1.NZ(record.itemVP, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_TABULATION_VP item in record.itemVP)
                            {
                                db.ItemTabulationVPList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        if (BPSUtilitiesV1.NZ(record.itemAssy, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_TABULATION_ASSY item in record.itemAssy)
                            {
                                db.ItemTabulationAssyList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        if (BPSUtilitiesV1.NZ(record.itemMPT, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_MPT item in record.itemMPT)
                            {
                                db.ItemMPTList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        if (BPSUtilitiesV1.NZ(record.itemFDC, "").ToString() != "")
                        {
                            foreach (tbl_000_H_ITEM_FDC item in record.itemFDC)
                            {
                                db.ItemFDCList.Add(item);
                                db.SaveChanges();
                            }
                        }
                        db.ItemList.Add(record);
                    }
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
        public Boolean Update(tbl_000_H_ITEM record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {

                try
                {
                    if (BPSUtilitiesV1.NZ(record.itemCom, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_PART item in record.itemCom)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if(item.state == "add")
                            {
                                db.ItemPartList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemPI, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION item in record.itemPI)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (item.state == "add")
                            {
                                db.ItemTabulationPIList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemVP, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION_VP item in record.itemVP)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (item.state == "add")
                            {
                                db.ItemTabulationVPList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemAssy, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_TABULATION_ASSY item in record.itemAssy)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (item.state == "add")
                            {
                                db.ItemTabulationAssyList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemMPT, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_MPT item in record.itemMPT)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (item.state == "add")
                            {
                                db.ItemMPTList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    if (BPSUtilitiesV1.NZ(record.itemFDC, "").ToString() != "")
                    {
                        foreach (tbl_000_H_ITEM_FDC item in record.itemFDC)
                        {
                            if (item.state == "update")
                            {
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (item.state == "add")
                            {
                                db.ItemFDCList.Add(item);
                                db.SaveChanges();
                            }
                        }
                    }
                    db.Entry(record).State = EntityState.Modified; 
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
        public Boolean Delete(tbl_000_H_ITEM record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.ItemNo);
                    db.ItemList.Attach(existrecord);
                    db.ItemList.Remove(existrecord);
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
        public Boolean Delete_List(List<tbl_000_H_ITEM> record_list)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_000_H_ITEM record in record_list)
                    {
                        var existrecord = GetByID(record.YEARUSED, record.ItemNo);
                        db.ItemList.Remove(existrecord);
                    }
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
        public Boolean CopyByItem(int yearusedfrom, int yearusedto, string itemno, string user, Boolean IsOverwrite)
       {
            try
            {
                string spname = "sp_CopyByItem";
                using (con = new SqlConnection(Common.ConnectionString))
                {
                    con.Open();
                    using (cmd = new SqlCommand(spname, con))
                    {
                        var prms = cmd.Parameters;
                        prms.Clear();
                        prms.Add(new SqlParameter("@YEARUSEDFROM", yearusedfrom));
                        prms.Add(new SqlParameter("@YEARUSEDTO", yearusedto));
                        prms.Add(new SqlParameter("@ItemNo", itemno));
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
        public Boolean CopyItemByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                string spname = "sp_CopyItemByYear";
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
        public Boolean QuoteItem(int yearused, string itemno)
        {
            try
            {
                string spname = "sp_QuoteItem";
                using (con = new SqlConnection(Common.ConnectionString))
                {
                    con.Open();
                    using (cmd = new SqlCommand(spname, con))
                    {
                        var prms = cmd.Parameters;
                        prms.Clear();
                        prms.Add(new SqlParameter("@YEARUSED", yearused));
                        prms.Add(new SqlParameter("@ItemNo", itemno));
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
