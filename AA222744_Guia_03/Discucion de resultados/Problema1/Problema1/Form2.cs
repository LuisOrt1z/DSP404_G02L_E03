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
    public partial class Form2 : Form
    {
        public string selecionado = "";
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre Actual: "+selecionado;
            txtName.Text = selecionado;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form1 frm = Owner as Form1;
            string cambio = txtName.Text;
            if (cambio == "")
            {
                MessageBox.Show("Ingrese un nombre", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                txtName.Text = "";
                return;
            }
            foreach (string nombres in frm.ListaNombres)
            {
                if (nombres == cambio)
                {
                    MessageBox.Show("El nombre no tiene ningun cambio o se repite", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            frm.NombreEditado = cambio;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
