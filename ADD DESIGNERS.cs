using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System.Data.Sql;
namespace INSURANCE1
{
    public partial class ADD_DESIGNERS : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public ADD_DESIGNERS()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string gender;
            string t= richTextBox1.Text.Trim();
            if (radioButton1.Checked==true)
            {
                gender = "MALE";

            }
            else
            {
                gender = "FEMALE";

            }
            string query1 = "insert into DESIGNERS(DESIGNER_ID,DESIGNER_NAME,PHONE_NO,EMAIL_ID,GENDER,PASSWORD,ADDRESS,DOB)" + "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + gender + "', '" + textBox5.Text + "','" + t + "', '" + textBox8.Text + "')" ;
            SqlDataAdapter da = new SqlDataAdapter(query1,con);
            da.SelectCommand.ExecuteNonQuery();

            
            
            con.Close();
            MessageBox.Show("SAVED!");


          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DECIDE d = new DECIDE();
            d.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox8.Clear();
            richTextBox1.Clear();
            

        }

        private void ADD_AGENT_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query2 = "delete from DESIGNERS where DESIGNER_ID='" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query2, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DELETE SUCCESSFUL!!!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE view1";
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string gender;
            string e2 = richTextBox1.Text.Trim();
            if (radioButton1.Checked == true)
            {
                gender = "MALE";

            }
            else
            {
                gender = "FEMALE";

            }
            string query1 = "update DESIGNERS SET DESIGNER_ID='"+textBox1.Text+"',DESIGNER_NAME='" + textBox2.Text + "',PHONE_NO='"+textBox3.Text+"',EMAIL_ID='"+textBox4.Text+"',GENDER='"+gender+"',PASSWORD='"+textBox5.Text+"',ADDRESS='"+ e2 +"',DOB='"+textBox8.Text+"' where DESIGNER_ID ='"+textBox1.Text+"'";
            SqlDataAdapter da3 = new SqlDataAdapter(query1, con);
            da3.SelectCommand.ExecuteNonQuery().ToString();
            con.Close();
            MessageBox.Show("UPDATE SUCCESSFUL!!!");

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
