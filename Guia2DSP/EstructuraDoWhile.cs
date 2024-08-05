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
    public partial class EstructuraDoWhile : Form
    {
        public EstructuraDoWhile()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Variable
            int cantAlumnos, nota;
            Double promedio = 0;

            cantAlumnos = Convert.ToInt32(txtCantAlumnos.Text);

            for (int i = 1; i <= cantAlumnos; i++)
            {
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno " + i, "Registro Notas"));
                } while (nota < 0 || nota > 20);
                promedio = promedio + nota;
            }

            txtPromedio.Text = Convert.ToString(promedio/cantAlumnos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantAlumnos.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
