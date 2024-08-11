using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema2
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
            if (index >= 4)
            {
                double desviacionT = 0;
                double media = numeros.Average();
                double suma = numeros.Sum(d => Math.Pow(d - media, 2));
                desviacionT = Math.Sqrt((suma) / numeros.Count());
                lstResultados.Items.Clear();
                lblAviso.Text = "";
                lstResultados.Items.Add("La media es: " + media.ToString("0.00"));
                lstResultados.Items.Add("La desviacion tipica es: " + desviacionT.ToString("0.000"));
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
            numeros.Add(NumeroIngresado);
            ActualizarListas();
            txtNumero.Focus();
            txtNumero.Text = "";

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            lstNumeros.Items.Clear();
            lstResultados.Items.Clear();
            txtNumero.Text = "";
            lblAviso.Text = "Ingrese minimo 4 numeros";
            txtNumero.Focus();
        }
    }
}
