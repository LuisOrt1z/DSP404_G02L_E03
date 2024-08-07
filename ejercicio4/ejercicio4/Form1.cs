using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class frmULAM : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numeroingresado = txtnumero.Text.Trim();
            int numeroingresadoint = int.Parse(numeroingresado);

            while (numeroingresadoint!=1){

                if (numeroingresadoint % 2 ==0){
                    numeroingresadoint /= 2;
                }
                else
                {
                    numeroingresadoint = numeroingresadoint * 3 + 1;
                }

                lslLista.Items.Add(numeroingresadoint);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            lslLista.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
