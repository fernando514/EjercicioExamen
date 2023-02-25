using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerExamen
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }


        string[] arregloMes = new string[] { "Enero", "Febrero", "Marzo", "Abril","Mayo", "Junio", "Julio",
                                    "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double capital = 200000;
            double[] arregloI = new double[12];
            for (int i = 0; i < arregloI.Length; i++)
            {
                arregloI[i] = capital * 0.015;
                double total = capital + arregloI[i];
                capital = total;
                textBox1.Text = Convert.ToString("$ " + Math.Round(capital, 4));
            }

            for (int i = 0; i < arregloMes.Length; i++)
            {
                listBox1.Items.Add(arregloMes[i]);
                listBox2.Items.Add(Math.Round(arregloI[i], 3));
            }
        }


    }
}
