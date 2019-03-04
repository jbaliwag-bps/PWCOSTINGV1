using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using BPSolutionsTools;
using System.Data;
namespace PWCOSTINGV1.Classes
{
    public class Grid
    {
        public static void UniqueRow(DataGridView dgv, string cellname)
        {
            try
            {
                string initialnamevalue = dgv.Rows[0].Cells[cellname].Value.ToString();
                for (int i = 1; i < dgv.Rows.Count; i++)
                {
                    if (BPSUtilitiesV1.NZ(dgv.Rows[i].Cells[cellname].Value, "").ToString() == initialnamevalue)
                    {
                        dgv.Rows.RemoveAt(i);
                    }
                    else
                        initialnamevalue = BPSUtilitiesV1.NZ(dgv.Rows[i].Cells[cellname].Value, "").ToString();
                }
            }
            catch
            {

            }
        }
        //For Paging
        public static DataTable Pager(DataGridView dgv, long _take, int _skip)
        {
            DataTable cloneDataTable = new DataTable();
            try
            {
                if (_skip != 1)
                    _skip = Convert.ToInt32((_skip - 1) * _take);
                else _skip = 0;

                DataTable _DataTable = (dgv.DataSource as DataTable).AsEnumerable().Skip(_skip).CopyToDataTable();
                cloneDataTable = _DataTable.Clone();
                for (int i = 0; i < _take; i++)
                {
                    cloneDataTable.ImportRow(_DataTable.Rows[i]);
                }
            }
            catch
            {

            }
            return cloneDataTable;
        }

        //For searching record
        public static DataTable PageRandom(DataGridView dgv, long _take, string strtosearch, string tosearch1, string tosearch2)
       {
           DataTable cloneDataTable = new DataTable();
           try
           {
               DataTable dt = new DataTable();
               DataView dv = ((DataTable)dgv.DataSource).DefaultView;
               dv.RowFilter = string.Format(tosearch1 + " LIKE '%{0}%' or " + tosearch2 + " LIKE '%{0}%'", BPSolutionsTools.BPSUtilitiesV1.NZ(strtosearch, ""));
               dt = dv.ToTable();
               cloneDataTable = dt.Clone();

               if (dt.Rows.Count < _take)
               {
                   _take = dt.Rows.Count;
               }
               for (int i = 0; i < _take; i++)
               {
                   cloneDataTable.ImportRow(dt.Rows[i]);
               }
               var test = cloneDataTable.Rows.Count;
           }
           catch
           {

           }
           return cloneDataTable;
        }
        public static void tsButtonManager(ToolStrip ts, bool isLocked)
        {
            try
            {
                var items = ts.Items;
                foreach (ToolStripButton tsbtn in items.OfType<ToolStripButton>().AsEnumerable())
                {
                    if (tsbtn.Name.Contains("_"))
                    {
                        tsbtn.Enabled = !isLocked;
                    }
                }
            }
            catch
            {

            }
        }
        public static void ListCheck(DataGridView dgv, ToolStrip ts)
        {
            try
            {
                bool isLocked = true;
                if (dgv.RowCount > 0)
                {
                    dgv.Rows[0].Cells[1].Selected = true;
                    isLocked = false;
                }
                //Disable the tsbutton if the grid contains no row(s)
                tsButtonManager(ts, isLocked);
            }
            catch
            {

            }
        }
    }
}
