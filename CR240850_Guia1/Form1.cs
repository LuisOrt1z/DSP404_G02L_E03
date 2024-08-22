using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_DSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string mensa = "Aun no ha presionado botón Contar";
        static int conta;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento se ejecuta al iniciar ejecución de Form1
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            conta = conta + 1;
            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0;
            mensa = "Presiono boton Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
