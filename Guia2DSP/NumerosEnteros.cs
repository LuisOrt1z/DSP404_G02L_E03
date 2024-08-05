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
    public partial class NumerosEnteros : Form
    {
        public NumerosEnteros()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtMayorNegativo.Clear();
            txtPositivos.Clear();
            txtPromNegativos.Clear();
            txtPorcPositivos.Clear();
            txtPorcNegativos.Clear();
            txtCeros.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeros;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            int sumaNegativos = 0;
            int mayorNegativo = int.MinValue;


            numeros = Convert.ToInt32(txtNumero.Text);

            if (numeros >= -40 && numeros <= 45)
            {
                // Actualizar información
                if (numeros < 0)
                {
                    if (numeros > mayorNegativo)
                    {
                        mayorNegativo = numeros;
                    }
                    negativos++;
                    sumaNegativos += numeros;
                }
                else if (numeros > 0)
                {
                    positivos++;
                }
                else
                {
                    ceros++;
                }

                txtNumero.Clear();
                txtMayorNegativo.Text = $"{mayorNegativo}";
                txtPositivos.Text = $"{positivos}";
                txtPromNegativos.Text = $"{(negativos > 0 ? sumaNegativos / negativos : 0)}";
                txtPorcPositivos.Text = $"{(positivos / (positivos + negativos + ceros)) * 100}%";
                txtPorcNegativos.Text = $"{(negativos / (positivos + negativos + ceros)) * 100}%";
                txtCeros.Text = $"{(ceros / (positivos + negativos + ceros)) * 100}%";

            }
            else
            {
                MessageBox.Show("El numero ingresado no esta en el rango especificado.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
