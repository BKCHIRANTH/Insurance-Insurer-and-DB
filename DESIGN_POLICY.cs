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
    public partial class DESIGN_POLICY : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public DESIGN_POLICY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem as string;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into POLICY(POLICY_NO,POLICY_NAME,POLICY_PREMIUM,POLICY_TYPE,CGST,SGST,POLICY_INSTL)" + "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + selectedValue + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("POLICY CREATED!!");
        }

        private void DESIGN_POLICY_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("VEHICLE");
            comboBox1.Items.Add("LIFE");
            comboBox1.Items.Add("HOUSE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANKS FOR EVERYTHING!!.....COME BACK SOON!!");
            DESIGNER_LOGIN dl = new DESIGNER_LOGIN();
            dl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float r = float.Parse(this.textBox3.Text);
            float m = (float)0.3 *r;
            string p = m.ToString();
            textBox4.Text = p;
            float h = float.Parse(this.textBox3.Text);
            float n = (float)0.5 *h;
            string u = n.ToString();
            textBox5.Text = u;
        }
    }
}
