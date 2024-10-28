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
    public partial class Form1 : Form
    {
        private int[] lista = new int[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void CrearListaVacia()
        {
            lista = new int[0]; 
            MessageBox.Show("Lista vacía creada.");
        }

       
        private void MostrarLista()
        {
            listBox1.Items.Clear(); 

            foreach (int elemento in lista)
            {
                listBox1.Items.Add(elemento); 
            }
        }

       
        private void InsertarElemento(int valor)
        {
            Array.Resize(ref lista, lista.Length + 1);  lista[lista.Length - 1] = valor;   }

       
        private void RemoverElemento()
        {
            if (lista.Length > 0)
            {
                int[] nuevaLista = new int[lista.Length - 1];
                Array.Copy(lista, 1, nuevaLista, 0, nuevaLista.Length); 
                lista = nuevaLista;
            }
            else
            {
                MessageBox.Show("La lista está vacía, no hay elementos para remover.");
            }
        }

        
        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            CrearListaVacia();
        }

        
        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        
        private void btnInsertarElemento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtElemento.Text, out int valor))  {
                InsertarElemento(valor);
                MessageBox.Show("Elemento insertado: " + valor);
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
        }

       
        private void btnRemoverElemento_Click(object sender, EventArgs e)
        {
            RemoverElemento();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
