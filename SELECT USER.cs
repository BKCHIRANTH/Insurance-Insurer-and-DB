using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace INSURANCE1
{
   

    public partial class SELECT_USER : Form
    {

        public SELECT_USER()
        {
           
        
            InitializeComponent();
           
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN_LOGIN al = new ADMIN_LOGIN();
            al.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DESIGNER_LOGIN ajl = new DESIGNER_LOGIN();
            ajl.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NEW_CLIENT nc = new NEW_CLIENT();
            nc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLIENT_LOGIN cl = new CLIENT_LOGIN();
            cl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WELCOME W = new WELCOME();
            W.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
