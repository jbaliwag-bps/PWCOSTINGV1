using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemMPTBAL
    {
        ItemMPTDAL itmptdal;
        public ItemMPTBAL()
        {
            itmptdal = new ItemMPTDAL();
        }
        public List<tbl_000_H_ITEM_MPT> GetAll()
        {
            try
            {
                return itmptdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_MPT GetByID(long docid)
        {
            try
            {
                var exist = itmptdal.GetByID(docid);
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
        public List<tbl_000_H_ITEM_MPT> GetByNo(int yearused, string itemno)
        {
            try
            {
                return itmptdal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (itmptdal.IsExistID(record.DocID))
                {
                    throw new Exception("MPT Code already taken!");
                }
                return itmptdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itmptdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itmptdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_MPT record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itmptdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itmptdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}