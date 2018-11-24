using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWCOSTING.BO._000;
using BPSolutionsTools.BPSUtilities;
using BPSolutionsTools;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace PWCOSTING.DAL._000
{
    public class tmp_CompositionDAL
    {
        AppDBContext db;
        SqlConnection con;
        SqlCommand cmd;
        public tmp_CompositionDAL()
        {
            db = new AppDBContext();
        }
        public Boolean Save(List<tbl_tmp_H_ITEM_PART> records)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (BPSUtilitiesV1.NZ(records, "").ToString() != null)
                    {
                        foreach (tbl_tmp_H_ITEM_PART c in records)
                        {
                            db.tmp_ItemPartList.Add(c);
                            db.SaveChanges();
                        }
                    }
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
        }
        public Boolean DistributeCompo(int yearused, string itemno, string user)
        {
            using (TransactionScope tscope = new TransactionScope())
            {
                try
                {
                    string spname = "sp_IsolateImport";
                    using (con = new SqlConnection(Common.ConnectionString))
                    {
                        con.Open();
                        using (cmd = new SqlCommand(spname, con))
                        {
                            var prms = cmd.Parameters;
                            prms.Clear();
                            prms.Add(new SqlParameter("@YEARUSED", yearused));
                            prms.Add(new SqlParameter("@ItemNo", itemno));
                            prms.Add(new SqlParameter("@User", user));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            tscope.Complete();
                        }
                        con.Close();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }   
            }
        }
    }
}
