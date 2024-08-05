using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_practico_3
{
    public partial class Form1 : Form
    {
        private const int numeroAlumnos = 6;
        private const int maximoAsignaturas = 5;
        public Form1()
        {
            InitializeComponent();
            dgvnotas.Columns.Add("Alumno","Alumno");
            for (int j =0; j<maximoAsignaturas; j++) {
                dgvnotas.Columns.Add("Asignatura"+(j+1), "Asignatura"+(j+1));
            }
            dgvnotas.Columns.Add("promedio","promedio");

            for (int i = 0; i<numeroAlumnos; i++) {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvnotas);
                row.Cells[0].Value = "Alumno" + (i+1);
                dgvnotas.Rows.Add(row);
            }
        
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            for (int i =0; i<numeroAlumnos; i++) {
                double suma = 0;
                int numnotas = 0;

                for (int j = 1; j<=maximoAsignaturas; j++) {
                    if (double.TryParse(dgvnotas.Rows[i].Cells[j].Value.ToString(),out double nota)) {
                        suma += nota;
                        numnotas++;
                    
                    }
                }

                double prom = 0;
                if (numnotas>0){
                    prom = suma / numnotas;
                }
                dgvnotas.Rows[i].Cells[maximoAsignaturas + 1].Value = prom.ToString("F2");
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
