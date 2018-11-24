using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class UserBAL
    {
        UserDAL compdal;
        public UserBAL()
        {
            compdal = new UserDAL();
        }

        public tbl_000_USER LogMeIn(string _username, string _password)
        {
            try
            {
                if (_username == null || _password == null)
                {
                    throw new Exception("Invalid Parameters!");
                }
                return compdal.LogMeIn(_username, _password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbl_000_USER> GetAll()
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
        public tbl_000_USER GetByID(string UserID, Boolean IsEncrypted = false)
        {
            try
            {
                if (UserID == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = compdal.GetByID(UserID);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                if (!IsEncrypted)
                {
                    exist.Password = compdal.BreakPassword(exist.Password, Convert.ToDateTime(exist.DateCreated));
                }
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_USER GetByUsername(string username, Boolean IsEncrypted = false)
        {
            try
            {
                if (username == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                tbl_000_USER exist = new tbl_000_USER();
                exist = compdal.GetByUsername(username);
                if (exist == null)
                {
                    throw new Exception("Record does not exist!");
                }
                if (!IsEncrypted)
                {
                    exist.Password = compdal.BreakPassword(exist.Password, Convert.ToDateTime(exist.DateCreated));
                }
                return exist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Save(tbl_000_USER record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (compdal.IsExistUsername(record.Username))
                {
                    throw new Exception("Record already exist!");
                }
                return compdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Update(tbl_000_USER record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter");
                }
                if (!compdal.IsExistUsername(record.Username))
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

        public Boolean Delete(tbl_000_USER record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                if (!compdal.IsExistUsername(record.Username))
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

        //public string ComputePassword(string unencryptedPassword, DateTime dateCreated)
        //{
        //    try
        //    {
        //        if (unencryptedPassword == null)
        //        {
        //            throw new Exception("Invalid Parameter");
        //        }
        //        return compdal.ComputePassword(unencryptedPassword, dateCreated);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public string BreakPassword(string encryptedPassword, DateTime dateCreated)
        //{
        //    try
        //    {
        //        if (encryptedPassword == null)
        //        {
        //            throw new Exception("Invalid Parameter");
        //        }
        //        return compdal.BreakPassword(encryptedPassword, dateCreated);
        //    }catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
