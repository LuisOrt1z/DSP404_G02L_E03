using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopractico1
{
    public partial class frmfibonacci : Form
    {
        public frmfibonacci()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            string numero = txtboxnum.Text;

            int a =0, b = 1;

            if(int.TryParse(numero, out int num)&&num>=0)
            {
                while (a<=num)
                {
                    lslNumeros.Items.Add(a);
                    int temporal = a;
                    a = b;
                    b = temporal + b;
                }
      
            }
            else {
                MessageBox.Show("el numero es invalido","ingrese otro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnlimpiaf_Click(object sender, EventArgs e)
        {
            txtboxnum.Clear();
            lslNumeros.Items.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
