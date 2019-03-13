using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class MODRCBAL
    {
        MODRCDAL mrdal;
        public MODRCBAL()
        {
            mrdal = new MODRCDAL();
        }
        public List<tbl_000_MODRC> GetAll()
        {
            try
            {
                return mrdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_MODRC GetByID(string modrccode)
        {
            try
            {
                if (modrccode == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = mrdal.GetByID(modrccode);
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
        public Boolean Save(tbl_000_MODRC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (mrdal.IsExistDesc(record.Description))
                {
                    throw new Exception("Description already taken!");
                }
                if (mrdal.IsExistID(record.MODRCCode))
                {
                    throw new Exception("Code already taken!");
                }
                return mrdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_MODRC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!mrdal.IsExistID(record.MODRCCode))
                {
                    throw new Exception("Record does not exist!");
                }
                return mrdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_MODRC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!mrdal.IsExistID(record.MODRCCode))
                {
                    throw new Exception("Record does not exist!");
                }
                return mrdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
