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
    public partial class LIFE_INSURANCE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public LIFE_INSURANCE()
        {
            InitializeComponent();
        }

        private void LIFE_INSURANCE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender;
            string t= richTextBox1.Text.Trim();
            if (radioButton1.Checked == true)
            {
                gender = "MALE";

            }
            else
            {
                gender = "FEMALE";

            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PERSONAL(CUSTOMER_NAME,FATHER_NAME,PHONE_NO,EMAIL_ID,GENDER,QUALIFICATION,OCCUPATION,ADDRESS,DOB,AGE,INCOME)" + "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + gender + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + t + "','" + textBox8.Text + "', '" + textBox7.Text + "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SAVED!");
            PAYMENT pay = new PAYMENT();
            pay.Show();
            this.Hide();

        }
            private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            POLICY_SELECTION ps = new POLICY_SELECTION();
            ps.Show();
            this.Hide();
        }
    }
}
