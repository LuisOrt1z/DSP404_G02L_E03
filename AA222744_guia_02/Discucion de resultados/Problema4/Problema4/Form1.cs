using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Boolean ValidaNum(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }
        public void CambioMoneda(string monedaSelecionada, int index)
        {
            switch (monedaSelecionada)
            {
                case "Dólar estadounidense":
                    monedaSelecionada = "(USD)";
                    break;
                case "Euro":
                    monedaSelecionada = "(EUR)";
                    break;
                case "Yen japonés":
                    monedaSelecionada = "(JPY)";
                    break;
                case "Libra esterlina":
                    monedaSelecionada = "(GBP)";
                    break;
                case "Franco suizo":
                    monedaSelecionada = "(CHF)";
                    break;
            }

            if (index == 0)
            {
                lblNativa.Text = monedaSelecionada;
            }
            else
            {
                lblEstranjera.Text = monedaSelecionada;
            }
        }
        public void ConvertirMondeda(string monedaNativa,string MonedaExtranjera, double cantidad)
        {
            const double USD_A_EUR = 0.9142;
            const double USD_A_JPY = 156.1341;
            const double USD_A_GBP = 0.7688;
            const double USD_A_CHF = 0.8830;

            double NativaSelecionada = 0, ExtranjeraSelecionada = 0;

            switch (monedaNativa)
            {
                case "(USD)":
                    NativaSelecionada = 1;
                    break;
                case "(EUR)":
                    NativaSelecionada = 1 / USD_A_EUR;
                    break;
                case "(JPY)":
                    NativaSelecionada = 1 / USD_A_JPY;
                    break;
                case "(GBP)":
                    NativaSelecionada = 1 / USD_A_GBP;
                    break;
                case "(CHF)":
                    NativaSelecionada = 1 / USD_A_CHF;
                    break;
            }
            switch (MonedaExtranjera)
            {
                case "(USD)":
                    ExtranjeraSelecionada = 1;
                    break;
                case "(EUR)":
                    ExtranjeraSelecionada = USD_A_EUR;
                    break;
                case "(JPY)":
                    ExtranjeraSelecionada = USD_A_JPY;
                    break;
                case "(GBP)":
                    ExtranjeraSelecionada = USD_A_GBP;
                    break;
                case "(CHF)":
                    ExtranjeraSelecionada = USD_A_CHF;
                    break;
            }

            double conversion = (cantidad * NativaSelecionada) * ExtranjeraSelecionada;
            lblResultado.Text = "Resultado: " + cantidad + " " + monedaNativa +" = " + conversion.ToString("0.0000") + " " + MonedaExtranjera;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblNativa.Text = "()";
            lblEstranjera.Text = "()";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!(ValidaNum(txtCantidad.Text)))
            {
                MessageBox.Show("El valor ingresado no es un numero", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                txtCantidad.Text = "";
                txtCantidad.BackColor = Color.Red;
                return;
            }
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            if ((cmbNativa.SelectedIndex == -1) || (cmbExtranjera.SelectedIndex == -1))
            {
                MessageBox.Show("Selecione una opcion de las divisas disponibles", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbNativa.SelectedIndex == cmbExtranjera.SelectedIndex)
            {
                MessageBox.Show("Las divisas selecionadas son iguales, No necesitan conversion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ConvertirMondeda(lblNativa.Text,lblEstranjera.Text, cantidad);



        }

        private void btnIntercambio_Click(object sender, EventArgs e)
        {
            int IndexTemporal = cmbNativa.SelectedIndex;
            cmbNativa.SelectedIndex = cmbExtranjera.SelectedIndex;
            cmbExtranjera.SelectedIndex = IndexTemporal;
        }

        private void cmbNativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MonedaSelecionada = Convert.ToString(cmbNativa.SelectedItem);
            CambioMoneda(MonedaSelecionada, 0);
        }

        private void cmbExtranjera_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MonedaSelecionada = Convert.ToString(cmbExtranjera.SelectedItem);
            CambioMoneda(MonedaSelecionada, 1);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidad.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
