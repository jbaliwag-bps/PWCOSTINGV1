using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class SignatoryBAL
    {
        SignatoryDAL signdal;
        public SignatoryBAL()
        {
            signdal = new SignatoryDAL();
        }
        public List<tbl_SIGNATORY> GetAll()
        {
            try
            {
                return signdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_SIGNATORY GetByID(Int64 recid)
        {
            try
            {
                var exist = signdal.GetByID(recid);
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
        public Boolean Save(List<tbl_SIGNATORY> record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return signdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_SIGNATORY> record)
        {
            try
            {
                if(record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return signdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
