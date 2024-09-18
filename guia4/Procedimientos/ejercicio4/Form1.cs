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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean validar(string nombre, string pwd) {
            string clave = nombre;
            string password = "usuario";
            DialogResult respuesta;

            if (nombre == clave && pwd == password) {
                respuesta = MessageBox.Show("Bienvenido" + "" + nombre, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (respuesta == DialogResult.OK) {
                    Form5 = formulario2 new Form5();
                    formulario2.Show();
                    return true;
                }
            }
            else {
                MessageBox.Show("Contraseña incorrecta","Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;  
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar(txtusuario.Text, txtpwd.Text)) {
                this.Hide();
            }
        }
    }
}
