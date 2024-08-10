using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> ListaNombres = new List<string>();
        public string NombreEditado = "";
        private void ActualizarLista(int orden)
        {
            lstNombres.Items.Clear();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            switch (orden)
            {
                case 0:
                    if (ListaNombres.Any())
                    {
                        foreach (string nombres in ListaNombres)
                        {
                            lstNombres.Items.Add(nombres);
                        }
                    }
                    break;
                case 1:
                    var AlfabeticoA_Z = ListaNombres.OrderBy(n => n).ToList();
                    if (ListaNombres.Any())
                    {
                        foreach (string nombres in AlfabeticoA_Z)
                        {
                            lstNombres.Items.Add(nombres);
                        }
                    }
                    break;
                case 2:
                    var AlfabeticoZ_A = ListaNombres.OrderByDescending(n => n).ToList();
                    if (ListaNombres.Any())
                    {
                        foreach (string nombres in AlfabeticoZ_A)
                        {
                            lstNombres.Items.Add(nombres);
                        }
                    }
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOrden.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre  = txtNombre.Text;
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nombre", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                txtNombre.Text = "";
                return;
            }
            foreach (string nombres in ListaNombres)
            {
                if (nombres == nombre)
                {
                    MessageBox.Show("Los nombres no se pueden repetir", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            ListaNombres.Add(nombre);
            txtNombre.Text = "";
            ActualizarLista(cmbOrden.SelectedIndex);
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLista(cmbOrden.SelectedIndex);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(lstNombres.SelectedItem);
            if (opcion == "")
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string NombreActual = Convert.ToString(lstNombres.SelectedItem);
            DialogResult confirmacion = MessageBox.Show("Esta seguro de eliminar a: " + NombreActual, "Eliminar nombre:",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (confirmacion == DialogResult.OK)
            {
                ListaNombres.Remove(NombreActual);
                ActualizarLista(cmbOrden.SelectedIndex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string NombreActual = Convert.ToString(lstNombres.SelectedItem);
            NombreEditado = "";
            Form2 Editar = new Form2();
            AddOwnedForm(Editar);
            Editar.selecionado = NombreActual;
            Editar.ShowDialog();

            if(NombreEditado != "")
            {
                foreach (string nombres in ListaNombres)
                {
                    if (nombres == NombreActual)
                    {
                        int indice = ListaNombres.IndexOf(nombres);
                        ListaNombres.RemoveAt(indice);
                        ListaNombres.Insert(indice, NombreEditado);
                        break;
                    }
                }
                ActualizarLista(cmbOrden.SelectedIndex);
            }

        }
    }
}
