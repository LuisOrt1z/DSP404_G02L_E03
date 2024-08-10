using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> numeros = new List<double>();
        public static Boolean ValidaNum(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }
        public void ActualizarListas()
        {
            lstNumeros.Items.Clear();
            int index = 1;
            foreach (double numero in numeros)
            {
                lstNumeros.Items.Add(index + ". Numero: " + numero);
                index++;
            }
            index = index - 1;

            lstResultados.Items.Clear();
            var negativos = numeros.Where(n => n < 0).ToList();
            var positivos = numeros.Where(n => n > 0).ToList();
            int CantidadPositivos = numeros.Count(n => n > 0);
            int CantidadNegativos = numeros.Count(n => n < 0);
            int CantidadCeros = numeros.Count(n => n == 0);
            if (negativos.Any())
            {
                double MayorNegativo = negativos.Max();
                double promedioNegativo = negativos.Average();
                lstResultados.Items.Add("El mayor de los negativos es: " + MayorNegativo);
                lstResultados.Items.Add("El promedio de los negativos es: " + promedioNegativo.ToString("0.00"));
            }
            else
            {
                lstResultados.Items.Add("No hay numeros negativos en la lista");
            }

            if (positivos.Any())
            {
                lstResultados.Items.Add("La cantidad de numeros positivos es: " + CantidadPositivos);
            }
            else
            {
                lstResultados.Items.Add("No hay numeros positivos en la lista");
            }
            double porcentajePositivo = ((double)CantidadPositivos / index)*100;
            double porcentajeNegativo = ((double)CantidadNegativos / index)*100;
            lstResultados.Items.Add("El porcentaje de los positivos es: " + porcentajePositivo.ToString("0.00") + "%");
            lstResultados.Items.Add("El porcentaje de los Negativos es: " + porcentajeNegativo.ToString("0.00") + "%");
            if(CantidadCeros > 0)
            {
                lstResultados.Items.Add("La cantidad de 0 en la lista es: " + CantidadCeros);
            }
            else
            {
                lstResultados.Items.Add("No hay ningun 0 en la lista");
            }
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(ValidaNum(txtNumero.Text)))
            {
                MessageBox.Show("El valor ingresado no es un numero", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                txtNumero.Text = "";
                txtNumero.BackColor = Color.Red;
                return;
            }
            double NumeroIngresado = Convert.ToDouble(txtNumero.Text);
            if (!(NumeroIngresado >= -40 && NumeroIngresado <= 45))
            {
                MessageBox.Show("Solo se permiten numeros del rango -40 a 45", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                txtNumero.Text = "";
                txtNumero.BackColor = Color.Red;
                return;
            }
            numeros.Add(NumeroIngresado);
            ActualizarListas();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            lstNumeros.Items.Clear();
            lstResultados.Items.Clear();
            txtNumero.Text = "";
            txtNumero.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
