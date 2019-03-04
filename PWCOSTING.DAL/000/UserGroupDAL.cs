using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;

namespace PWCOSTING.DAL._000
{
    public class UserGroupDAL : BaseDAL
    {
        public UserGroupDAL()
        {

        }
        public List<tbl_000_USERGROUP> GetAll()
        {
            try
            {
                Renew();
                return db.UserGroupList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_USERGROUP GetByID(string usergroupcode)
        {
            try
            {
                tbl_000_USERGROUP record = new tbl_000_USERGROUP();
                record = db.UserGroupList.Where(m => m.UserGroupCode == usergroupcode).FirstOrDefault();
                record.MenuList = db.UserGroupMenuList.Where(n => n.UserGroupCode == usergroupcode).ToList();
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean CheckID(string usergroupcode)
        {
            try
            {
                return db.UserGroupList.Where(m => m.UserGroupCode == usergroupcode).FirstOrDefault() != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_USERGROUP GetByUserGroupDesc(string usergroupdesc)
        {
            try
            {
                return db.UserGroupList.Where(m => m.UserGroupDesc == usergroupdesc).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistUserGroupDesc(string usergroupdesc)
        {
            try
            {
                return GetByUserGroupDesc(usergroupdesc) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistID(string usergroupcode)
        {
            try
            {
                return CheckID(usergroupcode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_000_USERGROUP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    Renew();
                    db.UserGroupList.Add(record);
                    foreach (var usrgrpmnu in record.MenuList)
                    {
                        InsertSub(usrgrpmnu, record.UserGroupCode);
                    }
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }

        private void InsertSub(tbl_000_USERGROUP_MENUS usrgrpmnu, string usrgrpcode)
        {
            try
            {

                usrgrpmnu.UserGroupCode = usrgrpcode;
                usrgrpmnu.DateCreated = DateTime.Now;
                db.UserGroupMenuList.Add(usrgrpmnu);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_000_USERGROUP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //get new instance of context
                    Renew();
                    tbl_000_USERGROUP existrecord = GetByID(record.UserGroupCode);
                    db.Entry(existrecord).CurrentValues.SetValues(record);
                    List<tbl_000_USERGROUP_MENUS> usermenus = db.UserGroupMenuList.Where(m => m.UserGroupCode == record.UserGroupCode).ToList();
                    //insert new menus
                    foreach (var newmenu in record.MenuList)
                    {
                        if (usermenus.SingleOrDefault(m => m.MenuID == newmenu.MenuID) == null)
                        {
                            InsertSub(newmenu, record.UserGroupCode);
                        }
                    }
                    //edit or remove existing
                    foreach (var existmenu in usermenus)
                    {
                        var newusermenu = record.MenuList.SingleOrDefault(m => m.MenuID == existmenu.MenuID);
                        if (newusermenu != null)
                        {
                            //edit existing
                            db.Entry(existmenu).CurrentValues.SetValues(newusermenu);
                        }
                        else
                        {
                            //remove existing
                            db.UserGroupMenuList.Remove(existmenu);
                        }
                    }
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }

        public Boolean Delete(tbl_000_USERGROUP record)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    Renew();
                    var existrecord = GetByID(record.UserGroupCode);
                    var existmenus = db.UserGroupMenuList.Where(m => m.UserGroupCode == record.UserGroupCode).ToList();
                    db.UserGroupMenuList.RemoveRange(existmenus);
                    db.UserGroupList.Remove(existrecord);
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
