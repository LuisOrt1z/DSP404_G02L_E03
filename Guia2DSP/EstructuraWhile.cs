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
    public partial class EstructuraWhile : Form
    {
        public EstructuraWhile()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Variables
            int stock;
            int cantPersonas, cantEntrega;

            stock = Convert.ToInt32(txtStockInicial.Text);
            cantPersonas = 0;

            while (stock >=10) 
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada personas " + (cantPersonas + 1),"Reparto de vacunas"));
                //Validacion
                if (stock>=cantEntrega)
                {
                    cantPersonas = cantPersonas + 1;
                    stock = stock - cantEntrega;
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock","Reparto de vacunas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("El stock es inferior a 10 und","Reparto de vacunas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtStockFinal.Text = Convert.ToString(stock);
            txtCantidadPersonas.Text = Convert.ToString(cantPersonas);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtStockInicial.Clear();
            txtStockFinal.Clear();
            txtCantidadPersonas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
