using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class SectionBAL
    {
        SectionDAL compdal;
        public SectionBAL()
        {
            compdal = new SectionDAL();
        }

        public List<tbl_000_SECTION> GetAll()
        {
            try
            {
                return compdal.GetAll();
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
                if (sectioncode == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = compdal.GetByID(sectioncode);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                return exist;
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
                return compdal.GetByNo(sectioncode);
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
                if (sectiondesc == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = compdal.GetBySectionDesc(sectiondesc);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                return exist;
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
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (compdal.IsExistSectionDesc(record.SECTIONDESC))
                {
                    throw new Exception("Description already taken!");
                }
                if (compdal.IsExistID(record.SECTIONCODE))
                {
                    throw new Exception("Code already taken!");
                }
                return compdal.Save(record);
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
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!compdal.IsExistID(record.SECTIONCODE))
                {
                    throw new Exception("Record does not exist!");
                }
                return compdal.Update(record);
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
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistID(record.SECTIONCODE))
                {
                    throw new Exception("Record does not exist!");
                }
                return compdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
