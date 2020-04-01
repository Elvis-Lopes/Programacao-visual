using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);

            if (num1 > num2)
            {
                MessageBox.Show("O primeiro número é o maior");
            }
            else if (num1 < num2)
            {
                MessageBox.Show("O segundo númreo é o maior");
            }
            else
            {
                MessageBox.Show("Os números são iguais");
            }
        }
    }
}
