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
    public partial class NEW_CLIENT : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public NEW_CLIENT()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender; 
            if (radioButton1.Checked == true)
            {
                gender = "MALE";

            }
            else
            {
                gender = "FEMALE";

            }
            string e1 = textBox7.ToString();
            string e2 = textBox10.ToString();
            string e3 = richTextBox1.Text.Trim();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CLIENT(CLIENT_ID,CLIENT_NAME,PHONE_NO,EMAIL_ID,GENDER,QUALIFICATION,OCCUPATION,PASSWORD,ADDRESS,DOB,PAN_NO,INCOME)" + "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox11.Text + "', '" + gender + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + textBox7.Text + "','" + e3 + "','" + textBox4.Text + "', '" + textBox8.Text + "','" + textBox9.Text + "')";
            if (e1 == e2)
            { 
                cmd.ExecuteNonQuery();          //VALIDATED
                MessageBox.Show("SAVED!");
                CLIENT_LOGIN cl = new CLIENT_LOGIN();
                cl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("PLEASE CHECK THE RE-ENTERED PASSWORD!!");
            }

            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLIENT_LOGIN cl = new CLIENT_LOGIN();
            cl.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            textBox10.Clear();
            textBox11.Clear();

        }

        private void NEW_CLIENT_Load(object sender, EventArgs e)
        {

        }

        
    }
}
