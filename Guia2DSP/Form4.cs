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
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.ClearSelected();
            txtnumero.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Variables
            int ULAM;
            int numero;

            numero = Convert.ToInt32(txtnumero.Text);
            ULAM = 0;

            while (ULAM != 1)
            {
                //Validacion
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
            }
            MessageBox.Show("El numero no es positivo, ni mayor a 0", "Numeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstLista.Text = Convert.ToString(ULAM);
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
