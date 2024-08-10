using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Boolean ValidaNum(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((!ValidaNum(txtFilas.Text))||(!ValidaNum(txtColumnas.Text)))
            {
                MessageBox.Show("Un valor ingresado no es un numero", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int filas = Convert.ToInt32(txtFilas.Text);
            int columnas = Convert.ToInt32(txtColumnas.Text);
            if ((filas < 1 || filas > 10)||(columnas < 1 || columnas > 10))
            {
                MessageBox.Show("Un valor no esta en el rango de 1 a 10", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Random rng = new Random();

            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rng.Next(1000);
                }
            }
            dgvMatriz.Columns.Clear();
            dgvMatriz.ColumnCount = filas;
            dgvMatriz.RowCount = columnas;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvMatriz.Rows[j].Cells[i].Value = matriz[i, j];
                }
            }

            dgvTraspuesta.Columns.Clear();
            dgvTraspuesta.ColumnCount = columnas;
            dgvTraspuesta.RowCount = filas;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvTraspuesta.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
