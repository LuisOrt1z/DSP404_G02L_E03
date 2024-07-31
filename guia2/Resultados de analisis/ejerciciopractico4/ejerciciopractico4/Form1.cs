using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopractico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbdivisasfrom.Items.Add("USD (dólar americano)");
            cbdivisasfrom.Items.Add("EUR (euro)");
            cbdivisasfrom.Items.Add("JPY (yen japonés)");
            cbdivisasfrom.Items.Add("GBP (libra esterlina)");
            cbdivisasfrom.Items.Add("AUD (dólar australiano)");
            cbdivisasto.Items.Add("USD (dólar americano)");
            cbdivisasto.Items.Add("EUR (euro)");
            cbdivisasto.Items.Add("JPY (yen japonés)");
            cbdivisasto.Items.Add("GBP (libra esterlina)");
            cbdivisasto.Items.Add("AUD (dólar australiano)");
            cbdivisasfrom.SelectedIndex = 0;
            cbdivisasto.SelectedIndex = 1;

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {

            Dictionary<string, decimal> cambiofijo = new Dictionary<string, decimal>
                {
                    {"USD",1.0m},{"EUR", 0.85m},{"JPY",110.0m},{"GBP",0.75m},{"AUD",1.35m}
                };

            if (cbdivisasfrom==null && cbdivisasto==null) {
                MessageBox.Show("ingrese una divisa de origen y otra de conversion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);           
            }

            string divisaorigen = cbdivisasfrom.SelectedItem.ToString().Split(' ')[0];
            string divisaaconvertir = cbdivisasto.SelectedItem.ToString().Split(' ')[0];
            
            if (decimal.TryParse(txtcantidad.Text, out decimal cantidad)){

                decimal cambiodesde = cambiofijo[divisaorigen];
                decimal cambiohasta = cambiofijo[divisaaconvertir];
                decimal conversion = cantidad / cambiodesde *cambiohasta;

                lblconvertida.Text = (cantidad+" "+divisaorigen+" = "+Math.Round(conversion,2)+" "+divisaaconvertir);

            }
            else {
                MessageBox.Show("ingrese un valor numerico", "ADVERTENCIA", MessageBoxButtons.OK);           
            
            }




        }
    }
}
