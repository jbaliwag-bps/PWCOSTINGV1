using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO.Default;

namespace PWCOSTING.DAL.Default
{
    public class MenuDAL
    {
        AppDBContext db;
        public MenuDAL()
        {
            db = new AppDBContext();
        }

        public List<tbl_MENU> GetAll()
        {
            try
            {
                return db.MenuList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_MENU GetByID(int MenuID)
        {
            try
            {
                return db.MenuList.Where(m => m.MenuID == MenuID).FirstOrDefault();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistID(int MenuID)
        {
            try
            {                
                return GetByID(MenuID) != null;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_MENU record)
        {
            try
            {
                db.MenuList.Add(record);
                db.SaveChanges();
                return true;
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
                var existrecord = GetByID(record.MenuID);               
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Delete(int MenuID)
        {
            try
            {               
                var existrecord = GetByID(MenuID);                
                db.MenuList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
