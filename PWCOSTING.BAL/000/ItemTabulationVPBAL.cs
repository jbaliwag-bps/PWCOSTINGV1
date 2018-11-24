using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemTabulationVPBAL
    {
        ItemTabulationVPDAL itvpdal;
        public ItemTabulationVPBAL()
        {
            itvpdal = new ItemTabulationVPDAL();
        }
        public List<tbl_000_H_ITEM_TABULATION_VP> GetAll()
        {
            try
            {
                return itvpdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_VP GetByID(long docid)
        {
            try
            {
                var exist = itvpdal.GetByID(docid);
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
        public List<tbl_000_H_ITEM_TABULATION_VP> GetByNo(int yearused, string itemno)
        {
            try
            {
                return itvpdal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_TABULATION_VP GetByName(string name)
        {
            try
            {
                if (name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = itvpdal.GetByPartName(name);
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
        public Boolean Save(tbl_000_H_ITEM_TABULATION_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (itvpdal.IsExistID(record.DocID))
                {
                    throw new Exception("VP No. already taken!");
                }
                if (itvpdal.IsExistPartName(record.PartName))
                {
                    throw new Exception(" VP Name already taken!");
                }
                return itvpdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_TABULATION_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itvpdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itvpdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_TABULATION_VP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itvpdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return itvpdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}