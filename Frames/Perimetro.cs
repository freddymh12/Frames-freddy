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
    public partial class Perimetro : Form
    {
        public Perimetro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double LONGITUD = Convert.ToDouble(textBox1.Text);
            double LADOS = Convert.ToDouble(textBox2.Text);
            textBox3.Text = string.Format("{0:F2}", LONGITUD * LADOS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
