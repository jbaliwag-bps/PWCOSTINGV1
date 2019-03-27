using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class ItemBAL
    {
        ItemDAL itemdal;
        ItemCompositionDAL itemcomdal;
        ItemTabulationPIDAL itemPIdal;
        ItemTabulationVPDAL itemVPdal;
        ItemTabulationAssyDAL itemAssydal;
        ItemMPTDAL itemMPTdal;
        ItemFDCDAL itemFDCdal;

        public ItemBAL()
        {
            itemdal = new ItemDAL();
            itemcomdal = new ItemCompositionDAL();
            itemPIdal = new ItemTabulationPIDAL();
            itemVPdal = new ItemTabulationVPDAL();
            itemAssydal = new ItemTabulationAssyDAL();
            itemMPTdal = new ItemMPTDAL();
            itemFDCdal = new ItemFDCDAL();
        }

        public List<tbl_000_H_ITEM> GetAll()
        {
            try
            {
                return itemdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private tbl_000_H_ITEM GetSubDatas(int yearused, string itemno, tbl_000_H_ITEM exist)
        {
            exist.itemCom = itemcomdal.GetByNo(yearused, itemno);
            exist.itemPI = itemPIdal.GetByNo(yearused, itemno);
            exist.itemVP = itemVPdal.GetByNo(yearused, itemno);
            exist.itemAssy = itemAssydal.GetByNo(yearused, itemno);
            exist.itemMPT = itemMPTdal.GetByNo(yearused, itemno);
            exist.itemFDC = itemFDCdal.GetByNo(yearused, itemno);

            return exist;
        }
        public tbl_000_H_ITEM GetByID(int yearused, string itemno)
        {
            try
            {
                var exist = itemdal.GetByID(yearused, itemno);
                if (exist != null)
                {
                    exist = GetSubDatas(exist.YEARUSED, exist.ItemNo, exist);
                }
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM GetWithCat(int yearused, string itemno, string catcode)
        {
            try
            {
                var exist = itemdal.GetByYear(yearused).Where(w => w.ItemNo == itemno && w.CatCode == catcode).FirstOrDefault();
                if (exist != null)
                {
                    exist = GetSubDatas(exist.YEARUSED, exist.ItemNo, exist);
                }
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_000_H_ITEM> GetByYear(int yearused)
        {
            try
            {
                return itemdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_H_ITEM GetByItemDesc(int yearused, string itemdesc)
        {
            try
            {
                if (itemdesc == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = itemdal.GetByItemDesc(yearused, itemdesc);
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
        public HashSet<string> GetAllItemNos()
        {
            try
            {
                return itemdal.GetAllItemNos();
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
                return itemdal.GetItemNos(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_000_H_ITEM record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (itemdal.IsExistItemDesc(record.YEARUSED, record.Description))
                {
                    throw new Exception("Description already taken!");
                }
                if (itemdal.IsExistID(record.YEARUSED, record.ItemNo))
                {
                    throw new Exception("Code already taken!");
                }
                return itemdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save_List(List<tbl_000_H_ITEM> record_list)
        {
            try
            {
                if (record_list == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return itemdal.Save_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Update(tbl_000_H_ITEM record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!itemdal.IsExistID(record.YEARUSED, record.ItemNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return itemdal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_000_H_ITEM record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!itemdal.IsExistID(record.YEARUSED, record.ItemNo))
                {
                    throw new Exception("Record does not exist!");
                }
                return itemdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete_List(List<tbl_000_H_ITEM> record_list)
        {
            try
            {
                return itemdal.Delete_List(record_list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyByItem(int yearusedfrom, int yearusedto, string itemno, string user, Boolean IsOverwrite)
        {
            try
            {
                var exist = GetByID(yearusedto, itemno);
                if (!IsOverwrite)
                {
                    if (exist != null)
                    {
                        throw new Exception("Record already exists!");
                    }
                }
                return itemdal.CopyByItem(yearusedfrom, yearusedto, itemno, user, IsOverwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean CopyItemByYear(int yearusedfrom, int yearusedto, string user, Boolean IsOverwrite)
        {
            try
            {
                return itemdal.CopyItemByYear(yearusedfrom, yearusedto, user, IsOverwrite); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean QuoteItem(int yearused, string itemno)
        {
            try
            {
                return itemdal.QuoteItem(yearused, itemno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
