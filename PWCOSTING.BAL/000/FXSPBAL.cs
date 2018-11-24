using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class FXSPBAL
    {
        FXSPDAL fxspdal;
        public FXSPBAL(){
            fxspdal = new FXSPDAL();
        }
        public List<tbl_000_FXSP> GetAll()
        {
            try
            {
                return fxspdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_FXSP GetByID(string rectype, DateTime effectivedate)
        {
            try
            {
                if (rectype == null || effectivedate == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = fxspdal.GetByID(rectype, effectivedate);
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
        public tbl_000_FXSP GetByType(string rectype)
        {
            try
            {
                if (rectype == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = fxspdal.GetByType(rectype);
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
        public Boolean Save(tbl_000_FXSP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                //if (fxspdal.IsExistType(record.RecType))
                //{
                //    throw new Exception("Type already taken!");
                //}
                if (fxspdal.IsExistID(record.RecType, record.EffectiveDate))
                {
                    throw new Exception("ID already taken!");
                }
                return fxspdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_FXSP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!fxspdal.IsExistID(record.RecType, record.EffectiveDate))
                {
                    throw new Exception("Record does not exist!");
                }
                return fxspdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_FXSP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!fxspdal.IsExistID(record.RecType, record.EffectiveDate))
                {
                    throw new Exception("Record does not exist!");
                }
                return fxspdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
