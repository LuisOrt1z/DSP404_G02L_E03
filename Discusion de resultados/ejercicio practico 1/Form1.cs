using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_practico_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            string nombre = txtingreso.Text;
            if (!string.IsNullOrEmpty(nombre)) {
                lstnombres.Items.Add(nombre);
                txtingreso.Clear();

            }
            else {
                MessageBox.Show("campo vacio, ingrese un nombre");
            }

        }//evento añadir

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (lstnombres.SelectedItem!=null) { 
                lstnombres.Items.Remove(lstnombres.SelectedItem);

            }
            else {
                MessageBox.Show("sin seleccionar elementos, seleccione uno ");
            }


        }//evento borrar

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (lstnombres.SelectedItem != null) { 
                string nombrenuevo = txtingreso.Text;

                if (!string.IsNullOrEmpty(nombrenuevo)) {
                    int i = lstnombres.SelectedIndex;
                    lstnombres.Items[i] = nombrenuevo;
                    txtingreso.Clear();

                }
                else {
                    MessageBox.Show("campo vacio, ingrese un nuevo nombre");                
                }

            }
            else {
                MessageBox.Show("sin seleccionar, seleccione un nombre a modificar");            
            }

        }//evento modificar

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
