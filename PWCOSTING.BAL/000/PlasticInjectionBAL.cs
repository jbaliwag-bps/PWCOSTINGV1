using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class PlasticInjectionBAL
    {
        PlasticInjectionDAL pidal;
        public PlasticInjectionBAL()
        {
            pidal = new PlasticInjectionDAL();
        }
        public List<tbl_000_H_PI> GetAll()
        {
            try
            {
                return pidal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PI GetByID(int yearused, string moldno)
        {
            try
            {
                if (yearused == 0 || moldno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = pidal.GetByID(yearused, moldno);
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
        public List<tbl_000_H_PI> GetByNo(int yearused, string moldno)
        {
            try
            {
                return pidal.GetByNo(yearused, moldno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_PI GetByName(int yearused, string moldname)
        {
            try
            {
                if (yearused == 0 || moldname == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = pidal.GetByName(yearused, moldname);
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
        public List<tbl_000_H_PI> GetByYear(int yearused)
        {
            try
            {
                if (yearused == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return pidal.GetByYear(yearused).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_PI record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Paramter!");
                }
                if (pidal.IsExistID(record.YEARUSED, record.MoldNo))
                {
                    throw new Exception("No. already taken!");

                }
                if (pidal.IsExistName(record.YEARUSED, record.MoldName))
                {
                    throw new Exception("Name already taken!");
                }
                return pidal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_PI> record_list)
        {
            try
            {
                if (record_list == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return pidal.Save_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_PI record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!pidal.IsExistID(record.YEARUSED, record.MoldNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return pidal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_PI record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!pidal.IsExistID(record.YEARUSED, record.MoldNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return pidal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteAll(tbl_000_H_PI record)
        {
            try
            {
                return pidal.DeleteAll(record);
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
                return pidal.CopyByYear(yearusedfrom, yearusedto, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
