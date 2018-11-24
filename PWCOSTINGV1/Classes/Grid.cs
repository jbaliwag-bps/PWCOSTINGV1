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

        public static DataTable Pager(DataGridView dgv, long _take, int _skip)
        {
            if (_skip != 1)
                _skip = Convert.ToInt32((_skip - 1) * _take);
            else _skip = 0;

            DataTable _DataTable = (dgv.DataSource as DataTable).AsEnumerable().Skip(_skip).CopyToDataTable();
            DataTable cloneDataTable = _DataTable.Clone();
            for (int i = 0; i < _take; i++)
            {
                cloneDataTable.ImportRow(_DataTable.Rows[i]);
            }
            return cloneDataTable;
        }

        public static DataTable PageRandom(DataGridView dgv, long _take, string strtosearch, string tosearch1, string tosearch2)
       {
            DataTable dt = new DataTable();
            DataView dv = ((DataTable)dgv.DataSource).DefaultView;
            dv.RowFilter = string.Format(tosearch1 + " LIKE '%{0}%' or " + tosearch2 + " LIKE '%{0}%'", BPSolutionsTools.BPSUtilitiesV1.NZ(strtosearch, ""));
            dt = dv.ToTable();
            DataTable cloneDataTable = dt.Clone();

            if (dt.Rows.Count < _take)
            {
                _take = dt.Rows.Count;
            }
                for (int i = 0; i < _take; i++)
                {
                    cloneDataTable.ImportRow(dt.Rows[i]);
                }
            var test = cloneDataTable.Rows.Count;
            return cloneDataTable;
        }
    }
}
