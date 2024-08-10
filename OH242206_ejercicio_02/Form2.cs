using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form2 : Form
    {
        string txtnumeroCuentaRecibido;
        int cuentaseleccionadaRecibida;
        string[,] cuentasRecibidas;
        public Form2(String text, string[,]cuentas, int cuentaSeleccionada)
        {
            InitializeComponent();
            txtnumeroCuentaRecibido = text;
            cuentasRecibidas = cuentas;
            cuentaseleccionadaRecibida = cuentaSeleccionada;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblnumCuenta.Text = txtnumeroCuentaRecibido;

        }

        private void rbtConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtConsulta.Checked) {
                string saldoDeCuenta = cuentasRecibidas[cuentaseleccionadaRecibida,1];
                MessageBox.Show("El saldo actual de la cuenta es ["+saldoDeCuenta+"]","SALDO");
            }


        }

        private void rbtRetiro_CheckedChanged(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            if (rbtRetiro.Checked) {

                if (input.ShowDialog() == DialogResult.OK) {

                    if (int.TryParse(input.valorEntrada, out int cantidad)) {

                        int saldo = int.Parse(cuentasRecibidas[cuentaseleccionadaRecibida,1]);

                        if (cantidad <= saldo) {
                            saldo -= cantidad;
                            cuentasRecibidas[cuentaseleccionadaRecibida, 1].ToString();
                            MessageBox.Show("se ha retirado [$"+cantidad+"] y su saldo actual es [$"+saldo+"]", "RETIRO COMPLETADO");
                        }
                        else {
                            MessageBox.Show("fondos insuficientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }//if tryparse
                    else
                    {
                            MessageBox.Show("ingrese valores permitidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }//if de input dialog
                else
                {
                    rbtRetiro.Checked = false;
                }

            }//if de radiobutton


        }

        private void rbtConsignacion_CheckedChanged(object sender, EventArgs e)
        {
            FormConsignar input = new FormConsignar();

            if (rbtConsignacion.Checked)
            {

                if (input.ShowDialog() == DialogResult.OK)
                {

                    if (int.TryParse(input.valorEntrada, out int cantidad))
                    {

                        int saldo = int.Parse(cuentasRecibidas[cuentaseleccionadaRecibida, 1]);

                        if (cantidad <= saldo)
                        {
                            saldo += cantidad;
                            cuentasRecibidas[cuentaseleccionadaRecibida, 1].ToString();
                            MessageBox.Show("se ha consignado [$" + cantidad + "] y su saldo actual es [$" + saldo + "]", "RETIRO COMPLETADO");
                        }
                        else
                        {
                            MessageBox.Show("fondos insuficientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }//if tryparse
                    else
                    {
                        MessageBox.Show("ingrese valores permitidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }//if de input dialog

            }//if de radiobutton
        }
    }
}
