using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class SectionDAL
    {
        AppDBContext db;
        public SectionDAL()
        {
            db = new AppDBContext();
        }

        public List<tbl_000_SECTION> GetAll()
        {
            try
            {
                db = new AppDBContext();
                return db.SectionList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_SECTION GetByID(string sectioncode)
        {
            try
            {
                return db.SectionList.Where(m => m.SECTIONCODE == sectioncode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_SECTION> GetByNo(string sectioncode)
        {
            try
            {
                return db.SectionList.Where(m => m.SECTIONCODE == sectioncode).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_SECTION GetBySectionDesc(string sectiondesc)
        {
            try
            {
                return db.SectionList.Where(m => m.SECTIONDESC == sectiondesc).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistSectionDesc(string sectiondesc)
        {
            try
            {
                return GetBySectionDesc(sectiondesc) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IsExistID(string sectioncode)
        {
            try
            {
                return GetByID(sectioncode) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_SECTION record)
        {
            try
            {
                db.SectionList.Add(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_SECTION record)
        {
            try
            {
                var existrecord = GetByID(record.SECTIONCODE);
                db.Entry(existrecord).GetDatabaseValues().SetValues(record);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_SECTION record)
        {
            try
            {
                var existrecord = GetByID(record.SECTIONCODE);
                db.SectionList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
