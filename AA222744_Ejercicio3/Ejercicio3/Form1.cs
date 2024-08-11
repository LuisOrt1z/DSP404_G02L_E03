using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string NombreEditado = "";
        public DateTime FechaEditada;
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
            CargarTareas("ListaTareas.txt");
        }
        private void CargarTareas(string archivo)
        {
            if (File.Exists(archivo))
            {
                StreamReader reader = new StreamReader(archivo);
                string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');
                        string nombre = datos[0];
                        DateTime fechaLimite = DateTime.Parse(datos[1]);
                        bool com = bool.Parse(datos[2]);

                        Tarea NuevaTarea = new Tarea();
                        NuevaTarea.Datos(nombre, fechaLimite);
                        NuevaTarea.Completa = com;
                        ListaTareas.Add(NuevaTarea);
                    }
                

                ActualizarListas(TipoFiltro());
            }
        }
        private void ActualizarListas(int filtro)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCompletada.Enabled = false;
            btnDesmarcar.Enabled = false;
            lstTareas.Items.Clear();
            lstCompletadas.Items.Clear();
            var Completas = ListaTareas.Where(n => n.Completa == true).ToList();
            var Pendientes = ListaTareas.Where(n => n.Completa == false).ToList();
            switch (filtro)
            {
                case 0:
                    
                    if (Pendientes.Any())
                    {
                        foreach (Tarea Lista in Pendientes)
                        {
                            lstTareas.Items.Add(Lista.Nombre + "| " + Lista.Fecha.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                        }
                    }
                    break;
                case 1:
                    var AlfabeticoA_Z = Pendientes.OrderBy(n => n.Nombre).ToList();
                    if (AlfabeticoA_Z.Any())
                    {
                        foreach (Tarea Lista in AlfabeticoA_Z)
                        {
                            lstTareas.Items.Add(Lista.Nombre + "| " + Lista.Fecha.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                        }
                    }
                    break;
                case 2:
                    var AlfabeticoZ_A = Pendientes.OrderByDescending(n => n.Nombre).ToList();
                    if (AlfabeticoZ_A.Any())
                    {
                        foreach (Tarea Lista in AlfabeticoZ_A)
                        {
                            lstTareas.Items.Add(Lista.Nombre + "| " + Lista.Fecha.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                        }
                    }
                    break;
                case 3:
                    var FechaCercana = Pendientes.OrderBy(n => n.Fecha).ToList();
                    if (FechaCercana.Any())
                    {
                        foreach (Tarea Lista in FechaCercana)
                        {
                            lstTareas.Items.Add(Lista.Nombre + "| " + Lista.Fecha.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                        }
                    }
                    break;
                case 4:
                    var FechaLegana = Pendientes.OrderByDescending(n => n.Fecha).ToList();
                    if (FechaLegana.Any())
                    {
                        foreach (Tarea Lista in FechaLegana)
                        {
                            lstTareas.Items.Add(Lista.Nombre + "| " + Lista.Fecha.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                        }
                    }
                    break;
            }

            if (Completas.Any())
            {
                foreach (Tarea Lista in Completas)
                {
                    lstCompletadas.Items.Add(Lista.Nombre + "| " + Lista.Fecha);
                }
            }
            GuardarTareas("ListaTareas.txt");


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now.Date;
            if (nombre == "")
            {
                MessageBox.Show("La tarea tiene que tener un nombre", "Informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNombre.Clear();
                txtNombre.Focus();
                return;
            }
            if (fecha <= fechaActual)
            {
                MessageBox.Show("La fecha ingresada no puede ser anterior a la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Tarea Lista in ListaTareas)
            {
                if (Lista.Nombre == nombre)
                {
                    MessageBox.Show("Los nombres de las tareas no se pueden repetir", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            Tarea NuevaTarea = new Tarea();
            NuevaTarea.Datos(nombre, fecha);
            ListaTareas.Add(NuevaTarea);
            GuardarTareas("ListaTareas.txt");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(lstTareas.SelectedItem);
            if (opcion == "")
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCompletada.Enabled = false;
                return;
            }
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCompletada.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string NombreActual = Convert.ToString(lstTareas.SelectedItem);
            string[] partes = NombreActual.Split('|');
            string resultado = partes[0];
            DialogResult confirmacion = MessageBox.Show("Esta seguro de eliminar a: " + resultado, "Eliminar nombre:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmacion == DialogResult.OK)
            {
                foreach (Tarea nombres in ListaTareas)
                {
                    if (nombres.Nombre == resultado)
                    {
                        ListaTareas.Remove(nombres);
                        break;
                    }
                }
            }
            ActualizarListas(TipoFiltro());
        }

        private void btnCompletada_Click(object sender, EventArgs e)
        {
            string NombreActual = Convert.ToString(lstTareas.SelectedItem);
            string[] partes = NombreActual.Split('|');
            string resultado = partes[0];
            foreach (Tarea nombres in ListaTareas)
            {
                if (nombres.Nombre == resultado)
                {
                    nombres.Completa = true;
                    break;
                }
            }
            ActualizarListas(TipoFiltro());
        }

        private void lstCompletadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(lstCompletadas.SelectedItem);
            if (opcion == "")
            {
                btnDesmarcar.Enabled = false;
                return;
            }
            btnDesmarcar.Enabled = true;
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            string NombreActual = Convert.ToString(lstCompletadas.SelectedItem);
            string[] partes = NombreActual.Split('|');
            string resultado = partes[0];
            foreach (Tarea nombres in ListaTareas)
            {
                if (nombres.Nombre == resultado)
                {
                    nombres.Completa = false;
                    break;
                }
            }
            ActualizarListas(TipoFiltro());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 Editar = new Form2();
            string NombreActual = Convert.ToString(lstTareas.SelectedItem);
            NombreEditado = "";
            FechaEditada = DateTime.Now.Date;
            string[] partes = NombreActual.Split('|');
            string resultado = partes[0];
            

            foreach (Tarea nombres in ListaTareas)
            {
                if (nombres.Nombre == resultado)
                {
                    Editar.selecionado = nombres.Nombre;
                    break;
                }
            }
            AddOwnedForm(Editar);
            Editar.ShowDialog();
            if (NombreEditado != "" || FechaEditada != DateTime.Now.Date)
            {
                Tarea NuevaTarea = new Tarea();
                
                foreach (Tarea nombres in ListaTareas)
                {
                    if (nombres.Nombre == resultado)
                    {
                        int indice = ListaTareas.IndexOf(nombres);
                        ListaTareas.RemoveAt(indice);
                        NuevaTarea.Datos(NombreEditado, FechaEditada);
                        ListaTareas.Insert(indice, NuevaTarea);
                        break;
                    }
                }
                ActualizarListas(TipoFiltro());
            }
        }
        private void GuardarTareas(string archivo)
        {
            StreamWriter writer = new StreamWriter(archivo, true);
            foreach (Tarea tarea in ListaTareas)
            {
                writer.WriteLine(tarea.Nombre+"|"+tarea.Fecha+"|"+tarea.Completa);
            }
        }
    }
}
