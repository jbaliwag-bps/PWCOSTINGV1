using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class UserGroupBAL
    {
        private UserGroupDAL compdal;
        public UserGroupBAL()
        {
            compdal = new UserGroupDAL();
        }

        public List<tbl_000_USERGROUP> GetAll()
        {
            try
            {
                return compdal.GetAll();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_USERGROUP GetByID(string usergroupcode)
        {
            try
            {
                if (usergroupcode == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                tbl_000_USERGROUP exist = new tbl_000_USERGROUP();
                exist = compdal.GetByID(usergroupcode);
                if (exist.UserGroupCode == null)
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

        public tbl_000_USERGROUP GetByUserGroupDesc(string usergroupdesc)
        {
            try
            {
                if (usergroupdesc == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                tbl_000_USERGROUP exist = new tbl_000_USERGROUP();
                exist = compdal.GetByUserGroupDesc(usergroupdesc);
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

        public Boolean Save(tbl_000_USERGROUP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (compdal.IsExistUserGroupDesc(record.UserGroupDesc))
                {
                    throw new Exception("Description already taken!");
                }
                if (compdal.IsExistID(record.UserGroupCode))
                {
                    throw new Exception("Code already taken!");
                }
                return compdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_000_USERGROUP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!compdal.IsExistID(record.UserGroupCode))
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

        public Boolean Delete(string strusergroupcode)
        {
            try
            {
                if (strusergroupcode == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistID(strusergroupcode))
                {
                    throw new Exception("Record does not exist!");
                }
                var record = GetByID(strusergroupcode);
                return compdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
