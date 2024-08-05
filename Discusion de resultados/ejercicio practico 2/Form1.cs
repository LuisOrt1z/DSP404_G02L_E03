using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_practico_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            int dimension = 0;

            if (! int.TryParse(txtdimension.Text, out dimension) || dimension <= 0) {
                MessageBox.Show("solo se permiten numeros enteros positivos","ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int[,] matriz = Generarmatrizaleatoria(dimension);
            int[,] transpuesta = calculartranspuesta(matriz);

            mostrarmatriz(dgvmatrizoriginal, matriz);
            mostrarmatriz(dgvtraspuesta,transpuesta);

        }//evento generar

        private int[,] Generarmatrizaleatoria(int dimension){

            Random random = new Random();
            int[,] matriz = new int[dimension, dimension];

            for (int i =0; i<dimension; i++) {
                for (int j = 0; j<dimension; j++)
                {
                    matriz[i,j] = random.Next(0,100);
                }
            }
                return matriz;
        }

        private int[,] calculartranspuesta(int[,] matriz)
        {
            int dimension = matriz.GetLength(0);
            int [,] transpuesta = new int[dimension, dimension];

            for (int i = 0; i <dimension; i++)
            {
                for (int j = 0; j< dimension; j++)
                {
                    transpuesta[j, i] =matriz[i,j];
                }
            }
            return transpuesta;
        }

        private void mostrarmatriz(DataGridView dgv, int[,] matriz) { 
        dgv.Rows.Clear();
            dgv.Columns.Clear();

            int dimension = matriz.GetLength(0);

            for (int i = 0;i<dimension; i++) {
                dgv.Columns.Add($"col{i}", $"Columna {i+1}" );
            }

            for (int i = 0; i<dimension; i++) {
                dgv.Rows.Add();
                for (int j = 0; j<dimension; j++) {
                    dgv.Rows[i].Cells[j].Value = matriz[i,j];
                }
            }
        
        }


    }
}
