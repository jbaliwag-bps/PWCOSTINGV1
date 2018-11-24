using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class VacuumPlatingBAL
    {
        VacuumPlatingDAL vpdal;
        public VacuumPlatingBAL()
        {
            vpdal = new VacuumPlatingDAL();
        }
        public List<tbl_000_H_VP> GetAll()
        {
            try
            {
                return vpdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_VP GetByID(int yearused, string partno)
        {
            try
            {
                if (yearused == 0 || partno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = vpdal.GetByID(yearused, partno);
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
        public List<tbl_000_H_VP> GetByNo(int yearused, string partno)
        {
            try
            {
                return vpdal.GetByNo(yearused, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_VP GetByName(int yearused, string partname)
        {
            try
            {
                if (yearused == 0 || partname == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = vpdal.GetByName(yearused, partname);
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
        public List<tbl_000_H_VP> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return vpdal.GetByYear(yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Paramter!");
                }
                if (vpdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("No. already taken!");
                }
                if (vpdal.IsExistName(record.YEARUSED, record.PartName))
                {
                    throw new Exception("Name already taken!");
                }
                return vpdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_VP> record_list)
        {
            try
            {
                if (record_list == null)
                {
                    throw new Exception("Invalid Paramter!");
                }
                return vpdal.Save_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!vpdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return vpdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!vpdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return vpdal.Delete(record);
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
                return vpdal.CopyByYear(yearusedfrom, yearusedto, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
