using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        private int conta;
        private string mensa;
        public Form1()
       
        {
            InitializeComponent();
        }
        private void For1_Load(object sender, EventArgs e)
        {
            // Evento se ejecuta al iniciar ejecución de Form1
            mensa = "Aun no ha presionado botón Contar";
            label1.Text = mensa;

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //int conta =0;
            conta = conta + 0;
            conta += 1;
            mensa = "Presiono boton Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1
            conta =0;
            mensa = "Presiono boton Contar, un total de" + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();//finaliza aplicación
        }
    }
}
