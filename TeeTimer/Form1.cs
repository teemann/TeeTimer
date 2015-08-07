using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            table.Rows.Add("Test", "1:20:05");
            
        }

        private void table_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hit = table.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    table.ClearSelection();
                    table.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Selected = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(table.SelectedCells.Count == 1)
            {
                table.Rows.RemoveAt(table.SelectedCells[0].RowIndex);
            }
        }
    }
}
