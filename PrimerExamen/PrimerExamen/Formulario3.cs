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
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }


        private int numeros()
        {
            for(int i = 1; i < 101; i++)
            {
                listBox1.Items.Add(i);

                if(i % 3 == 0 && i % 5 == 0)
                {
                    listBox2.Items.Add(i + " " + NombreTextBox.Text + " " + ApellidoTextBox.Text);
                }

                if (i % 3 == 0 && i % 5 != 0)
                {
                    listBox2.Items.Add(i + " " + NombreTextBox.Text);
                }

                if(i % 5 == 0 && i % 3 != 0)
                {
                    listBox2.Items.Add(i + " " + ApellidoTextBox.Text);
                }

            }

            return listBox1.Items.Count;

        }

        private void Formulario3_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            int final = numeros();
        }
    }
}
