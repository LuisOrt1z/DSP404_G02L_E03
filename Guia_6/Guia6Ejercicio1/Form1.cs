﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guia6Ejercicio1.VC230868;

namespace Guia6Ejercicio1
{
    public partial class Form1 : Form
    {
        List<clsDoctor> doctores;
        List<clsVendedor> vendedores;
        OpenFileDialog cuadroseleccion = new OpenFileDialog();
        public Form1() //constructor de clase Form1
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarcombobox();
            //crea las listas de doctores y vendedores
            doctores = new List<clsDoctor>();
            vendedores = new List<clsVendedor>();
            //Define filtros para el cuadro de seleccion, que mostrara solo imagenes JPG
            cuadroseleccion.Filter = "Imagenes de tipo JPG |*.jpg";
            //Inicia los controles para ingresar un nuevo Doctor o un nuevo Vendedor
            PrepararNuevoDoctor();
            PrepararNuevoVendedor();
        }
        private void llenarcombobox()
        {
            int c; //contador usos varios
                   //primero dias
            for (c = 1; c <= 31; c++)
            cmbDia.Items.Add(c);
            cmbDia.Text = DateTime.Now.Day.ToString();
            for (c = 1; c <= 12; c++) cmbMes.Items.Add(c);
            cmbMes.Text = DateTime.Now.Month.ToString();
            for (c = 1950; c <= DateTime.Now.Year; c++) cmbAnno.Items.Add(c);
            cmbAnno.Text = DateTime.Now.Year.ToString();
        }//fin metodo llenarcombox
        void PrepararNuevoDoctor()
        {
            txtNom.Clear();
            picFotoDoc.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAnno.SelectedIndex = 0;
            nudSueldo.Value = 1.00M;
            mtbCodDoctor.Clear();
            txtNom.Focus();
        }
        void PrepararNuevoVendedor()
        {
            //deja los controles listos para el proximo vendedor a ingresar
            txtNomV.Clear();
            picFotoVen.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            dtpFechaNac.Value = DateTime.Now;
            dtpFechaC.Value = DateTime.Now;
            txtNomV.Focus();
        }
        public void MostrarLista_Doctores()
        {
            //Recorre coleccion doctores, para mostrar datos en datagrid
            int cm = 0;
            int i;
            //se ajusta el titulo de la ultima columna de grilla
            dataGridView1.Columns[4].HeaderText = "Codigo";
            dataGridView1.Rows.Clear();
            //se llena la grilla con filas para los doctores registrados
            for (i = 0; i < doctores.Count; i++)
                dataGridView1.Rows.Add();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                //De cada objeto Doctor de la List, extrae valores de sus campos privados
                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = doctores[cm].nombreempleado;
                fila.Cells[2].Value = Image.FromFile(doctores[cm].URLfoto);
                fila.Cells[3].Value = doctores[cm].fecha_nacimiento;
                fila.Cells[4].Value = doctores[cm].codigodoctor;
                cm++;
            }
        }
        public void MostrarLista_Vendedores()
        {
            //recorre coleccion vendedores, para mostrar datos en datagrid
            int cm = 0;
            int i;
            //Ajusta el titulo de la ultima columna de grilla
            dataGridView1.Columns[4].HeaderText = "Fecha Contrato";
            dataGridView1.Rows.Clear();
            //se llena la grilla con filas para los vendedores registrados
            for (i = 0; i < vendedores.Count; i++)
                dataGridView1.Rows.Add();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = vendedores[cm].nombreempleado;
                fila.Cells[2].Value = Image.FromFile(vendedores[cm].URLfoto);
                fila.Cells[3].Value = vendedores[cm].fecha_nacimiento;
                fila.Cells[4].Value = vendedores[cm].FechaContrato;
                cm++;
            }
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = new clsDoctor(); //objeto de la clase derivada
                                                //toma los datos de los controles del form para definir a objeto Doctor
            Doctor.nombreempleado = txtNom.Text;
            Doctor.asignarfechanac(cmbAnno.Text, cmbMes.Text, cmbDia.Text);
            Doctor.sueldobase = Convert.ToSingle(nudSueldo.Value);
            Doctor.codigodoctor = mtbCodDoctor.Text;
            //envia url de foto seleccionada por usuario
            Doctor.URLfoto = picFotoDoc.ImageLocation;
            //intenta agregar nuevo doctor a coleccion de Doctores
            if (Doctor.DatossonCorrectos())
            {
                doctores.Add(Doctor);
                MessageBox.Show("Doctor " + Doctor.nombreempleado + " se ha agregado a lalista","Excelente!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Inicia los controles para ingresar un nuevo Doctor
                 PrepararNuevoDoctor();
            }
            else
                MessageBox.Show("Datos incompletos");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se invoca un objeto de clase OpenFileDialog, para que usuario seleccione archivo
            //de imagen y asi, se cargue en el cuadro de imagen
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoDoc.ImageLocation = cuadroseleccion.FileName;
            }

        }

        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            clsVendedor Vendedor = new clsVendedor(); //objeto de la clase derivada
                                                      //Define valores brindados por usuario hacia objeto vendedor
            Vendedor.nombreempleado = txtNomV.Text;
            Vendedor.sueldobase = 2000; //asigna un sueldo fijo de $2000;
            Vendedor.asignarfechanac(dtpFechaNac.Value);
            Vendedor.FechaContrato = dtpFechaC.Value;
            //envia url de foto seleccionada por usuario
            Vendedor.URLfoto = picFotoVen.ImageLocation;
            //agrega vendedor actual hacia list de vendedores
            vendedores.Add(Vendedor);
            //deja controles listos para el prox. vendedor a registrar
            PrepararNuevoVendedor();
        }

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            //Selecciona un archivo de imagen para el vendedor
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoVen.ImageLocation = cuadroseleccion.FileName;
            }

        }
    }
    }
