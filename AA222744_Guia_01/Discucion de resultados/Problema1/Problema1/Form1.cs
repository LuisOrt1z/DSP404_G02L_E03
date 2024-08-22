namespace Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaracion de variables globales
        //contenido de mensaje de label
        private string aviso = "Aviso: Ingresa minimo diez numeros decimales para realizar una operacion";
        private string restante = "10 numeros restantes . . .";
        List<double> numeros = new List<double>(); //Se crea lista que contendra los numeros
        int ingresados = 0; //Contador de numeros registrados
        int opcion = 0; //Variable para elejir la opcion de la operacion
        private void Form1_Load(object sender, EventArgs e)
        {
            //Actualizar los mensajes de los labels
            label4.Text = aviso;
            label5.Text = restante;
        }

        public static Boolean ValidaNumero(string valor)//Funcion para validar los numeros ingresados
        {
            double result;
            return double.TryParse(valor, out result);
        }
        
        public void ActualizarLista()//Funcion para actualizar la lista de numeros
        {
            lstLista.Items.Clear();//Limpia la tabla de items
            int index = 0;
            foreach (double numero in numeros)//Añade los numeros registrados en la lista
            {
                lstLista.Items.Add((index + 1) + ". Numero: " + numero);
                index++;
            }
            if(lstLista.Items.Count == 0)//Evita una lista en blanco, si no hay numeros en lista
            {
                lstLista.Items.Add("(Lista)");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)//click a boton agregar numero
        {
            double NumeroIngresado; 
            if (!(ValidaNumero(txtNumeros.Text)))//Comprueba si el numero ingresado es valido
            {
                //Mensaje en caso de error
                MessageBox.Show("El valor ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeros.Focus();//Establece el focus a txtNumeros
                return;
            }
            else
            {
                NumeroIngresado = Convert.ToDouble(txtNumeros.Text);
            }
            numeros.Add(NumeroIngresado);//Añade el numero ingresado a la lista 
            ingresados++;//Aumenta el contador de numeros ingresados
            restante = (10 - ingresados)+" numeros restantes . . .";
            if (ingresados >= 10) //Habilita el boton de realizar operacion y se actualizan mensajes de label
            {
                aviso = "Aviso: puedes realizar la operacion";
                restante = "";
                label4.Text = aviso;
                btnOperacion.Enabled = true; //Habilitar boton de operacion
            }
            label5.Text = restante;
            ActualizarLista();
            txtNumeros.Text = "";
            btnVaciar.Enabled = true;//Habilitar boton de vaciar lista
            txtNumeros.Focus();
        }

        private void btnVaciar_Click(object sender, EventArgs e)//Click al boton vaciar lista
        {
            //Restablecer mensajes label y botones habilitados
            ingresados = 0;//Restablece Numero de ingresados
            btnOperacion.Enabled = false;
            aviso = "Aviso: Ingresa diez numeros decimales para realizar una operacion";
            restante = "10 numeros restantes . . .";
            label4.Text = aviso;
            label5.Text = restante;
            numeros.Clear();//Se vacia la lista numeros
            ActualizarLista();
            //Restablece el mensaje de la lista de resultados
            lstResultado.Items.Clear();
            lstResultado.Items.Add("(Resultado)");
            btnVaciar.Enabled = false;
            txtNumeros.Focus();
        }

        private void rdbOpcion1_Click(object sender, EventArgs e)
        {
            opcion = 0;//Cambia opcion 
        }

        private void rdbOpcion2_Click(object sender, EventArgs e)
        {
            opcion = 1;//Cambia opcion 
        }

        private void btnOperacion_Click(object sender, EventArgs e)//Click al boton realizar operacion
        {
            lstResultado.Items.Clear();
            if (opcion == 0)//Comprueba la opcion selecionada
            {
                var negativos = numeros.Where(n => n < 0).ToList(); //Se filtran los numeros negativos de la lista
                if (negativos.Any())//Comprueba si hay numeros negativos en la lista
                {
                    double MenorNegativo = negativos.Min();//Obtiene el numero menor de la lista negativos
                    double MayorNegativo = negativos.Max();//Obtiene el numero mayor de la lista negativos
                    lstResultado.Items.Add("El numero mayor negativo es: " + MayorNegativo);
                    lstResultado.Items.Add("El numero menor negativo es: " + MenorNegativo);
                }
                else
                {
                    lstResultado.Items.Add("No hay números negativos en el listado.");//Mensaje si no hay numeros negativos
                }
                var positivos = numeros.Where(n => n > 0).ToList();//Se filtran los numeros positivos de la lista
                if (positivos.Any())//Comprueba si hay numeros positivos en la lista
                {
                    double promedioPositivos = positivos.Average();//Obtiene la media de la lista de positivos
                    lstResultado.Items.Add("El promedio de los números positivos es: " + promedioPositivos.ToString("0.00"));
                }
                else
                {
                    lstResultado.Items.Add("No hay números positivos en el listado.");//Mensaje si no hay numeros positivos
                }
            }
            else
            {
                double Media = numeros.Average();//Obtiene la media de la lista de numeros
                lstResultado.Items.Add("La Media de la lista es: "+Media.ToString("0.00"));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Cierra el programa
        }
    }
}