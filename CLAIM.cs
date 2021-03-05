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
    public partial class CLAIM : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public CLAIM()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLAIM_Load(object sender, EventArgs e)
        {
            SqlCommand cmdd;
            comboBox1.Items.Clear();
            con.Open();
            cmdd = con.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "SELECT DISTINCT POLICY_TYPE FROM POLICY";
            cmdd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["POLICY_TYPE"].ToString());
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem as string;
            SqlCommand cmddd;
            comboBox2.Items.Clear();
            con.Open();
            cmddd = con.CreateCommand();
            cmddd.CommandType = CommandType.Text;
            cmddd.CommandText = "SELECT DISTINCT POLICY_NO FROM POLICY WHERE POLICY_TYPE='" + selectedValue + "'";
            cmddd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmddd);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBox2.Items.Add(dr1["POLICY_NO"].ToString());
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string e2 = richTextBox1.Text.Trim();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CLAIM(CLAIM_ID,POLICY_TYPE,POLICY_NO,CLAIM_DESCRIPTION)" + "values('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "','"+ e2 +"')";
            cmd.ExecuteNonQuery();        
            MessageBox.Show("CLAIM REGISTERED!!");
            MessageBox.Show("KEEP WAITING UNTIL WE CHECK THE GENUINENESS OF THE CLAIM!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLIENT_DECIDE cd = new CLIENT_DECIDE();
            cd.Show();
            this.Hide();
        }
    }
}
