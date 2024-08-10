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
    public partial class frmULAM : Form
    {
        public frmULAM()
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
            if (IsNumeric(txtnumero.Text))
            {
                int numero = Convert.ToInt32(txtnumero.Text);
                if(numero <= 1)
                {
                    txtnumero.BackColor = Color.Red;
                    MessageBox.Show("El numero tiene que ser mayor de 1", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    txtnumero.Clear();
                    txtnumero.Focus();
                    return;
                }
                lstLista.Items.Clear();
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        lstLista.Items.Add(numero + " / 2 = " + (numero/2));
                        numero = numero / 2;
                    }
                    else
                    {
                        lstLista.Items.Add(numero + " * 3 + 1 = " + ((numero * 3) + 1));
                        numero = (numero * 3) + 1;
                    }

                }
            }
            else
            {
                txtnumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtnumero.Clear();
                txtnumero.Focus();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            txtnumero.Text = "";
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtnumero.BackColor = Color.White;
        }
    }
}
