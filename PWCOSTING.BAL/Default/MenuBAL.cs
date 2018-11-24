using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO.Default;
using PWCOSTING.DAL.Default;

namespace PWCOSTING.BAL.Default
{
    public class MenuBAL
    {
        MenuDAL menudal;
        public MenuBAL()
        {
            menudal = new MenuDAL();
        }

        public List<tbl_MENU> GetAll()
        {
            try
            {
                return menudal.GetAll();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tbl_MENU_Search> GetSearchList()
        {
            try
            {
                var list1 = GetAll();
                var list2 = GetAll();
                var list3 = (from l1 in list1
                            join l2 in list2 on l1.ParentMenuID equals l2.MenuID
                            where l1.ParentMenuID != 0
                            select new tbl_MENU_Search() {MenuID =l1.MenuID, MenuName= l1.MenuName, ParentName= l2.MenuName}).ToList<tbl_MENU_Search>();
                return list3;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_MENU GetByID(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = menudal.GetByID(id);
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

        public Boolean Save(tbl_MENU record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (menudal.IsExistID(record.MenuID))
                {
                    throw new Exception("Record already exist!");
                }
                return menudal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_MENU record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!menudal.IsExistID(record.MenuID))
                {
                    throw new Exception("Record does not exist!");
                }
                return menudal.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!menudal.IsExistID(id))
                {
                    throw new Exception("Record does not exist!");
                }
                return menudal.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
