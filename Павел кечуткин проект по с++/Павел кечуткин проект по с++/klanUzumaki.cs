using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Павел_кечуткин_проект_по_с__
{
    public partial class klanUzumaki : Form
    {
        public klanUzumaki()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            klanUzumaki form3 = new klanUzumaki();
            form3.Show();
        }

        private void klanUzumaki_Load(object sender, EventArgs e)
        {
            klanUzumaki form3 = new klanUzumaki();
            form3.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            klanUzumaki form3 = new klanUzumaki();
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            klanUzumaki form3 = new klanUzumaki();
            form3.Show();
        }
    }
}
