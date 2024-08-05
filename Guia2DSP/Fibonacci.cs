using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2DSP
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        int valor0 = 0;
        int valor1 = 1;
        int serie = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            listSerie.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txtNumero.Text);

            while (serie <= numero)
            {
                listSerie.Items.Add(serie);
                serie = valor0 + valor1;
                valor0 = valor1;
                valor1 = serie;
            }
        }
    }
}
