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
    public partial class FormConsignar : Form
    {
        public string valorEntrada { get; private set; }

        public FormConsignar()
        {
            InitializeComponent();
            this.Width = 300;
            this.Height = 170;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormConsignar_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCantidadConsigacion.Text))
            {
                MessageBox.Show("ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtCantidadConsigacion.Text, out int cantidad))
            {
                MessageBox.Show("ingrese una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (cantidad < 0)
            {
                MessageBox.Show("no se pueden ingresar valores negativos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            valorEntrada = txtCantidadConsigacion.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }
    }
}
