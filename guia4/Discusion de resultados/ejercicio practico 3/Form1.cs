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
        List<double> notas = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregarnota_Click(object sender, EventArgs e)
        {
            double nuevaNota;

            if (double.TryParse(txtnota.Text, out nuevaNota) && nuevaNota >= 0 && nuevaNota <= 10)
            {
                notas.Add(nuevaNota);
                MessageBox.Show("Nota agregada.");
                txtnota.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida entre 0 y 10.");
            }
        }

        private void btnmostrarpromedio_Click(object sender, EventArgs e)
        {
            if (notas.Count > 0)
            {
                int numAprobados = notas.Count(nota => nota >= 6.0);
                int numDeficientes = notas.Count(nota => nota < 5.0);
                double notaMasAlta = notas.Max();
                double notaMasBaja = notas.Min();
                double notaMedia = notas.Average();
                double porcentajeDeficientes = (double)numDeficientes / notas.Count * 100;

                lstpromedio.Items.Clear();
                lstpromedio.Items.Add("Porcentaje de deficientes:"+porcentajeDeficientes.ToString("F2")+"%");
                lstpromedio.Items.Add("Número de aprobados: "+numAprobados);
                lstpromedio.Items.Add("Nota más alta:"+notaMasAlta);
                lstpromedio.Items.Add("Nota más baja:"+notaMasBaja);
                lstpromedio.Items.Add("Nota media:"+notaMedia.ToString("F2"));
            }
            else
            {
                MessageBox.Show("No hay notas para mostrar.");
            }
        }
    }
}
