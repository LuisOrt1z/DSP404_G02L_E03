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
    public partial class Tabla_aritmetica : Form
    {
        public Tabla_aritmetica()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Variables
            int numero;
            double suma, resta, multi, div;

            numero = Convert.ToInt32(txtnumero.Text);

            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomulti.Items.Clear();
            cbodiv.Items.Clear();

            // Bucle for
            for (int i = 1; i < 12; i = i + 1) 
            {
                suma = numero + i;
                resta = numero - i;
                multi = numero * i;
                div = numero / i;
                // Resultados de combobox
                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomulti.Items.Add(numero + " * " + i + " = " + multi);
                cbodiv.Items.Add(numero + " / " + i + " = " + div);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomulti.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();
        }
    }
}
