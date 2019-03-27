using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;


namespace PWCOSTING.BAL._100
{
    public class WIPMaterialsBAL
    {
        WIPMaterialsDAL wipmatdal;
        public WIPMaterialsBAL()
        {
            wipmatdal = new WIPMaterialsDAL();
        }
        public List<tbl_100_WIP_Materials> GetAll()
        {
            try
            {
                return wipmatdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP_Materials> GetByNo(int yearused, string itemno, string partno)
        {
            try
            {
                if (itemno == null || partno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipmatdal.GetByNo(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP_Materials GetByRecID(long recid)
        {
            try
            {
                return wipmatdal.GetByRecID(recid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
