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
    public partial class ACKNOWLEDGENT : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
      
        public ACKNOWLEDGENT()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POLICY_SELECTION ps = new POLICY_SELECTION();
            ps.Show();
            this.Hide();
        }

      

        private void LIFE_ACK_Load(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;

            SqlConnection Conn = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
            SqlCommand Comm1 = new SqlCommand("Select PAYMENT_ID,POLICY_TYPE,POLICY_NO,POLICY_PREMIUM,CGST,SGST,PAYMENT_MODE,TOTAL from PAYMENT where PAYMENT_ID='" + value + "'", Conn);
            Conn.Open();

            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                label16.Text = DR1.GetValue(0).ToString();
                label2.Text = DR1.GetValue(1).ToString();
                label3.Text = DR1.GetValue(2).ToString();
                label17.Text = DR1.GetValue(3).ToString();
                label18.Text = DR1.GetValue(4).ToString();
                label19.Text = DR1.GetValue(5).ToString();
                label20.Text = DR1.GetValue(6).ToString();
                label23.Text = DR1.GetValue(7).ToString();
                

            }
            Conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

   
}
