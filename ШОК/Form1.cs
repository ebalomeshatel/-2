using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ШОК{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        Parallelepiped parallelepiped;

        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle();
            parallelepiped = new Parallelepiped();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rectangle.Height = Convert.ToDouble(textHeight.Text == " " ? "0" : textHeight.Text);
            parallelepiped.HeightBase = rectangle.Height;
            rectangle.Width = Convert.ToDouble(textWigth.Text == " " ? "0" : textWigth.Text);
            parallelepiped.WidthBase = rectangle.Width;
            richTextBox2.Text = rectangle.ToString();

            parallelepiped.Height_of_paralle = Convert.ToDouble(textHeigth_par.Text == " " ? "0" : textHeigth_par.Text);
            richTextBox1.Text = parallelepiped.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textHeigth_par_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
