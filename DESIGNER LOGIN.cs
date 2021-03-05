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
    public partial class DESIGNER_LOGIN : Form
    {
        public DESIGNER_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;User ID=sa;Password=vvce";
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select DESIGNER_ID,PASSWORD from DESIGNERS where DESIGNER_ID='" + textBox1.Text + "'and PASSWORD='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DESIGN_POLICY dp = new DESIGN_POLICY();
                dp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!!!please check username and password");
            }
            con.Close();
        }
            private void button2_Click(object sender, EventArgs e)
        {
            SELECT_USER su = new SELECT_USER();
            su.Show();
            this.Hide();

        }

        private void AGENT_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
