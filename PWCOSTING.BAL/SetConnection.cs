using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.DAL;
using System.Data;

namespace PWCOSTING.BAL
{
    public static class SetBALConnection
    {
        public static void SetConnectionString(string cnstring)
        {
            SetDALConnection.SetConnectionString(cnstring);
            ObjectFactory.Startup();
        }
    }
    public class Manual
    {
        BaseDAL based = new BaseDAL();
        public DataTable SP_dtComponent(string spname, int loginyear) { return based.SP_Dynamic1(spname, loginyear); }
        public DataTable SP_GenerateQuot(string itemno, int loginyear, DateTime _date, string rptname, Decimal hrs) 
        { 
            return based.SP_dtGenerateQuot(itemno, loginyear, _date, rptname, hrs); 
        }
        public DataTable SP_Signatory(string rptname) { return based.SP_Signatory(rptname); }
        public DataTable SP_SMTRaw2017(string itemno, int loginyear) { return based.SP_SMTRaw2017(itemno, loginyear); }
        public DataTable SP_GeneratePriceList(int loginyear, string catcode) { return based.SP_GeneratePriceList(loginyear, catcode); }
        public DataTable SP_GeneratePriceListWDetails(string spname, int loginyear) { return based.SP_Dynamic1(spname, loginyear); }
        public DataTable SP_GenerateVariance(int month, int year) { return based.SP_GenerateVariance(month, year); }
        //WIP
        public DataTable SP_PreviewByWIP(string spname, long recid) 
        {
            return based.SP_PreviewByWIP(spname, recid);
        }
        public DataTable SP_ByWIPSubs(string spname, int loginyear, string itemno, string partno)
        {
            return based.SP_ByWIPSubs(spname, loginyear, itemno, partno);
        }
        public DataTable SP_PreviewAllWIP(string spname, int loginyear)
        {
            return based.SP_Dynamic1(spname, loginyear);
        }
        //
    }
}
