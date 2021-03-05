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
    public partial class PAYMENT : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
      

        public PAYMENT()
        {
            InitializeComponent();
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }
        private void PAYMENT_Load(object sender, EventArgs e)
        {
            SqlCommand cmdd;
            comboBox2.Items.Clear();
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
                comboBox2.Items.Add(dr["POLICY_TYPE"].ToString());
                con.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem as string;
            SqlCommand cmddd;
            comboBox1.Items.Clear();
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
                comboBox1.Items.Add(dr1["POLICY_NO"].ToString());
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mode;
            if (radioButton1.Checked == true)
            {
                 mode = "CASH";

            }
            else if (radioButton2.Checked == true)
            {
                 mode = "CHEQUE";
            }
            else
            {
                 mode = "CARD";
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PAYMENT(PAYMENT_ID,POLICY_NO,POLICY_TYPE,POLICY_PREMIUM,CGST,SGST,PAYMENT_MODE,TOTAL)" + "values('" + textBox5.Text + "', '" + comboBox1.Text + "', '"+comboBox2.Text+"','" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '"+mode+"','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            if (mode == "CASH")
            {
                MessageBox.Show("SUCCESSFULLY PAID THROUGH CASH!!");
            }
            else if (mode == "CHEQUE")
            {
                MessageBox.Show("SUCCESSFULLY PAID THROUGH CHEQUE!!");
            }
            else
            {
                MessageBox.Show("SUCCESSFULLY PAID THROUGH CARD!!");
            }
            ACKNOWLEDGENT ack = new ACKNOWLEDGENT();
            ack.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = comboBox1.SelectedItem.ToString();

            
            SqlCommand cmd1 = new SqlCommand("select POLICY_PREMIUM from POLICY where POLICY_NO='" + s1 + "'", con);
            SqlCommand cmd2 = new SqlCommand("select CGST from POLICY where POLICY_NO='" + s1 + "'", con);
            SqlCommand cmd3 = new SqlCommand("select SGST from POLICY where POLICY_NO='" + s1 + "'", con);

            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            con.Open();
            SqlDataReader DR1 = cmd1.ExecuteReader();
            if (DR1.Read())
            {

                textBox1.Text = DR1.GetValue(0).ToString();
                DR1.Close();
                con.Close();
            }

            con.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {


                textBox2.Text = dr2.GetValue(0).ToString();
                dr2.Close();
                con.Close();
            }


            con.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {

                textBox3.Text = dr3.GetValue(0).ToString();
                dr3.Close();
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            POLICY_SELECTION ps = new POLICY_SELECTION();
            ps.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float i = (float)Convert.ToDouble(textBox1.Text);
            float j = (float)Convert.ToDouble(textBox2.Text);
            float k = (float)Convert.ToDouble(textBox3.Text);
            float m = i + j + k;
            string p = m.ToString();
            textBox4.Text = p;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
