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
    public partial class Impuesto : Form
    {
        public Impuesto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = string.Format("{0:F2}", precio);
                int Impuesto = 0;
                textBox3.Text = string.Format("{0:F2}", Impuesto);
            }
        else if(radioButton2.Checked){
                double impuesto = precio*0.16;
                textBox2.Text = string.Format("{0:F2}", precio + impuesto);
                textBox3.Text = string.Format("{0:F2}", impuesto);
    }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
    }

