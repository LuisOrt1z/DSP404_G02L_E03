namespace Problema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables globales
        private string Mes;
        private int Dia;
        private int Anio;
        List<string> fechas = new List<string>();//Se crea lista que contendra las fechas

        private void ActualizaDias(string mes, int anio, int index)//Funcion para actualizar el comboBox de dias
        {
            cbxDia.Items.Clear();//Limpia la lista de contenido del comboBox de dias
            int diasdelmes;//Contador para los dias disponibles
            bool bisiesto = false;//Variable para comprovar años bisiestos
            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))//Valida si anio es bisiesto
            {
                bisiesto = true;
            }
            switch (mes)//Asignar numero de dias a diasmes
            {
                case "Enero":
                case "Marzo":
                case "Mayo":
                case "Julio":
                case "Agosto":
                case "Octubre":
                case "Diciembre":
                    diasdelmes = 31;//Meses que tienen 31 dias
                    break;
                case "Abril":
                case "Junio":
                case "Septiembre":
                case "Noviembre":
                    diasdelmes = 30;//Meses que tienen 30 dias
                    break;
                case "Febrero":
                    if (!bisiesto)
                    {
                        diasdelmes = 28;//28 dias si febrero no es bisiesto
                    }
                    else
                    {
                        diasdelmes = 29;//29 dias si febrero es bisiesto
                    }
                    break;
                default:
                    //El caso seleccionado no existe....
                    return;
                    break;
            }
            for(int i = 1; i <= diasdelmes; i++)//Bucle para añadir el numero de dias a cbxDia
            {
                cbxDia.Items.Add(i);
            }

            if (index != -1)//Validacion de index, si el usuario selecciono un dia
            {
                //Evita que se borre la opcion selecionada en cbxDia al actualizar el comboBox
                if ((index+1) > diasdelmes)
                {
                    /*
                     Valida si la selecion anterior no sobrepasa las nuevas opciones de dias
                    Ejemplo: Selecion anterior: 31 - Dias disponibles: 29
                    pasa la seleccion 31 a 29 
                     */
                    cbxDia.SelectedIndex = (diasdelmes - 1);//Pasa la selecion a la ultima nueva opcion disponible
                }
                else
                {
                    cbxDia.SelectedIndex = index;//pasa la salecion a la misma opcion anterior
                }
            }
        }

        public void ActualizarLista()//Funcion para actualizar la lista de fechas
        {
            lbxRegistrados.Items.Clear();
            foreach (string fechalist in fechas)//Añade las fechas registrados en la lista
            {
                lbxRegistrados.Items.Add(fechalist);
            }
            if (lbxRegistrados.Items.Count == 0)//Evita una lista en blanco, si no hay fechas en lista
            {
                lbxRegistrados.Items.Add("(Registrados)");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2024; i >= 1900; i--)//Bucle para añadir numero de años a cbxAnio
            {
                cbxAnio.Items.Add(i);
            }
            ActualizaDias("Enero",2024, cbxDia.SelectedIndex);//Actualizar dias
            //Enero = 31 dias , 2024 = año no biciesto, index de cbxDia = -1
        }

        private void btnIngresar_Click(object sender, EventArgs e)//click al boton registrar  
        {
            if ((cbxDia.SelectedIndex == -1)||(cbxMes.SelectedIndex == -1) ||(cbxAnio.SelectedIndex == -1))
            {
                //valida si no hay fecha correcta
                MessageBox.Show("El dia, mes o año no puede estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fechas.Add(Dia+" de "+Mes+" de "+Anio);//Se añade la fecha a la lista
            ActualizarLista();//Actualizar lista de fechas
            btnVaciar.Enabled = true;//Habilita el boton vaciar registro
        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dia = Convert.ToInt32(cbxDia.SelectedItem);//Guarda el dia selecionado
        }

        private void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mes = Convert.ToString(cbxMes.SelectedItem);//Guarda el mes selecionado
            if (cbxAnio.SelectedIndex != -1)//Valida que el año no este en blanco
            {
                ActualizaDias(Mes, Anio, cbxDia.SelectedIndex);
                //actualiza los dias (Mes seleccionado, año selecionado y index de la selecion de dia)
            }
            else
            {
                ActualizaDias(Mes, 2024, cbxDia.SelectedIndex);
                //actualiza los dias (Mes seleccionado, 2024 = año no bisiesto y index de la selecion de dia)
            }

        }

        private void cbxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Anio = Convert.ToInt32(cbxAnio.SelectedItem);//Guarda el año selecionado
            if (cbxMes.SelectedIndex != -1)//Valida que el mes no este en blanco
            {
                ActualizaDias(Mes, Anio, cbxDia.SelectedIndex);
                //actualiza los dias (Mes seleccionado, año selecionado y index de la selecion de dia)
            }
            else
            {
                ActualizaDias("Enero", Anio, cbxDia.SelectedIndex);
                //actualiza los dias (Enero = 31 dias, año selecionado y index de la selecion de dia)
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)//Click al boton vaciar registro
        {
            fechas.Clear();//Limppia la lista de fechas
            ActualizarLista();//Actualiza lista
            btnVaciar.Enabled = false;//Desabilita el boton vaciar registro
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Cierra el programa
        }
    }
}