using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Login : Form
    {
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContra.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="usuario" && txtContra.Text == "admin")
            { Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else 
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUsuario.Clear();
                txtContra.Clear();
            }
        }
    }
}
