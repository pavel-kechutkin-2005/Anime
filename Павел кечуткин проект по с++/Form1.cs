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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            klanUchiha form3 = new klanUchiha("Учиха");
            form3.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            klanUchiha form = new klanUchiha("Учиха");
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            klanUchiha form3 = new klanUchiha("Учиха");
            form3.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            klanUchiha form3 = new klanUchiha();
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
