using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;

namespace PWCOSTING.DAL._000
{
    public class UserDAL : BaseDAL
    {
        private const string _passwordprefix = "@123bps";
        public UserDAL()
        {
        }

        public tbl_000_USER LogMeIn(string _username, string _password)
        {
            try
            {
                var _user = GetByUsername(_username);
                if (_user != null)
                {
                    if (!_user.IsActive)
                    {
                        throw new Exception("This account has been deactivated!");
                    }
                    var _enc_pass = ComputePassword(_password, Convert.ToDateTime(_user.DateCreated));
                    if (_user.Password.Equals(_enc_pass))
                    {
                        return _user;
                    }
                    throw new Exception("Password is incorrect!");
                }
                else
                {
                    throw new Exception("Username doesn't exist!");
                }
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
                Renew();
                return db.UserList.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_000_USER GetByID(string id)
        {
            try
            {
                return db.UserList.Where(m => m.UserID == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbl_000_USER GetByUsername(string username)
        {
            try
            {
                Renew();
                tbl_000_USER record = db.UserList.Where(m => m.Username == username).FirstOrDefault();
                if (record != null)
                {
                    record.UserGroup = db.UserGroupList.Where(n => n.UserGroupCode == record.UserGroupCode).FirstOrDefault();
                    record.UserGroup.MenuList = db.UserGroupMenuList.Where(o => o.UserGroupCode == record.UserGroupCode).ToList();
                    record.MenuList = db.MenuList.ToList();
                }
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistUsername(string username)
        {
            try
            {
                return GetByUsername(username) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsExistID(string userid)
        {
            try
            {
                return GetByID(userid) != null;
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
                Renew();
                record.Password = ComputePassword(record.Password, Convert.ToDateTime(record.DateCreated));
                db.UserList.Add(record);
                db.SaveChanges();
                return true;
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
                Renew();
                var existrecord = GetByUsername(record.Username);
                record.Password = ComputePassword(record.Password, Convert.ToDateTime(record.DateCreated));
                db.Entry(existrecord).CurrentValues.SetValues(record);
                db.SaveChanges();
                return true;
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
                Renew();
                var existrecord = GetByUsername(record.Username);
                db.UserList.Remove(existrecord);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ComputePassword(string Password, DateTime DateCreated)
        {
            if (Password != null)
            {
                var datenumber = DateCreated.Month.ToString() + DateCreated.Day.ToString() + DateCreated.Year.ToString();
                var newpass = _passwordprefix + Password + datenumber;
                newpass = BPSSecurity.Encrypt(newpass);
                return newpass;
            }
            return "";
        }

        public string BreakPassword(string Password, DateTime DateCreated)
        {
            if (Password != null)
            {
                var datenumber = DateCreated.Month.ToString() + DateCreated.Day.ToString() + DateCreated.Year.ToString();
                var pass = BPSSecurity.Decrypt(Password);
                //remove the prefix string;                
                pass = pass.Substring(_passwordprefix.Length, pass.Length - _passwordprefix.Length);
                //remove the suffix string;
                pass = pass.Substring(0, pass.Length - datenumber.Length);
                return pass;
            }
            return "";
        }
    }
}
