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
        int[] lista = new int[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            lista = new int[0];
            MessageBox.Show("Lista vacía creada.");
        }

        private void btnMostrarElementos_Click(object sender, EventArgs e)
        {
                lstNumeros.Items.Clear();
            foreach (var elemento in lista) {
                lstNumeros.Items.Add(elemento);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int nuevoElemento;
            if (int.TryParse(txtnumero.Text, out nuevoElemento))
            {
                Array.Resize(ref lista, lista.Length + 1);
                lista[lista.Length - 1] = nuevoElemento;
                MessageBox.Show("Elemento insertado.");
                txtnumero.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lista.Length > 0)
            {
                for (int i = 1; i < lista.Length; i++)
                {
                    lista[i - 1] = lista[i];
                }
                Array.Resize(ref lista, lista.Length - 1);
                MessageBox.Show("Primer elemento removido.");
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }
    }
}
