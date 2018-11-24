using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using BPSolutionsTools;

namespace PWCOSTINGV1.Classes
{
    public class NumbersOnly
    {
        
        //Reusable for textbox
        public static void _KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (sender.GetType() == typeof(MetroTextBox))
                {
                    if (e.KeyChar == '.' && (sender as MetroTextBox).Text.IndexOf('.') > -1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    {
                        e.Handled = true;
                    }
                }
        }
        public static void _KeyPress_NoPoint(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
        //For DatagridView
        public static void DatagridView(DataGridView dgv, object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(_KeyPress);

            List<string> strictedformat = new List<string>();
            strictedformat.Add("N0");
            strictedformat.Add("N2");
            strictedformat.Add("N4");

            if (strictedformat.Contains(dgv.CurrentCell.OwningColumn.DefaultCellStyle.Format))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(_KeyPress);
                }
            }
        }
    }
}
