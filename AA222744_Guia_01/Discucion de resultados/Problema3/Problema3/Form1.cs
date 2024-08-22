namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaracion de variables globales
        //contenido de mensaje de label
        private string aviso = "Aviso: Ingresa minimo diez numeros decimales para seleccionar una incógnita";
        private string restante = "10 numeros restantes . . .";
        List<double> Positivos = new List<double>(); //Se crea lista de numeros positivos
        List<double> Negativos = new List<double>(); //Se crea lista de numeros negativos
        int ingresados = 0; //Contador de numeros positivos y negativos registrados
        int AgrePositivos = 0, AgreNegativos = 0;//contador de numeros positivos y negativos
        private void Form1_Load(object sender, EventArgs e)
        {
            lblAviso.Text = aviso;
            lblRestantes.Text = restante;
        }
        public static Boolean ValidaNumero(string valor)//Funcion para validar los numeros ingresados
        {
            double result;
            return double.TryParse(valor, out result);
        }
        public void ActualizarListas()//Funcion para actualizar las listas de numeros
        {
            lstPositivos.Items.Clear();//Limpiar la lista de positivos y negativos 
            lstNegativos.Items.Clear();
            int index = 0;
            foreach (double numero in Positivos)//Añade los numeros registrados en la lista de postitivos
            {
                lstPositivos.Items.Add((index + 1) + ". Numero: " + numero);
                index++;
            }
            if (lstPositivos.Items.Count == 0)//Evita una lista en blanco, si no hay numeros en lista
            {
                lstPositivos.Items.Add("(Lista numeros positivos)");
            }
            index = 0;
            foreach (double numero in Negativos)//Añade los numeros registrados en la lista de negativos
            {
                lstNegativos.Items.Add((index + 1) + ". Numero: " + numero);
                index++;
            }
            if (lstNegativos.Items.Count == 0)//Evita una lista en blanco, si no hay numeros en lista
            {
                lstNegativos.Items.Add("(Lista numeros negativos)");
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)//Click al boton agregar numero
        {
            double NumeroIngresado;
            if (!(ValidaNumero(txtNumero.Text)))//Comprueba si el numero ingresado es valido
            {
                MessageBox.Show("El valor ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return;
            }
            else
            {
                NumeroIngresado = Convert.ToDouble(txtNumero.Text);
            }
            if(NumeroIngresado >= 0)//Comprueba si el numero es positivo o negativo
            {
                AgrePositivos++;
                btnVacPositivos.Enabled = true;
                Positivos.Add(NumeroIngresado);//Añade el numero a la lista de positivos
            }
            else
            {
                AgreNegativos++;
                btnVacNegativos.Enabled = true;
                Negativos.Add(NumeroIngresado);//Añade el numero a la lista de negativos
            }
            btnVacLista.Enabled = true;
            ingresados = (AgrePositivos + AgreNegativos);//Aumenta el contador de numeros ingresados
            restante = (10 - ingresados) + " numeros restantes . . .";
            if (ingresados >= 10) //Habilita selecciones y se actualizan mensajes de label
            {
                aviso = "Aviso: puedes seleccionar una incógnita";
                restante = "";
                lblAviso.Text = aviso;
                lstPreguntas.Items.Clear();
                lstPreguntas.Items.Add("¿Cuál fue el menor de los números negativos?");
                lstPreguntas.Items.Add("¿Promedio de los números positivos?");

            }
            txtNumero.Text = "";
            txtNumero.Focus();
            lblRestantes.Text = restante;
            ActualizarListas();
        }

        private void btnVacPositivos_Click(object sender, EventArgs e)//Click al boton vaciar positivos
        {
            //Vaciar la lista de numeros positivos
            ingresados = ingresados - AgrePositivos;
            AgrePositivos = 0;
            Positivos.Clear();
            lstPositivos.Items.Clear();
            lstPositivos.Items.Add("(Lista numeros positivos)");
            restante = (10 - ingresados) + " numeros restantes . . .";
            if (ingresados >= 10) //Actualizan mensajes de label y seleciones
            {
                aviso = "Aviso: puedes seleccionar una incógnita";
                restante = "";
                lstPreguntas.Items.Clear();
                lstPreguntas.Items.Add("¿Cuál fue el menor de los números negativos?");
                lstPreguntas.Items.Add("¿Promedio de los números positivos?");
            }
            else
            {
                aviso = "Aviso: Ingresa minimo diez numeros decimales para seleccionar una incógnita";
                lstPreguntas.Items.Clear();
                lstRespuestas.Items.Clear();
                lstPreguntas.Items.Add("(Incógnita)");
                lstRespuestas.Items.Add("(Resultado)");
            }
            lblAviso.Text = aviso;
            txtNumero.Focus();
            lblRestantes.Text = restante;
            btnVacPositivos.Enabled = false;
            if ((btnVacNegativos.Enabled == false) && (btnVacPositivos.Enabled == false))
            {
                //Valida si los dos botones de vaciar estan inabilitados
                btnVacLista.Enabled = false;//inabilita vaciar lista
            }
            ActualizarListas();//actualiza las listas

        }

        private void btnVacNegativos_Click(object sender, EventArgs e)//Click al boton vaciar negativos
        {
            //Vaciar la lista de numeros negativos
            ingresados = ingresados - AgreNegativos;
            AgreNegativos = 0;
            Negativos.Clear();
            lstNegativos.Items.Clear();
            lstNegativos.Items.Add("(Lista numeros negativos)");
            restante = (10 - ingresados) + " numeros restantes . . .";
            if (ingresados >= 10) //Actualizan mensajes de label y seleciones
            {
                aviso = "Aviso: puedes seleccionar una incógnita";
                restante = "";
                lstPreguntas.Items.Clear();
                lstPreguntas.Items.Add("¿Cuál fue el menor de los números negativos?");
                lstPreguntas.Items.Add("¿Promedio de los números positivos?");
            }
            else
            {
                aviso = "Aviso: Ingresa minimo diez numeros decimales para seleccionar una incógnita";
                lstPreguntas.Items.Clear();
                lstRespuestas.Items.Clear();
                lstPreguntas.Items.Add("(Incógnita)");
                lstRespuestas.Items.Add("(Resultado)");
            }
            lblAviso.Text = aviso;
            txtNumero.Focus();
            lblRestantes.Text = restante;
            btnVacNegativos.Enabled = false;
            if ((btnVacNegativos.Enabled == false) && (btnVacPositivos.Enabled == false))
            {
                //Valida si los dos botones de vaciar estan inabilitados
                btnVacLista.Enabled = false;
            }
            ActualizarListas();//actualizar listas
        }

        private void btnVacLista_Click(object sender, EventArgs e)//Click al boton vaciar lista 
        {
            //vacia las listas positivos y negativos
            ingresados = ingresados - AgrePositivos;
            AgrePositivos = 0;
            Positivos.Clear();
            lstPositivos.Items.Clear();
            lstPositivos.Items.Add("(Lista numeros positivos)");
            ingresados = ingresados - AgreNegativos;
            AgreNegativos = 0;
            Negativos.Clear();
            lstNegativos.Items.Clear();
            lstNegativos.Items.Add("(Lista numeros negativos)");
            restante = (10 - ingresados) + " numeros restantes . . .";
            if (ingresados >= 10) //Actualizan mensajes de label y selecciones
            {
                aviso = "Aviso: puedes seleccionar una incógnita";
                restante = "";
                lstPreguntas.Items.Clear();
                lstPreguntas.Items.Add("¿Cuál fue el menor de los números negativos?");
                lstPreguntas.Items.Add("¿Promedio de los números positivos?");
            }
            else
            {
                aviso = "Aviso: Ingresa minimo diez numeros decimales para seleccionar una incógnita";
                lstPreguntas.Items.Clear();
                lstRespuestas.Items.Clear();
                lstPreguntas.Items.Add("(Incógnita)");
                lstRespuestas.Items.Add("(Resultado)");
            }
            //restablecer botones y mensajes
            lblAviso.Text = aviso;
            txtNumero.Focus();
            lblRestantes.Text = restante;
            btnVacPositivos.Enabled = false;
            btnVacNegativos.Enabled = false;
            btnVacLista.Enabled = false;
            ActualizarListas();

        }

        private void lstPreguntas_SelectedIndexChanged(object sender, EventArgs e)//Selecionar incognita
        {
            string opcion = Convert.ToString(lstPreguntas.SelectedItem);
            if (opcion == "(Incógnita)")//Valida si no hat incognita disponible
            {
                return;
            }
            if (opcion == "¿Cuál fue el menor de los números negativos?")//Comprueba la seleccion
            {
                lstRespuestas.Items.Clear();//Muestra la solucion de la incognita
                if (Negativos.Any())//valida si no hay negativos
                {
                    double MenorNegativo = Negativos.Min();//Guarda el numero menor de la lista de negativos
                    lstRespuestas.Items.Add("Numero menor de los negativos: " + MenorNegativo);
                }
                else
                {
                    lstRespuestas.Items.Add("No hay numeros negativos");
                }
            }
            else
            {
                lstRespuestas.Items.Clear();//Muestra la solucion de la incognita
                if (Positivos.Any())//valida si no hay positivos
                {
                    double promedioPositivos = Positivos.Average();//Guarda el promedio de la lisra de positivos
                    lstRespuestas.Items.Add("Promedio de los positivos: " + promedioPositivos.ToString("0.00"));
                }
                else
                {
                    lstRespuestas.Items.Add("No hay numeros positivos");
                } 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Salir del programa
        }
    }
}