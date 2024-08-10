using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarNotas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNotas.ColumnCount = 7;
            dgvNotas.Columns[0].Name = "Alumno";
            dgvNotas.Columns[1].Name = "Lenguaje";
            dgvNotas.Columns[2].Name = "Matematicas";
            dgvNotas.Columns[3].Name = "Ciencias";
            dgvNotas.Columns[4].Name = "Sociales";
            dgvNotas.Columns[5].Name = "Ingles";
            dgvNotas.Columns[6].Name = "Media";
            ActualizarNotas();
        }
        private void ActualizarNotas()
        {
            Random Rng = new Random();
            
            
            int[,] Notas = new int[6, 5];
            Random random = new Random();
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                int numeroAsignaturas = random.Next(2, 6); 
                for (int j = 0; j < numeroAsignaturas; j++)
                {
                    Notas[i, j] = random.Next(2, 11); 
                }
            }
            dgvNotas.Rows.Clear();
            dgvNotas.RowCount = Notas.GetLength(0);
            string[] Nombres = new string[7];
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                int contador = 0;
                double media = 0;
                Nombres[i] = "Alumno " + (i + 1);
                dgvNotas.Rows[i].Cells[0].Value = Nombres[i];
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    if(j+1 <= Notas.GetLength(1))
                    {
                        if (Notas[i, j] != 0)
                        {
                            dgvNotas.Rows[i].Cells[j + 1].Value = Notas[i, j];
                            media += Notas[i, j];
                            contador++;
                        }
                        else
                        {
                            dgvNotas.Rows[i].Cells[j + 1].Value = "No inscrita";
                        }
                        
                    }
                }
                dgvNotas.Rows[i].Cells[6].Value = (media / contador).ToString("F2");
                media = 0;
                contador = 0;
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
