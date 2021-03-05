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
using System.Data.Sql;
namespace INSURANCE1
{
    public partial class ADMIN_LOGIN : Form
    {
        public ADMIN_LOGIN()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;User ID=sa;Password=vvce";

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;User ID=sa;Password=vvce";
            con.Open();
            SqlCommand cmd = new SqlCommand("select adminusername,adminpassword from ADMIN where adminusername='" + textBox1.Text + "'and adminpassword='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TASK aod = new TASK();
                aod.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SELECT_USER su = new SELECT_USER();
            su.Show();
            this.Hide();
        }

        private void ADMIN_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
    }
       
