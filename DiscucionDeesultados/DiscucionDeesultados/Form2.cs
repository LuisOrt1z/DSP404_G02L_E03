using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscucionDeesultados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        public int[,] GenerarMatrizAleatoria(int limiteInferior, int limiteSuperior)
        {
            int[,] matriz = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(limiteInferior, limiteSuperior + 1);
                }
            }
            return matriz;
        }

        public void MostrarMatrizEnDataGridView(int[,] matriz, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = matriz.GetLength(1);
            dataGridView.RowCount = matriz.GetLength(0);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int limiteInferior = 1; // Valores de ejemplo
                int limiteSuperior = 100;

                int[,] matriz = GenerarMatrizAleatoria(limiteInferior, limiteSuperior);
                MostrarMatrizEnDataGridView(matriz, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
