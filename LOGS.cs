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
    public partial class LOGS : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public LOGS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT CLIENTNAME,CLIENTID FROM LOGS";
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TASK t = new TASK();
            t.Show();
            this.Hide();
        }
    }
}
