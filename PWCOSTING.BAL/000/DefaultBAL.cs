using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class DefaultBAL
    {
        DefaultDAL defdal;
        public DefaultBAL()
        {
            defdal = new DefaultDAL();
        }
        public List<tbl_DEFAULT> GetAll()
        {
            try
            {
                return defdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
