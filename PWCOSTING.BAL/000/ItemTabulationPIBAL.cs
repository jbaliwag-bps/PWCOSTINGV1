using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemTabulationPIBAL
    {
        ItemTabulationPIDAL itpidal;
        public ItemTabulationPIBAL()
        {
            itpidal = new ItemTabulationPIDAL();
        }
        public List<tbl_000_H_ITEM_TABULATION> GetAll()
        {
            try
            {
                return itpidal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION GetByID(long docid)
        {
            try
            {
                var exist = itpidal.GetByID(docid);
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
        public List<tbl_000_H_ITEM_TABULATION> GetByNo(int yearused, string itemno)
        {
            try
            {
                return itpidal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION GetByName(string name)
        {
            try
            {
                if (name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = itpidal.GetByPartName(name);
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
        public Boolean Save(tbl_000_H_ITEM_TABULATION record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (itpidal.IsExistID(record.DocID))
                {
                    throw new Exception("PI No. already taken!");
                }
                if (itpidal.IsExistPartName(record.PartName))
                {
                    throw new Exception("PI Name already taken!");
                }
                return itpidal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_TABULATION record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itpidal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itpidal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_TABULATION record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itpidal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itpidal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
