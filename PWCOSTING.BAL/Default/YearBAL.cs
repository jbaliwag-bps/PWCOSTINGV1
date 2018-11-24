using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO.Default;
using PWCOSTING.BO._000;
using PWCOSTING.DAL.Default;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL.Default
{
    public class YearBAL
    {
        YearDAL Yeardal;
        public YearBAL()
        {
            Yeardal = new YearDAL();
        }

        public List<tbl_YEAR> GetAll()
        {
            try
            {
                return Yeardal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public tbl_YEAR GetByYear(int RecYear)
        {
            try
            {
                if (RecYear == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = Yeardal.GetByYear(RecYear);
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

        public Boolean Save(tbl_YEAR record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (Yeardal.IsExistID(record.RecYear))
                {
                    throw new Exception("Record already exist!");
                }
                return Yeardal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_YEAR record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!Yeardal.IsExistID(record.RecYear))
                {
                    throw new Exception("Record does not exist!");
                }
                return Yeardal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Delete(int RecYear)
        {
            try
            {
                if (RecYear == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!Yeardal.IsExistID(RecYear))
                {
                    throw new Exception("Record does not exist!");
                }
                return Yeardal.Delete(RecYear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Lock(tbl_YEAR record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!Yeardal.IsExistID(record.RecYear))
                {
                    throw new Exception("Record does not exist!");
                }
                return Yeardal.Lock(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_FXSP CheckFXSPYear(int RecYear)
        {
            try
            {
                try
                {
                    if (RecYear == 0)
                    {
                        throw new Exception("Invalid Parameter!");
                    }
                    var exist = Yeardal.CheckFXSPYear(RecYear);
                    if (exist != null)
                    {
                        throw new Exception("Record in use!");
                    }
                    return exist;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_CATEGORY CheckCatYear(int RecYear)
        {
            try
            {
                try
                {
                    if (RecYear == 0)
                    {
                        throw new Exception("Invalid Parameter!");
                    }
                    var exist = Yeardal.CheckCatYear(RecYear);
                    if (exist != null)
                    {
                        throw new Exception("Record in use!");
                    }
                    return exist;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Remove(int RecYear)
        {
            try
            {
                if (RecYear == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!Yeardal.IsExistID(RecYear))
                {
                    throw new Exception("Record does not exist!");
                }
                return Yeardal.Remove(RecYear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
