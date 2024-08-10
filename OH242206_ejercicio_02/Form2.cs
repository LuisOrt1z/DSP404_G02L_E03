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

        public Form2(String text, string[,] cuentas, int cuentaSeleccionada)
        {
            InitializeComponent();
            txtnumeroCuentaRecibido = text;
            cuentasRecibidas = cuentas;
            cuentaseleccionadaRecibida = cuentaSeleccionada;
            lblnumCuenta.Text = txtnumeroCuentaRecibido;
        }

        

        private void rbtConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtConsulta.Checked)
            {
                string saldoDeCuenta = cuentasRecibidas[cuentaseleccionadaRecibida, 1];
                MessageBox.Show("El saldo actual de la cuenta es [" + saldoDeCuenta + "]", "SALDO");
                rbtConsulta.Checked = false;
            }


        }

        private void rbtRetiro_CheckedChanged(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            if (rbtRetiro.Checked)
            {

                if (input.ShowDialog() == DialogResult.OK)
                {

                    if (int.TryParse(input.valorEntrada, out int cantidad))
                    {

                        int saldo = int.Parse(cuentasRecibidas[cuentaseleccionadaRecibida, 1]);

                        if (cantidad <= saldo)
                        {
                            saldo -= cantidad;
                            cuentasRecibidas[cuentaseleccionadaRecibida, 1].ToString();
                            MessageBox.Show("se ha retirado [$" + cantidad + "] y su saldo actual es [$" + saldo + "]", "RETIRO COMPLETADO");
                            rbtRetiro.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("fondos insuficientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rbtRetiro.Checked = false;
                        }
                    }//if tryparse


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
                            rbtConsignacion.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("fondos insuficientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rbtConsignacion.Checked = false;
                        }
                    }//if tryparse
                    else
                    {
                        MessageBox.Show("ingrese valores permitidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rbtConsignacion.Checked = false;
                    }


                }//if de input dialog
                else
                {
                    rbtConsignacion .Checked = false;
                }
            }//if de radiobutton
        }

        private void rbtTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTransferencia.Checked)
            {
                FormTransferencia inputTransferencia = new FormTransferencia();

                if (inputTransferencia.ShowDialog() == DialogResult.OK) {
                    string cuentaDestino = inputTransferencia.CuentaDestino;
                    string cantidadTransferencia = inputTransferencia.CantidadTransferencia;

                    if (int.TryParse(cantidadTransferencia, out int cantidad))
                    {
                        bool cuentaEncontrada = false;

                        for (int i = 0; i < cuentasRecibidas.Length / 2; i++)
                        {
                            if (cuentasRecibidas[i, 0] == cuentaDestino)
                            {
                                cuentaEncontrada = true;
                                int saldoInicial = int.Parse(cuentasRecibidas[cuentaseleccionadaRecibida, 1]);
                                int saldoDestino = int.Parse(cuentasRecibidas[i, 1]);

                                if (cantidad <= saldoInicial)
                                {
                                    saldoInicial -= cantidad;
                                    saldoDestino += cantidad;

                                    cuentasRecibidas[cuentaseleccionadaRecibida, 1] = saldoInicial.ToString();
                                    cuentasRecibidas[i, 1] = saldoDestino.ToString();

                                    MessageBox.Show($"Se han transferido ${cantidad} a la cuenta {cuentaDestino}. " +
                                                    $"\nEl saldo actual es ${saldoInicial}.", "TRANSFERENCIA EXITOSA");
                                    rbtTransferencia.Checked = false;
                                }
                                else
                                {
                                    MessageBox.Show("Fondos insuficientes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    rbtTransferencia.Checked = false;
                                }
                                break;
                            }
                        }

                        if (!cuentaEncontrada)
                        {
                            MessageBox.Show("Cuenta destino no encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rbtTransferencia.Checked = false;
                        }
                    }
                }
                else
                {
                    rbtTransferencia.Checked = false;
                }
            }
        }

        private void rbtSalir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSalir.Checked) {
                MessageBox.Show("gracias por usar nuestro cajero" ,"SALIDA EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            
            }
        }
    }
}
