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
    public partial class Popup : Form
    {
        public static int maxTextWidth { get { return 280; } }

        public Popup(string s)
        {
            InitializeComponent();
            pMain.Left = 0;
            pMain.Width = ClientSize.Width;
            lbTim.Left = pMain.Width / 2 - lbTim.Width / 2;
            lbDesc.Text = s;
            lbDesc.Left = pMain.Width / 2 - lbDesc.Width / 2;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
