﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PWCOSTING.DAL
{
    public class BaseDAL
    {
        public AppDBContext db { get; set; }
        DataTable dttemp;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public BaseDAL()
        {
            db = ObjectFactory.GetContainer().GetInstance<AppDBContext>();
        }

        public void Renew()
        {
            db = ObjectFactory.GetContainer().GetInstance<AppDBContext>();
        }
        //Components & PriceList with Details
        public DataTable SP_Dynamic1(string spname, int loginyear)
        {
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@YEARUSED", loginyear));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
        //Generate /Quotation
        public DataTable SP_dtGenerateQuot(string itemno, int loginyear, DateTime _date, string rptname, Decimal hrs)
        {
            string spname = "sp_GenerateQuotation";
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@YEARUSED", loginyear));
                    prms.Add(new SqlParameter("@ItemNo", itemno));
                    prms.Add(new SqlParameter("@Date", _date));
                    prms.Add(new SqlParameter("@ReportName", rptname));
                    prms.Add(new SqlParameter("@MPTHrs", hrs));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
        public DataTable SP_Signatory(string rptname)
        {
            string spname = "sp_Signatory";
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@ReportName", rptname));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
        public DataTable SP_SMTRaw2017(string itemno, int loginyear)
        {
            string spname = "sp_SMTRaw2017";
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@YEARUSED", loginyear));
                    prms.Add(new SqlParameter("@ItemNo", itemno));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
        public DataTable SP_GeneratePriceList(int loginyear, string catcode)
        {
            string spname = "sp_GeneratePriceList";
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@YEARUSED", loginyear));
                    prms.Add(new SqlParameter("@CATCODE", catcode));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
        public DataTable SP_GenerateVariance(int month, int year)
        {
            string spname = "sp_GenerateVariance";
            dttemp = new DataTable();
            using (con = new SqlConnection(Common.ConnectionString))
            {
                con.Open();
                using (cmd = new SqlCommand(spname, con))
                {
                    var prms = cmd.Parameters;
                    prms.Clear();
                    prms.Add(new SqlParameter("@Month", month));
                    prms.Add(new SqlParameter("@YEAR", year));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dttemp);
                }
                con.Close();
            }
            return dttemp;
        }
    }
}