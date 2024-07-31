using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopractico2
{ 
    public partial class Form1 : Form
    {
        double[] numeros= new double[4];
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (i<=4)
            {
                if (double.TryParse(txtnumero.Text, out double numero)) {
                    numeros[i] = numero;
                    i += 1;
                }
                else {
                    MessageBox.Show("ingrese un numero valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("LIMITE MAXIMO DE CARACTERES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            }
            txtnumero.Clear();
        }

        private void btncalculoprom_Click(object sender, EventArgs e)
        {
            double promedio = numeros.Average();
            string promstring = promedio.ToString();
            lblresult.Text = promstring;

        }

        private void btncalculodesviacion_Click(object sender, EventArgs e)
        {
            double sumaderaices = 0;
            double promedio = numeros.Average();
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaderaices += Math.Pow(numeros[i] - promedio, 2);
            }
            double resultdesviacion = Math.Sqrt(sumaderaices / numeros.Length);
            // string resultadodesviacionstring = resultdesviacion.ToString();
            lbldeviar.Text = resultdesviacion.ToString("F2");
        }

        private void brnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            lblresult.Text = "";
            lbldeviar.Text = "";
            i = 0;
            Array.Clear(numeros, 0, numeros.Length);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
