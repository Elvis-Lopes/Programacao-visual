using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasSemana
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
            int dia;
            dia = Int32.Parse(textBox1.Text);

            switch (dia)
            {
                case 1:
                    label2.Text = "Domingo";
                    break;

                case 2:
                    label2.Text = "Segunda";
                    break;

                case 3:
                    label2.Text = "Terça";
                    break;

                case 4:
                    label2.Text = "Quarta";
                    break;

                case 5:
                    label2.Text = "Quinta";
                    break;

                case 6:
                    label2.Text = "Sexta";
                    break;

                case 7:
                    label2.Text = "Sabado";
                    break;

                default:
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
