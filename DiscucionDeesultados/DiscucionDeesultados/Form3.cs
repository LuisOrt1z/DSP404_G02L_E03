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
    public partial class Form3 : Form
    {
        private List<double> listaNotas = new List<double>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bynAgregarNota_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota) && nota >= 0 && nota <= 10)
            {
                listaNotas.Add(nota);
                listBoxNotas.Items.Add(nota); // Mostrar la nota agregada
                txtNota.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEstadisticas(listaNotas, listBoxResultados);
        }

        public void MostrarEstadisticas(List<double> notas, ListBox listBox)
        {
            // Validar que la lista no esté vacía
            if (notas == null || notas.Count == 0)
            {
                listBox.Items.Add("No hay notas para analizar.");
                return;
            }

            int totalEstudiantes = notas.Count;

            // Calcular el porcentaje de estudiantes deficientes (con notas menores a 5.0)
            int deficientes = notas.Count(nota => nota < 5.0);
            double porcentajeDeficientes = (double)deficientes / totalEstudiantes * 100;

            // Calcular el número de aprobados (con notas mayores o iguales a 6.0)
            int aprobados = notas.Count(nota => nota >= 6.0);

            // Identificar la nota más baja, la más alta, y la nota media
            double notaMinima = notas.Min();
            double notaMaxima = notas.Max();
            double promedio = notas.Average();

            // Mostrar los resultados en el ListBox
            listBox.Items.Clear();
            listBox.Items.Add($"Porcentaje de estudiantes deficientes (< 5.0): {porcentajeDeficientes:F2}%");
            listBox.Items.Add($"Número de aprobados (>= 6.0): {aprobados}");
            listBox.Items.Add($"Nota más baja: {notaMinima:F2}");
            listBox.Items.Add($"Nota más alta: {notaMaxima:F2}");
            listBox.Items.Add($"Nota media del grupo: {promedio:F2}");

        }
    }
}
