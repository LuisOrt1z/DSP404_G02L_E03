using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables 
            long factorial = 1;
            int i;
            //con la funcion IsNumeric verificamos que el TxtNumero contenga un dato numerico 
            if (IsNumeric(txtNumero.Text))
            {
                //ser realizar un for desde el número ingresado hasta llegar a uno 

                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    //se multiplica el factorial por todos los numeros menores 
                    //factorial= factorial*i; 
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();

            }

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
