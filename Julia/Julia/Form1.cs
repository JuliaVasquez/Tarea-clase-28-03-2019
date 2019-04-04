using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public double n1;
        public double n2;
        public double Calcular;

        public Form1()
        {
            n1 = 0;
            n2 = 0;
           Calcular = 0;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                Calcular = n1 + n2;
                
                label1.Text = Calcular.ToString();

            } else if (radioButton2.Checked == true)
            {
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                Calcular = n1 - n2;

                label1.Text = Calcular.ToString();
            }else if (radioButton3.Checked == true)
            {
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                Calcular = n1 * n2;

                label1.Text = Calcular.ToString();
            }else if (radioButton4.Checked == true)
            {
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                Calcular = n1 / n2;

                label1.Text = Calcular.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
