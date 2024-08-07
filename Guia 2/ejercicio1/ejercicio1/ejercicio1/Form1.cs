namespace ejercicio1
{
    public partial class frmFactorial : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmFactorial()

        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            long factorial = 1;
            int i;


            if (IsNumeric(txtNumero.Text))
            {
                //ser realizar un for desde el número ingresado hasta llegar a uno
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)

                {
                    //se multiplica el factorial por todos los numeros menores
                    //factorial= factorial*i;
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }
      }
    }
