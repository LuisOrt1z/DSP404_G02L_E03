using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        private String mensa = "";
        static int conta; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "aun no ha presionado el boton contar";
            label1.Text = mensa;
        }

        private void btncontar_Click(object sender, EventArgs e)
        {
           // int conta = 0;
            conta = conta + 1;
            mensa = "presiono el boton Contar, un total de "+Convert.ToString(conta)+" veces";
            label1.Text = mensa;       
        }

        private void btnreincio_Click(object sender, EventArgs e)
        {
            conta = 0;
            mensa = "presiono el boton Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
