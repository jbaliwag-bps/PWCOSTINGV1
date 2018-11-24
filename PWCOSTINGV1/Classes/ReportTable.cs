using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PWCOSTINGV1.Classes
{
    public class ReportTable
    {
        public ReportDocument _ReportDoc = new ReportDocument();
        public DataTable _SourceTable = new DataTable();
        public DateTime _DocDate = DateTime.Now;

        public string _ReportName = "";
        public string _ReportPath = "";

        public DataTable _SubDataSources1 = new DataTable();
        public DataTable _SubDataSources2 = new DataTable();

        public string ReportName { get { return _ReportName; } set { _ReportName = value; } }
        public DataTable SourceTable { get { return _SourceTable; } set { _SourceTable = value; } }
        public string ReportPath { get { return _ReportPath; } set { _ReportPath = value; } }
        public ReportDocument ReportDoc { get { return _ReportDoc; } }

        //For SubReports
        public DataTable SubDataSources { get { return _SubDataSources1; } set { _SubDataSources1 = value; } }
        public DataTable SubDataSources1 { get { return _SubDataSources2; } set { _SubDataSources2 = value; } }
        public void New()
        {
            _ReportDoc = new ReportDocument();
        }

    }
}
