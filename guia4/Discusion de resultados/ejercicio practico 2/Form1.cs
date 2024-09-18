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

        private void btngenerarmatriz_Click(object sender, EventArgs e)
        {
            int limiteInferior, limiteSuperior;

            if (int.TryParse(txtlimiteinferior.Text, out limiteInferior) &&
                int.TryParse(txtlimitesuperior.Text, out limiteSuperior) &&
                limiteInferior <= limiteSuperior)
            {
                Random rand = new Random();
                int[,] matriz = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matriz[i, j] = rand.Next(limiteInferior, limiteSuperior + 1);
                    }
                }
                dataGridMatriz.ColumnCount = 5;
                dataGridMatriz.RowCount = 5;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridMatriz.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese límites válidos.");
            }
        }
    }
}
