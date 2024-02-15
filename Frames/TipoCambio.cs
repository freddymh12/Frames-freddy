using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frames
{
    public partial class TipoCambio : Form
    {
        public TipoCambio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cambioDE = Convert.ToDouble(textBox4.Text);
            double Dolares = Convert.ToDouble(textBox1.Text);
            textBox2.Text = string.Format("{0:F2}", Dolares * cambioDE);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double cambioED = Convert.ToDouble(textBox3.Text);
            double Euros = Convert.ToDouble(textBox2.Text);
            textBox2.Text = string.Format("{0:F2}", Euros * cambioED);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
