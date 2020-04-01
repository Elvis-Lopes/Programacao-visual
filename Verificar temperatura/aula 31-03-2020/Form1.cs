using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_31_03_2020
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float temp;
            temp = float.Parse(textBox1.Text);
            if(temp > 37.7)
            {
                MessageBox.Show("Esta com febre!\n" +
                                "Por favor, aguarde ao lado!\n" +
                                "Sua compra será assistida!");
            }
            else
            {
                MessageBox.Show("Pode entrar higienize as mãos com álcool");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
