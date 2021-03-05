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
    public partial class WELCOME : Form
    {
       
        public WELCOME()
        {
            
            InitializeComponent();
        }
      
        private void WELCOME_Load(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            PictureBox image = new PictureBox();
            image.Width = 400;
            image.Height = 400;
            Bitmap darkblue = new Bitmap("C:\\Users\\Administrator\\Desktop\\pics");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SELECT_USER su = new SELECT_USER();
            su.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
