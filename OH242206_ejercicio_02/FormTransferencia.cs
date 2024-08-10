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
    public partial class FormTransferencia : Form
    {
        public string valorEntrada { get; private set; }
        public string CuentaDestino { get; private set; }
        public string CantidadTransferencia { get; private set; }
        public FormTransferencia()
        {
            InitializeComponent();
            this.Width = 281;
            this.Height = 224;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("ingrese un valor de cuenta valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidadTransferencia.Text, out int cantidad))
            {
                MessageBox.Show("ingrese una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            } else if (cantidad < 0) {
                MessageBox.Show("no se pueden ingresar valores negativos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            CuentaDestino = txtDestino.Text;
            CantidadTransferencia = txtCantidadTransferencia.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}