using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using PWCOSTING.DAL._000;

namespace PWCOSTING.BAL._000
{
    public class tmp_StndrdCostngSummBAL
    {
        tmp_StndrdCostngSummDAL tmpSCsummdal;
        public tmp_StndrdCostngSummBAL()
        {
            tmpSCsummdal = new tmp_StndrdCostngSummDAL();
        }
        public List<tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY> GetAll()
        {
            try
            {
                return tmpSCsummdal.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
