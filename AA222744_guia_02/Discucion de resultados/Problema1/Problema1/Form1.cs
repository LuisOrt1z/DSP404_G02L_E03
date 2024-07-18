using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Boolean ValidaNum(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidaNum(txtNumero.Text))
            {
                int numeroMax = Convert.ToInt32(txtNumero.Text);
                if (numeroMax <= 0)
                {
                    txtNumero.BackColor = Color.Red;
                    MessageBox.Show("El numero tiene que ser mayor de 0", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    txtNumero.Clear();
                    txtNumero.Focus();
                    return;
                }

                int num1 = 0, num2 = 1, numTemporal = 0;
                lstFibonacci.Items.Clear();
                while (num1 < numeroMax)
                {
                    lstFibonacci.Items.Add(num1);
                    numTemporal = num1;
                    num1 = num2;
                    num2 = numTemporal + num1;
                    
                }
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("s ingresar un número!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstFibonacci.Items.Clear();
            txtNumero.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }
    }
}
