using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Tarea
        {
            public string Nombre { get; set; }
            public DateTime Fecha { get; set; }
            public bool Completa { get; set; }
            public void Datos(string nombre, DateTime fechaLimite)
            {
                Nombre = nombre;
                Fecha = fechaLimite;
                Completa = false;
            }
        }
        public List<Tarea> ListaTareas = new List<Tarea>();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;
        }
        private void ActualizarListas(int filtro)
        {
            lstTareas.Items.Clear();
            lstCompletadas.Items.Clear();
            var Completas = ListaTareas.Where(n => n.Completa == true).ToList();
            switch (filtro)
            {
                case 0:
                    var Pendientes = ListaTareas.Where(n => n.Completa == false).ToList();
                    if (Pendientes.Any())
                    {
                        foreach (Tarea Lista in Pendientes)
                        {
                            lstTareas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                        }
                    }
                    break;
                case 1:
                    var AlfabeticoA_Z = ListaTareas.OrderBy(n => n.Nombre).ToList();
                    if (AlfabeticoA_Z.Any())
                    {
                        foreach (Tarea Lista in AlfabeticoA_Z)
                        {
                            lstTareas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                        }
                    }
                    break;
                case 2:
                    var AlfabeticoZ_A = ListaTareas.OrderByDescending(n => n.Nombre).ToList();
                    if (AlfabeticoZ_A.Any())
                    {
                        foreach (Tarea Lista in AlfabeticoZ_A)
                        {
                            lstTareas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                        }
                    }
                    break;
                case 3:
                    var FechaCercana = ListaTareas.OrderBy(n => n.Fecha).ToList();
                    if (FechaCercana.Any())
                    {
                        foreach (Tarea Lista in FechaCercana)
                        {
                            lstTareas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                        }
                    }
                    break;
                case 4:
                    var FechaLegana = ListaTareas.OrderByDescending(n => n.Fecha).ToList();
                    if (FechaLegana.Any())
                    {
                        foreach (Tarea Lista in FechaLegana)
                        {
                            lstTareas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                        }
                    }
                    break;
            }

            if (Completas.Any())
            {
                foreach (Tarea Lista in Completas)
                {
                    lstCompletadas.Items.Add(Lista.Nombre + " <|> " + Lista.Fecha);
                }
            }

            

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea NuevaTarea = new Tarea();
            NuevaTarea.Datos(txtNombre.Text,dtpFecha.Value);
            ListaTareas.Add(NuevaTarea);
            ActualizarListas(TipoFiltro());

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListas(TipoFiltro());
        }
        private int TipoFiltro()
        {
            string filtro = Convert.ToString(cmbFiltro.SelectedItem);
            switch (filtro)
            {
                case "Ninguno":
                    return 0;
                case "Nombre(A - Z)":
                    return 1;
                case "Nombre(Z- A)":
                    return 2;
                case "Fecha(Mas cercanas)":
                    return 3;
                case "Fecha(Mas leganas)":
                    return 4;
            }
            return 0;
        }
    }
}
