using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._100;
using PWCOSTING.DAL._100;

namespace PWCOSTING.BAL._100
{
    public class WIPBAL
    {
        WIPDAL wipdal;
        WIPMaterialsDAL wipmatdal;
        public WIPBAL()
        {
            wipdal = new WIPDAL();
            wipmatdal = new WIPMaterialsDAL();
        }
        public List<tbl_100_WIP> GetAll()
        {
            try
            {
                return wipdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_100_WIP> GetByYear(int yearused)
        {
            try
            {
                return wipdal.GetByYear(yearused);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_100_WIP GetByRecID(long recid)
        {
            try
            {
                return wipdal.GetByRecID(recid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Sub
        private tbl_100_WIP GetSubDatas(int yearused, string itemno, string partno, tbl_100_WIP exist)
        {
            exist.WIPMaterials = wipmatdal.GetByNo(yearused, itemno, partno);

            return exist;
        }
        public tbl_100_WIP GetByID(int yearused, string itemno, string partno)
        {
            try
            {
                if(itemno == null || partno == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                var exist = wipdal.GetByID(yearused, itemno, partno);
                if (exist != null)
                {
                    exist = GetSubDatas(yearused, itemno, partno, exist);
                }
                return GetByID(yearused, itemno, partno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Save(tbl_100_WIP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipdal.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(tbl_100_WIP record)
        {
            try
            {
                if (record == null)
                {
                    throw new Exception("Invalid Parameter!");
                }
                return wipdal.Delete(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
