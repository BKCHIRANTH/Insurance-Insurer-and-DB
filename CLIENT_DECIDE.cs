using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSURANCE1
{
    public partial class CLIENT_DECIDE : Form
    {
        public CLIENT_DECIDE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLAIM c = new CLAIM();
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            POLICY_SELECTION ps = new POLICY_SELECTION();
            ps.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANKS A LOT FOR BEING WITH US........VISIT AGAIN!!!");
            CLIENT_LOGIN cl = new CLIENT_LOGIN();
            cl.Show();
            this.Hide();
        }
    }
}
