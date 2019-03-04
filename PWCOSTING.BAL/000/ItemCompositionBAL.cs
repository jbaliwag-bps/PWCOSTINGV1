using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;
namespace PWCOSTING.BAL._000
{
    public class ItemCompositionBAL
    {
        ItemCompositionDAL compdal;
        public ItemCompositionBAL()
        {
            compdal = new ItemCompositionDAL();
        }
        public List<tbl_000_H_ITEM_PART> GetAll()
        {
            try
            {
                return compdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_PART GetByID(long docid)
        {
            try
            {
                var exist = compdal.GetByID(docid);
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM_PART> GetByNo(int yearused, string itemno)
        {
            try
            {
                return compdal.GetByNo(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM_PART GetByName(string name)
        {
            try
            {
                if (name == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = compdal.GetByPartName(name);
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
        public List<tbl_000_H_ITEM_PART> GetByYear(int yearused)
        {
            try
            {
                return compdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetItemNos(int yearused)
        {
            try
            {
                return compdal.GetItemNos(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HashSet<string> GetMoldNos(int yearused, string itemno, string partno)
        {
            try
            {
                return compdal.GetMoldNos(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (compdal.IsExistID(record.DocID))
                {
                    throw new Exception("No. already taken!");
                }
                if (compdal.IsExistPartName(record.PartName))
                {
                    throw new Exception("Name already taken!");
                }
                return compdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return compdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM_PART record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistID(record.DocID))
                {
                    throw new Exception("Record does not exist!");
                }
                return compdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public Boolean Delete(List<tbl_000_H_ITEM_PART> record)
        //{
        //    try
        //    {
        //        foreach (tbl_000_H_ITEM_PART item in record)
        //        {

        //            if (record == null)
        //            {
        //                throw new Exception("Invalid Parameter!");
        //            }
        //            if (!compdal.IsExistID(item.YEARUSED, item.ItemNo, item.PartNo))
        //            {
        //                throw new Exception("Record does not exist!");
        //            }
        //        }
        //        return compdal.Delete(record);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
