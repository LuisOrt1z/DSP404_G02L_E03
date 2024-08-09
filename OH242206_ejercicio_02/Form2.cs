using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form2 : Form
    {
        string txtnumeroCuenta; 
        public Form2(String text)
        {
            InitializeComponent();
            txtnumeroCuenta = text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblnumCuenta.Text = txtnumeroCuenta;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
   
        }
    }
}
