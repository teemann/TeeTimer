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
    public partial class AddTimer : Form
    {
        Form1 f1;

        public AddTimer(Form1 f1)
        {
            InitializeComponent();
            if (Parent == null)
                StartPosition = FormStartPosition.CenterScreen;
            this.f1 = f1;
        }

        public AddTimer(Form1 f1, TimeSpan ts)
        {
            InitializeComponent();
            if (Parent == null)
                StartPosition = FormStartPosition.CenterScreen;
            this.f1 = f1;
            nD.Value = ts.Days;
            nH.Value = ts.Hours;
            nM.Value = ts.Minutes;
            nS.Value = ts.Seconds;

            nD.Enabled = false;
            nH.Enabled = false;
            nM.Enabled = false;
            nS.Enabled = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            double secs = (int)nS.Value;
            secs += (int)nM.Value * 60;
            secs += (int)nH.Value * 60 * 60;
            secs += (int)nD.Value * 60 * 60 * 24;
            TimeSpan ts = TimeSpan.FromSeconds(secs);
            f1.addTimer(tDesc.Text, ts);
            Close();
        }

        private void tDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btOK_Click(null, null);
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.Control || e.Alt)
                return;
            Font f = new Font("Microsoft Sans Serif", 8.25f, GraphicsUnit.Point);
            string s = tDesc.Text;
            s += (char)e.KeyValue;
            if (TextRenderer.MeasureText(s, f).Width > Popup.maxTextWidth)
                e.SuppressKeyPress = true;
        }
    }
}
