using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frames
{
    public partial class Poligono_Area : Form
    {
        public Poligono_Area()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double perimetro = Convert.ToDouble(textBox1.Text);
            double apotema = Convert.ToDouble(textBox2.Text);
            textBox3.Text = string.Format("{0:F2}", (perimetro * apotema) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
