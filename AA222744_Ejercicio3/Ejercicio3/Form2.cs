using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ejercicio3.Form1;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string selecionado = "";
        public bool editado = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre Actual: " + selecionado;
            txtName.Text = selecionado;
            dtpFecha.Value = actuFecha(selecionado);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form1 frm = Owner as Form1;
            string nombre = txtName.Text;
            DateTime fecha = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now.Date;
            if (nombre == "")
            {
                MessageBox.Show("La tarea tiene que tener un nombre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtName.Focus();
                return;
            }
            if (fecha <= fechaActual)
            {
                MessageBox.Show("La fecha ingresada no puede ser anterior o igual a la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (editado == true)
            {
                foreach (Tarea Lista in frm.ListaTareas)
                {
                    if (Lista.Nombre == nombre)
                    {
                        MessageBox.Show("Los nombres de las tareas no se pueden repetir", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

            }
            

            frm.NombreEditado = nombre;
            Close();
        }
        public DateTime actuFecha(string nombre)
        {
            Form1 frm = Owner as Form1;
            foreach (Tarea Lista in frm.ListaTareas)
            {
                if (Lista.Nombre == nombre)
                {
                    return Lista.Fecha;
                }
            }
            return DateTime.Now.Date;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selecionado != txtName.Text)
            {
                editado = true;
            }
            else
            {
                editado = false;
            }
            
        }
    }
}
