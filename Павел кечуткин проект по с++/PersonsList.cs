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
    public struct Pers
    {
        public PictureBox picture;
        public string name;
        //Клан, Дервеня
    };

    public partial class PersonsList : Form
    {
        Pers[] persons = new Pers[100];

        public PersonsList()
        {
            InitializeComponent();

            persons[0].picture = pictureBox3;
            persons[0].name = "Кушина";
            //Новые персонажи
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы кликнули на персонажа");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
