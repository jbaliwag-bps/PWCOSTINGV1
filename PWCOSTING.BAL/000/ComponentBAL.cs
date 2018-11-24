using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ComponentBAL
    {
        ComponentDAL comdal;
        public ComponentBAL()
        {
            comdal = new ComponentDAL();
        }
        public List<tbl_000_H_PART> GetAll()
        {
            try
            {
                return comdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PART GetByID(int yearused, string partno)
        {
            try
            {
                if (yearused == 0 || partno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = comdal.GetByID(yearused, partno);
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
        public List<tbl_000_H_PART> GetByNo(int yearused, string partno)
        {
            try
            {
                return comdal.GetByNo(yearused, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PART GetByName(int yearused, string name)
        {
            try
            {
                if (yearused == 0 || name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = comdal.GetByName(yearused, name);
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
        public List<tbl_000_H_PART> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return comdal.GetByYear(yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (comdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("No. already taken!");
                }
                if (comdal.IsExistName(record.YEARUSED, record.PartName))
                {
                    throw new Exception("Name already taken!");
                }
                return comdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_PART> record_list)
        {
            try
            {
                if (record_list == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return comdal.Save_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!comdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return comdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!comdal.IsExistID(record.YEARUSED, record.PartNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return comdal.Delete(record);
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
                return comdal.CopyByYear(yearusedfrom, yearusedto, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
