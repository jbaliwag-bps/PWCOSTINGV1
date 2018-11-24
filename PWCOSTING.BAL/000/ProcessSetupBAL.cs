using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ProcessSetupBAL
    {
        ProcessSetupDAL procdal;
        public ProcessSetupBAL()
        {
            procdal = new ProcessSetupDAL();
        }
        public List<tbl_000_PROCESS> GetAll()
        {
            try
            {
                return procdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_PROCESS GetByID(int yearused, string subprocesscode)
        {
            try
            {
                if (yearused == 0 || subprocesscode == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = procdal.GetByID(yearused, subprocesscode);
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
        public List<tbl_000_PROCESS> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return procdal.GetByYear(yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(List<tbl_000_PROCESS> records)
        {
            try
            {
               if (records.Count == 0)
               {
                   throw new Exception("Invalid Paramater!");
               }
                return procdal.Save(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(List<tbl_000_PROCESS> records)
        {
            try
            {
                if (records.Count == 0)
                {
                    throw new Exception("Invalid Paramater!");
                }
                return procdal.Update(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(List<tbl_000_PROCESS> records)
        {
            try
            {
                if (records.Count == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return procdal.Delete(records);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                return procdal.CopyByYear(yearusedfrom, yearusedto, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
