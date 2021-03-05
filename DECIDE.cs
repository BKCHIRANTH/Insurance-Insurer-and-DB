using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace INSURANCE1
{
    public partial class DECIDE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public DECIDE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADD_DESIGNERS ag = new ADD_DESIGNERS();
            ag.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU!!  COME BACK SOON!!");
            SELECT_USER su = new SELECT_USER();
            su.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DESIGNER_LOGIN al = new DESIGNER_LOGIN();
            al.Show();
            this.Close();
        }

        private void AGENT_ADDITION_SUMMARY_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGS lg = new LOGS();
            lg.Show();
            this.Hide();
        }
    }
}
