using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;
using PWCOSTING.DAL.Default;

namespace PWCOSTING.BAL._000
{
    public class CompanyBAL
    {
        CompanyDAL compdal;
        YearDAL yeardal;
        public CompanyBAL()
        {
            compdal = new CompanyDAL();
            yeardal = new YearDAL();
        }

        public List<tbl_000_COMPANY> GetAll()
        {
            try
            {
                return compdal.GetAll();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_COMPANY GetByID(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = compdal.GetByID(id);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                exist.YearList = yeardal.GetAll();
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_000_COMPANY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (compdal.IsExistID(record.ID))
                {
                    throw new Exception("Record already exist!");
                }
                return compdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_000_COMPANY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!compdal.IsExistID(record.ID))
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

        public Boolean Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistID(id))
                {
                    throw new Exception("Record does not exist!");
                }
                return compdal.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
