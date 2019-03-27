using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using BPSolutionsTools;
using System.Data.Entity;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._100
{
    public class WIPDAL
    {
        AppDBContext db;
        WIPMaterialsDAL wipmatdal;
        public WIPDAL()
        {
            db = new AppDBContext();
            wipmatdal = new WIPMaterialsDAL();
        }
        public List<tbl_100_WIP> GetAll()
        {
            try
            {
                return db.WIPList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP> GetByYear(int yearused)
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
        public tbl_100_WIP GetByRecID(long recid)
        {
            try
            {
                return GetAll().Where(w => w.RecID == recid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP GetByID(int yearused, string itemno, string partcode)
        {
            try
            {
                return db.WIPList.AsNoTracking().Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartCode == partcode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_100_WIP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record.WIPMaterials, "").ToString() != "")
                    {
                        foreach (tbl_100_WIP_Materials wipmat in record.WIPMaterials)
                        {
                            db.WIPMaterialsList.Add(wipmat);
                            db.SaveChanges();
                        }
                    }
                    db.WIPList.Add(record);
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
        public Boolean Update(tbl_100_WIP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(record.WIPMaterials, "").ToString() != "")
                    {
                        foreach (tbl_100_WIP_Materials wipmat in record.WIPMaterials)
                        {
                            if (wipmat.state == "update")
                            {
                                db.Entry(wipmat).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            else if (wipmat.state == "add")
                            {
                                db.WIPMaterialsList.Add(wipmat);
                                db.SaveChanges();
                            }
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
        public Boolean Delete(tbl_100_WIP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartCode);
                    if (BPSUtilitiesV1.NZ(record.WIPMaterials, "").ToString() != "")
                    {
                        foreach (tbl_100_WIP_Materials mat in record.WIPMaterials)
                        {
                            db.WIPMaterialsList.Remove(mat);
                            db.SaveChanges();
                        }
                    }
                    db.WIPList.Remove(existrecord);
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
