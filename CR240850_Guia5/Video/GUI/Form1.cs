using System;
using Video1_;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Venta venta = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            if (clientetextbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un cliente");
                clientetextbox.Focus();
                return;
            }

            venta = new Venta (clientetextbox.Text);
            detalledataGridView1.DataSource = venta.Productos;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("Debe asignar un cliente");
                clientetextbox.Focus();
                return;
            }

            if (idtextbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID");
                idtextbox.Focus(); 
                return;
            }

            int id = 0;
            if (!int.TryParse(idtextbox.Text, out id))
            {
                MessageBox.Show("Debe ingresar un ID numerico entero");
                idtextbox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Debe ingresar un ID mayor a cero");
                idtextbox.Focus();
                return;
            }

            if (descripciontextbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Descripcion");
                descripciontextbox.Focus();
                return;
            }

            if (preciotxt.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Precio");
                preciotxt.Focus();
                return;
            }

            decimal precio = 0;
            if (!decimal.TryParse(preciotxt.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un precio numerico");
                preciotxt.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor a cero");
                preciotxt.Focus();
                return;
            }

            if (Cantidadtextbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una cantidad");
                Cantidadtextbox.Focus();
                return;
            }

            float cantidad = 0;
            if (!float.TryParse(Cantidadtextbox.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar una cantidad numerica");
                Cantidadtextbox.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero");
                Cantidadtextbox.Focus();
                return;
            }

            Producto producto = new Producto();
            producto.ID = id;
            producto.Descripcion = descripciontextbox.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;
            venta.AgregarProductos(producto);
            detalledataGridView1.DataSource = null;
            detalledataGridView1.DataSource = venta.Productos;
            idtextbox.Text = string.Empty;
            descripciontextbox.Text = string.Empty;
            preciotxt.Text = string.Empty;
            Cantidadtextbox.Text = string.Empty;
            idtextbox.Focus();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, string.Format("Su cuenta es: {0:C2} ¿Desea Pagar?", venta.Total()), 
                "Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                return;
            }
            venta = null;
            clientetextbox.Text = string.Empty;
            clientetextbox.Focus();
            detalledataGridView1.DataSource = null;
        }
    }
}
