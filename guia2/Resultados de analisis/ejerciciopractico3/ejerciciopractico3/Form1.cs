using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopractico3
{
    public partial class Form1 : Form { 
        List<double> numeros = new List<double>();
        double sumNegativos ;
        int countPositivos ;
        int countNegativos ;
        int countCeros ;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtboxnums.Text, out double num))
            {
                if (num >= -40 && num <= 45)
                {
                    numeros.Add(num);
                    lstinputdnums.Items.Add(num);

                    ActualizarEstadisticas(num);

                    txtboxnums.Clear();
                }
                else
                {
                    MessageBox.Show("El número ingresado está fuera del rango permitido (-40 a 45).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El dato ingresado no es numérico, ingrese un número válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadisticas(double num)
        {
            if (num > 0)
            {
                lstpositivenums.Items.Add(num);
                countPositivos++;

            }
            else if (num < 0)
            {
                countNegativos++;
                sumNegativos += num;
            }
            else
            {
                countCeros++;
            }

            double mayorNegativo = double.MinValue; 
            foreach (double n in numeros)
            {
                if (n < 0 && n > mayorNegativo)
                {
                    mayorNegativo = n;
                }
            }

            double promedioNegativos;
            if (countNegativos > 0)
            {
                promedioNegativos = sumNegativos / countNegativos;
            }
            else
            {
                promedioNegativos = 0;
            }


            double porcentajePositivos = 0;
            double porcentajeNegativos = 0;
            double porcentajeCeros = 0;
            int countTotal = numeros.Count; 

            if (countTotal > 0)
            {
                porcentajePositivos = (countPositivos * 100.0) / countTotal;
                porcentajeNegativos = (countNegativos * 100.0) / countTotal;
                porcentajeCeros = (countCeros * 100.0) / countTotal;
            }


            if (mayorNegativo == double.MinValue)
            {
                lstbiggestnegative.Items.Add("N/A");
            }
            else
            {
                lstbiggestnegative.Items.Add(mayorNegativo);
            }

         
            lstnegativeaverage.Items.Add(promedioNegativos);
            lstporcentajenums.Items.Add("positivos: " + porcentajePositivos+"%");
            lstporcentajenums.Items.Add("negativos: " + porcentajeNegativos + "%");
            lstporcentajenums.Items.Add("ceros: " + porcentajeCeros + "% \n");
        }
    }
}