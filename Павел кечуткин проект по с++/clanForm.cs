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
    public partial class clanForm : Form
    {
        public clanForm(string clan)
        {
            InitializeComponent();

            if (clan == "Учиха")
            {
                Text = "Клан Учиха";
            }
            if (clan == "Узумаки")

            {
                Text = "Клан Узумаки";
            }




        }

        private void klanUchiha_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
