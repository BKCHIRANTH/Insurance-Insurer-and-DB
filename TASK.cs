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
    public partial class TASK : Form
    {
        public TASK()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            ADD_DESIGNERS ag = new ADD_DESIGNERS();
            ag.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAVE A NICE DAY ADMIN!!");
            ADMIN_LOGIN al = new ADMIN_LOGIN();
            al.Show();
            this.Hide();
        }

        private void ADD_OR_DELETE_AGENT_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGS l = new LOGS();
            l.Show();
            this.Hide();
        }
    }
}
