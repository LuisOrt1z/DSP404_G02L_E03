namespace form2
{
    public partial class Form1 : Form
    {
        private double TasaI;

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {

                txtTasaInterEX.Enabled = true;
                txtTasaInterEX.Focus();
            }
            else
            {
                txtTasaInterEX.Text = "0";
                txtTasaInterEX.Enabled = false;
            }

        }

        private void rdbInteres1_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.12;
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string NombreEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NombreEmpre = txtEmpresa.Text;
            NombreEmpre = NombreEmpre.Trim();

            if (NombreEmpre.Length==0) {
                MessageBox.Show("debe de indicar el nombre de la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
                return;
            }

            if (!(IsNumeric(txtMonto.Text))) {
                MessageBox.Show("valor monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;
            }
            else {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0)){
                    MessageBox.Show("valor monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus();
                    return;
                }
            }

            Tiempo = Convert.ToInt32(txtTiempo.Text);
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();

            if (rdbInteres3.Checked==true) {
                if (txtTasaInterEX.Text.Length>0) {
                    if (!(IsNumeric(txtTasaInterEX.Text) == true)) {
                        MessageBox.Show("tasa de interes incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtTasaInterEX.Text = "0";
                        txtTasaInterEX.Focus();
                        return;
                    }
                    else {
                        TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;

                    }
                }
                else {
                    MessageBox.Show("aun no ha indicado una tasa de interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;

                }
            }

            MontoFin = (1+TasaI);
            MontoFin = MontoFin * (Math.Pow(Convert.ToDouble(MontoFin),Tiempo));
            TasaI *= 100;
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: "+txtEmpresa.Text);
            lstResul.Items.Add("Monto: $"+MontoInic+", tasa anual: "+TasaI);
            lstResul.Items.Add("Monto a pagar: $"+MontoFin);
        }
    }
}
