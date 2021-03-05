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
    public partial class VEHICLE_INSURANCE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
        public VEHICLE_INSURANCE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into VEHICLE(PERIOD_OF_INSURANCE,DATE_OF_REG,REG_NO,ENGINE_NO,CHASSIS_NO,MAKER,YEAR_OF_MANUFACTURE,MODEL_NO,COLOUR)" + "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + textBox7.Text + "', '" + textBox8.Text + "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SAVED!");
            PAYMENT pay = new PAYMENT();
            pay.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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






            