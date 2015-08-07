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
            tray.Icon = Icon;
            hToolStripMenuItem1.Click += hToolStripMenuItem_Click;
            minToolStripMenuItem2.Click += min30ToolStripMenuItem_Click;
            minToolStripMenuItem3.Click += min10ToolStripMenuItem1_Click;
            customToolStripMenuItem1.Click += customToolStripMenuItem_Click;

            //table.Rows.Add("Test", "1:20:05");
            /*Timer t = new Timer("Hallo, das ist ein TestHallo, das ist ein TestHallo, das ist iii", TimeSpan.FromSeconds(15));
            t.TimerTick += T_TimerTick;
            t.TimerFinished += T_TimerFinished;
            t.Start();
            table.Rows.Add(t, "abc");*/
        }

        private void T_TimerFinished(Timer sender)
        {
            System.Media.SystemSounds.Exclamation.Play();
            Invoke((MethodInvoker)(() =>
            {
                int idx = -1;
                foreach(DataGridViewRow row in table.Rows)
                {
                    if(row.Cells[0].Value == sender)
                    {
                        idx = row.Index;
                    }
                }
                if (idx > -1)
                    table.Rows.RemoveAt(idx);
                new Popup(sender.ToString()).ShowDialog();
            }));
        }

        private void T_TimerTick(Timer sender, TimeSpan delta)
        {
            //Console.WriteLine(delta);
            //Console.WriteLine(sender.Time);
            try {
                Invoke((MethodInvoker)(() =>
                {
                    foreach (DataGridViewRow row in table.Rows)
                    {
                        object val = row.Cells[0].Value;
                        row.Cells[1].Value = (val as Timer).TimeString();
                    }
                }));
            }
            catch(Exception e) { }
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
                var row = table.Rows[table.SelectedCells[0].RowIndex];
                if(row.Cells[0].Value is Timer)
                {
                    Timer t = row.Cells[0].Value as Timer;
                    var res = MessageBox.Show("Stop timer \"" + t.Name + "\"?", "Stop timer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res != DialogResult.Yes)
                        return;
                    t.TimerFinished -= T_TimerFinished;
                    t.TimerTick -= T_TimerTick;
                    t.Stop();
                    table.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell cell in table.SelectedCells)
            {
                DataGridViewCell tc = cell.OwningRow.Cells[0];
                if(tc.Value is Timer)
                {
                    Timer t = tc.Value as Timer;
                    t.Paused = !t.Paused;
                }
            }
        }

        public void addTimer(string name, TimeSpan time)
        {
            Timer t = new Timer(name, time);
            t.TimerTick += T_TimerTick;
            t.TimerFinished += T_TimerFinished;
            t.Start();
            table.Rows.Add(t, t.TimeString());
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTimer a = new AddTimer(this);
            a.ShowDialog();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTimer a = new AddTimer(this, TimeSpan.FromHours(1));
            a.ShowDialog();
        }

        private void min30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTimer a = new AddTimer(this, TimeSpan.FromMinutes(30));
            a.ShowDialog();
        }

        private void min10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTimer a = new AddTimer(this, TimeSpan.FromMinutes(10));
            a.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                tray.Visible = true;
                Visible = false;
            }
        }

        private void showOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            tray.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            tray.Visible = false;
        }
    }
}
