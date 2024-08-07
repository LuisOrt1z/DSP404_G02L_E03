﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class frmReves : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmReves()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text);

                long r, div, reves = 0, multi = 1;
                txtNumero.Text = numero.ToString();
                if (numero >= 100000 & numero <= 999999)
                {
                    div = 100000;
                }
                else if (numero >= 10000 & numero <= 99999)
                {
                    div = 10000;
                }
                else if (numero >= 1000 & numero <= 9999)
                {
                    div = 1000;
                }
                else if (numero >= 100 & numero <= 999)
                {
                    div = 100;
                }
                else if (numero >= 10 & numero <= 99)
                {

                div = 10;
                }
                else
                {
                    MessageBox.Show("Numero fuera de rango(1-999999)", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }
                do
                {
    
                    r = numero / div;
      
                    numero = numero - r * div;
             
                    div = div / 10;
                  
                    reves = reves + (r * multi);
          
                    multi = multi * 10;
             
                } while (numero != 0);
                txtReves.Text = reves.ToString();
            }
            else
            {
                MessageBox.Show("El dato que ingreso no es un número", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }


        }//

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
        }
    }
}
