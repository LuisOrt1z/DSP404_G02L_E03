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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string noms, ape1, ape2;
        private double CUM;
        private int UV;
        //valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        //evalua el cum
        private void EvaluarCUM()
        {
            string nombrecompleto;
            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura switch
                switch (Convert.ToInt16(CUM))
                {
                    case 8 - 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }
                txtResul.Text = nombrecompleto + " Puede cursar " + UV + "UV";
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            double ValorCUM = 0;
            string Resultados;
            ape1 = txtApe1.Text;
            ape1 = ape1.Trim();//Quita el espacio-blanco al inicio-final
            ape2 = txtApe2.Text;
            ape2 = ape2.Trim();//Quita el espacio-blanco al inicio-final
            noms = txtNom.Text;
            noms = noms.Trim();//Quita el espacio-blanco al inicio-final
            Resultados = txtResul.Text;
            if (ape1.Length == 0 && ape2.Length == 0 && noms.Length == 0)
            {
                //si no hay caracteres en nombre empresa
                MessageBox.Show("Debe completar todo los campos", "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCUM.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                return;//sale del procedimiento btnanalisis
            }
            else
            {
                ValorCUM = Convert.ToDouble(txtCUM.Text);
                if (!(ValorCUM > 0))
                {
                    MessageBox.Show("El valor del CUM no puede ser negativo", "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCUM.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                    return;
                }
            }
            EvaluarCUM();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
