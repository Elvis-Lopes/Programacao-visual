using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificador_de_caracter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letra;
            letra = Convert.ToChar(textBox1.Text);
            if (Char.IsUpper(letra))
            {
                MessageBox.Show("A letra é maiuscula.");
            }
            else if (Char.IsLower(letra))
            {
                MessageBox.Show("A letra é minuscula.");
            }
            else if (Char.IsDigit(letra))
            {
                MessageBox.Show("O caractere é um número.");
            }
            else
            {
                MessageBox.Show("O caractere digitado não é alfanúmerico (especial).");
            }
        }
    }
}
