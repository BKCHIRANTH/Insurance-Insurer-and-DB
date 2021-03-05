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
using System.Data.Sql;


namespace INSURANCE1
{
    public partial class POLICY_SELECTION : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHIRANTH\SQLEXPRESS;Initial Catalog=INSURANCE1;Persist Security Info=True;User ID=sa;Password=vvce");
       
        public POLICY_SELECTION()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
           
        }

        private void POLICY_SELECTION_Load(object sender, EventArgs e)
        {
            SqlCommand cmdd;
            comboBox1.Items.Clear();
            con.Open();
            cmdd = con.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "EXECUTE view2";
            cmdd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["POLICY_TYPE"].ToString());
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CLIENT_DECIDE cd = new CLIENT_DECIDE();
            cd.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem as string;
            SqlCommand cmddd;
            comboBox2.Items.Clear();
            con.Open();
            cmddd = con.CreateCommand();
            cmddd.CommandType = CommandType.Text;
            cmddd.CommandText = "SELECT DISTINCT POLICY_NO FROM POLICY WHERE POLICY_TYPE='"+selectedValue+"'";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            string s1 = comboBox2.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand("select DISTINCT POLICY_NAME from POLICY where POLICY_NO='" + s1 + "'", con);
            SqlCommand cmd1 = new SqlCommand("select POLICY_PREMIUM from POLICY where POLICY_NO='" + s1 + "'", con);
            SqlCommand cmd2 = new SqlCommand("select POLICY_INSTL from POLICY where POLICY_NO='" + s1 + "'", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {

                textBox1.Text = DR1.GetValue(0).ToString();
                DR1.Close();
                con.Close();
            }

            con.Open();
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                textBox2.Text = dr2.GetValue(0).ToString();
                dr2.Close();
                con.Close();
            }


            con.Open();
            SqlDataReader dr3 = cmd2.ExecuteReader();
            if (dr3.Read())
            {

                textBox3.Text = dr3.GetValue(0).ToString();
                dr3.Close();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "VEHICLE")
            {
                VEHICLE_INSURANCE vi = new VEHICLE_INSURANCE();
                vi.Show();
                this.Hide();
            }
            if(comboBox1.SelectedItem.ToString() == "LIFE")
            {
                LIFE_INSURANCE li = new LIFE_INSURANCE();
                li.Show();
                this.Hide();

            }
            if(comboBox1.SelectedItem.ToString() == "HOUSE")
            {
                HOUSE_INSURANCE hi = new HOUSE_INSURANCE();
                hi.Show();
                this.Hide();
            }
        }
    }
}
               





































