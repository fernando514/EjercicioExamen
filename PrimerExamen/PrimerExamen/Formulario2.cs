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
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }


        int[] arregloprecio = new int[1];
        int total = 0;

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                listBox1.Items.Add(ProductoTextBox.Text + " $ " + PrecioTextBox.Text);
                arregloprecio[i] = Convert.ToInt32(PrecioTextBox.Text);

            }
            for (int i = 0; i < 1; i++)
            {
                total = total + arregloprecio[i];
            }

        }

        private double Rebaja()
        {
            double descuento = 0.15;
            double subtotal = total * descuento;
            double nuevototal = total - subtotal;
            return nuevototal;
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            SubtotalTextBox.Text = Convert.ToString("& " +total);
            TotalTextBox.Text = Convert.ToString("& " + Rebaja());
        }
    }
}
