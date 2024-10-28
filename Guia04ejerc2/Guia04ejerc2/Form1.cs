﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia04ejerc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int contaventas;

        public void inicializarControles()
        {
            /*prepara entorno de trabajo inicial al cargo Form
 Mostrara a la pagina 1 del TabControl1 */
            tabControl1.TabPages[0].Text = "Ventas efectuadas";
            tabControl1.TabPages[1].Text = "Estadisticas de venta";
            tabControl1.SelectedIndex = 0;
            //configura a DatagriView
            dataGridView1.ReadOnly = true;
            //Desde coleccion colums, agrega 3 columnas
            dataGridView1.Columns.Add("numeventa", "#");
            dataGridView1.Columns.Add("montoventa", "Monto ($)");
            dataGridView1.Columns.Add("fechaventa", "Fecha Venta");
            dataGridView1.Columns.Add("Trime", "Trimestral(1-4)");
            /*configura a DataTimePicker
            Limita rango de fechas a escoger por usuario*/
            dateTimePicker1.MaxDate = Convert.ToDateTime("31/12/2015");
            dateTimePicker1.MinDate = Convert.ToDateTime("01/01/2014");
            //establece fechas a mostrar (dentro del rango anterior)
            dateTimePicker1.Value = Convert.ToDateTime("01/01/2015");
            label3.Text = "Totales ventas promedio por trimestre";
            maskedTextBox1.Focus();
        }

        public void registrarVenta(decimal MontoVe, DateTime Fecha)
        {
            /*Agrega fila con datos de la venta realizada,
            asi como lo clasifica en un trimestre (1-4) del año*/
            int Trimestre;
            //determina el trimestre de parámetros fecha recibido
            switch (Convert.ToInt32(Fecha.Month))
            {
                case 1:
                case 2:
                case 3:
                    Trimestre = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    Trimestre = 2;
                    break;
                case 7:
                case 8:
                case 9:
                    Trimestre = 3;
                    break;
                default:
                    Trimestre = 4;
                    break;
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[contaventas].Cells[0].Value = contaventas + 1;
            dataGridView1.Rows[contaventas].Cells[1].Value = MontoVe;
            dataGridView1.Rows[contaventas].Cells[2].Value = Fecha;
            dataGridView1.Rows[contaventas].Cells[3].Value = Trimestre;
            contaventas += 1;
        }

        public void EvaluacionTrimestral()
        {
            decimal[] TotVentaTrim = new decimal[5];
            int c;
            int tri;
            //Primero determina total venta ($) por trimestre
            for (c = 0; c <= (contaventas - 1); c++)
            {
                /*Recorre c/fila del frid, para comparar el #Trimestre
                de c/venta registrada*/
                tri = Convert.ToInt32(dataGridView1.Rows[c].Cells["Trime"].Value);
                /*Este numero de trimestre se aprovecha para acceder a posicion
                dentro del arreglo TotVentaTrim() aqui acumulo Monto venta de la celda
               "montoventa" */
                decimal x =
               Convert.ToDecimal(dataGridView1.Rows[c].Cells["montoventa"].Value);
                TotVentaTrim[tri] = TotVentaTrim[tri] + x;
            }
            for (c = 1; c < 5; c++)
            {
                listBox1.Items.Add("Trimestre" + Convert.ToString(c) + ":$" +
               Convert.ToString(TotVentaTrim[c]));
            }
        }

        public void ValidarDatos()
        {
            //confirmar que usuario escribio datos correctos
            decimal montov;
            //Registra venta en la fecha indicada por usuario
            montov = Convert.ToDecimal(maskedTextBox1.Text);
            //invoca a subrutina, enviando parámetros por valor
            registrarVenta(montov, dateTimePicker1.Value);
            //reinicia controles para nueva venta
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvaluacionTrimestral();
            tabControl1.SelectedIndex = 1;
            //Bloquea ingreso a controles del contenedor Groupbox
            groupBox1.Enabled = false;
        }
    }
}
