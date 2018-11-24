using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemFDCBAL
    {
        ItemFDCDAL itfdcdal;
        public ItemFDCBAL()
        {
            itfdcdal = new ItemFDCDAL();
        }
        public List<tbl_000_H_ITEM_FDC> GetAll()
        {
            try
            {
                return itfdcdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_FDC GetByID(int yearused, string itemno, string depntype)
        {
            try
            {
                //if (yearused == 0 || itemno == null || depntype == null)
                //{
                //    throw new Exception("Invalid Parameter!");
                //}
                var exist = itfdcdal.GetByID(yearused, itemno, depntype);
                //if (exist == null)
                //{
                //    throw new Exception("Record does not exist!");
                //}
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_FDC> GetByNo(int yearused, string itemno)
        {
            try
            {
                return itfdcdal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_FDC GetByDesc(string name)
        {
            try
            {
                if (name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = itfdcdal.GetByDesc(name);
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
        public Boolean Save(tbl_000_H_ITEM_FDC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (itfdcdal.IsExistID(record.YEARUSED, record.ItemNo, record.DepnType))
                {
                    throw new Exception("MPT No. already taken!");
                }
                if (itfdcdal.IsExistDesc(record.Description))
                {
                    throw new Exception("MPT Name already taken!");
                }
                return itfdcdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_FDC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itfdcdal.IsExistID(record.YEARUSED, record.ItemNo, record.DepnType))
                {
                    throw new Exception("Record does not exist!");
                }
                return itfdcdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_FDC record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itfdcdal.IsExistID(record.YEARUSED, record.ItemNo, record.DepnType))
                {
                    throw new Exception("Record does not exist!");
                }
                return itfdcdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}