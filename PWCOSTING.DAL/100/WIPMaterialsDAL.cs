using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;

namespace PWCOSTING.DAL._100
{
    public class WIPMaterialsDAL
    {
        AppDBContext db;
        public WIPMaterialsDAL()
        {
            db = new AppDBContext();
        }
        public List<tbl_100_WIP_Materials> GetAll()
        {
            try
            {
                return db.WIPMaterialsList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_Materials> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                return db.WIPMaterialsList.Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartNo == partno).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_Materials GetByID(int yearused, string itemno, string partno, string matcode)
        {
            try
            {
                return db.WIPMaterialsList.
                    Where(w => w.YEARUSED == yearused && w.ItemNo == itemno && w.PartNo == partno && w.MatCode == matcode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_Materials GetByRecID(long recid)
        {
            try
            {
                return db.WIPMaterialsList.Where(w => w.RecID == recid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_100_WIP_Materials> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (tbl_100_WIP_Materials record in records)
                    {
                        var existrecord = GetByID(record.YEARUSED, record.ItemNo, record.PartNo, record.MatCode);
                        db.WIPMaterialsList.Remove(existrecord);
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
    }
}
