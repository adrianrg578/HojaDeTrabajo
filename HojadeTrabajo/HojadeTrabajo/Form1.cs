using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojadeTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void hipotenusa() {
            double cateto1 = Convert.ToDouble(textBox1.Text);
            double cateto2 = Convert.ToDouble(textBox2.Text);
            double resultado = 0;

            resultado = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            label4.Text = "La Hipotenusa es:  " + resultado;

        }

        public void vocales() {
            string palabra = textBox1.Text;
            string resultado = "";

            if (palabra.Contains('a') || palabra.Contains('A') || palabra.Contains('á') || palabra.Contains('Á'))
            {
                if (palabra.Contains('e') || palabra.Contains('E') || palabra.Contains('é') || palabra.Contains('É'))
                {
                    if (palabra.Contains('i') || palabra.Contains('I') || palabra.Contains('í') || palabra.Contains('Í'))
                    {
                        if (palabra.Contains('o') || palabra.Contains('O') || palabra.Contains('ó') || palabra.Contains('Ó'))
                        {
                            if (palabra.Contains('u') || palabra.Contains('U') || palabra.Contains('ú') || palabra.Contains('Ú'))
                            {
                                resultado = "Cumple";
                            }
                            else
                            {
                                resultado = "No Cumple";
                            }
                        }
                        else
                        {
                            resultado = "No Cumple";
                        }
                    }
                    else
                    {
                        resultado = "No Cumple";
                    }
                }
                else
                {
                    resultado = "No Cumple";
                }
            }
            else {
                resultado = "No Cumple";
            }

            label4.Text = resultado;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            hipotenusa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vocales();
        }
    }
}
