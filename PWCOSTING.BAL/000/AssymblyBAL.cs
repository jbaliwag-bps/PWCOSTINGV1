using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class AssymblyBAL
    {
        AssymblyDAL assydal;
        public AssymblyBAL()
        {
            assydal = new AssymblyDAL();
        }
        public List<tbl_000_H_ASSY> GetAll()
        {
            try
            {
                return assydal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ASSY GetByID(int yearused, string partno)
        {
            try
            {
                if (yearused == 0 || partno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = assydal.GetByID(yearused, partno);
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
        public List<tbl_000_H_ASSY> GetByNo(int yearused, string partno)
        {
            try
            {
                return assydal.GetByNo(yearused, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ASSY GetByName(int yearused, string partname)
        {
            try
            {
                if (yearused == 0 || partname == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = assydal.GetByName(yearused, partname);
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
        public List<tbl_000_H_ASSY> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return assydal.GetByYear(yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Paramter!");
                }
                if (assydal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("No. already taken!");
                }
                if (assydal.IsExistName(record.YEARUSED, record.PartName))
                {
                    throw new Exception("Name already taken!");
                }
                return assydal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_ASSY> record_list)
        {
            try
            {
                if (record_list == null)
                {
                    throw new Exception("Invalid Paramter!");
                }
                return assydal.Save_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!assydal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return assydal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!assydal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return assydal.Delete(record);
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
                return assydal.CopyByYear(yearusedfrom, yearusedto, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
