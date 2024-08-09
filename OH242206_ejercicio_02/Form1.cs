using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        private string[,] cuentas = new string[3, 2]{
            { "1000001", "400" },
            { "1000002", "200" },
            { "1000004", "500" }
    };
        bool cuentaHallada = false;
        int cuentaSeleccionada = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String numeroDeCuenta = txtnumCuenta.Text;
            //MessageBox.Show("la cuenta no ha sido encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (int.TryParse(numeroDeCuenta, out int result)) {

                for (int i=0; i<cuentas.GetLength(0); i++) {

                    if (cuentas[i,0]==numeroDeCuenta) {
                        cuentaHallada = true;
                        cuentaSeleccionada = i;
                        MessageBox.Show("ha ingresado con exito, bienvenido!!", "INGRESO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Form2 form2 = new Form2(numeroDeCuenta);
                        form2.Show();
                        this.Hide();
                    }

                }
                if (!cuentaHallada)
                {
                    MessageBox.Show("la cuenta no ha sido encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else {

                MessageBox.Show("valor invalido, intente de nuevo", "ADVERTENICA", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnumCuenta.Clear();
        }
    }
}
