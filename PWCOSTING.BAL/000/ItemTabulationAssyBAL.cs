using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemTabulationAssyBAL
    {
        ItemTabulationAssyDAL itassydal;
        public ItemTabulationAssyBAL()
        {
            itassydal = new ItemTabulationAssyDAL();
        }
        public List<tbl_000_H_ITEM_TABULATION_ASSY> GetAll()
        {
            try
            {
                return itassydal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_ASSY GetByID(long docid)
        {
            try
            {
                var exist = itassydal.GetByID(docid);
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
        public List<tbl_000_H_ITEM_TABULATION_ASSY> GetByNo(int yearused, string itemno)
        {
            try
            {
                return itassydal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_ASSY GetByName(string name)
        {
            try
            {
                if (name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = itassydal.GetByPartName(name);
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
        public Boolean Save(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (itassydal.IsExistID(record.DocID))
                {
                    throw new Exception("Assy No. already taken!");
                }
                if (itassydal.IsExistPartName(record.PartName))
                {
                    throw new Exception(" Assy Name already taken!");
                }
                return itassydal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itassydal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itassydal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_TABULATION_ASSY record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itassydal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itassydal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}