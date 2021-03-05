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
    public partial class HOUSE_INSURANCE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public HOUSE_INSURANCE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string e1 = richTextBox1.Text.Trim();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into HOUSE(HOUSE_NO,ADDRESS,YEAR,HOUSE_AREA)" + "values('" + textBox1.Text + "','" + e1 + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SAVED!");

            PAYMENT pay = new PAYMENT();
            pay.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            POLICY_SELECTION ps = new POLICY_SELECTION();
            ps.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HOUSE_INSURANCE_Load(object sender, EventArgs e)
        {

        }
    }
}








