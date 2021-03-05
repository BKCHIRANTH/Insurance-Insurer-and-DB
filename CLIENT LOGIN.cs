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
    public partial class CLIENT_LOGIN : Form
    {
        public CLIENT_LOGIN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NEW_CLIENT nc = new NEW_CLIENT();
            nc.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SELECT_USER su = new SELECT_USER();
            su.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;User ID=sa;Password=vvce";
            con.Open();
            SqlCommand cmd = new SqlCommand("select CLIENT_ID,PASSWORD from CLIENT where CLIENT_ID='" + textBox3.Text + "'and PASSWORD='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                CLIENT_DECIDE cd = new CLIENT_DECIDE();
                cd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!! please check username and password");
            }
            con.Close();
           
        }
    }
}
