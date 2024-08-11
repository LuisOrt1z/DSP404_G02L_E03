using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ejercicio1
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent(); 
            LoadDataEntretenimiento();
            LoadDataLibros();
            LoadDataProgramacion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadDataEntretenimiento()
        {
            // Agregar filas con valores por defecto
            dataGridView1.Rows.Add("GAME OF THRONES", "Juego de tronos", "David Benioff y D. B. Weiss", "Sean Bena, Nikolaj Coster-Waldau, Peter Dinklage, Emilia Clarke, Lena Headey, Ian Glen, Kit Harington, Sophie Turner, Maisie Williams, Issac Hempstead-Wright y Natalie Dormer", "Estados Unidos", 8, 73, 
                "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio", 40);
            dataGridView1.Rows.Add("CHERNOBYL", "Chernóbil", "Craig Mazin", "Jared Harris, Stellan Skarsgard y Emily Watson", "Estados Unidos y Reino Unido", 1, 5, 
                "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson", 34);
            dataGridView1.Rows.Add("THE MARVELOUS MRS. MAISEL", "La maravillosa Señora Maisel ", "Amy Sherman-Palladino", "Rachel Brosnahan, Michael Zegen, Alex Borstein, Tony Shalhoub y Marin Hinkle", "Estados Unidos", 3, 26, 
                "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica.", 26);

        }

        private void LoadDataLibros()
        {
            // Agregar filas con valores por defecto
            dataGridView2.Rows.Add("HARRY POTTER", "J. K. Rowling", "Novela", "Literatura fantastica, literatura juvenil, novela de desarrollo, y literatura infantil y juvenil", "3407 (ENG) y 3665 (ESP)", "Harry Potter, Ron Wealey, Hermione Granger, Ginni Wesley, Nevile Longbottom y Albus Dumbledore", "Lord Voldemort y Mortifagos",
                "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 nño, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como «el niño que sobrevivió».", 44);
            dataGridView2.Rows.Add("GOOSEBUMPS", "Robert Lawrence Stine", "Ciencias ficción, literatura infantil y suspenso", "Suspens, terror y juvenil", "Sin datos", "El protagonista principal de una historia de Pesadillas/Escalofríos, es a menudo situado en una ubicación remota o de alguna manera aislada en algunas situaciones.", "Sin datos",
                "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos.", 30);
            dataGridView2.Rows.Add("PERRY MASON", "Erle Stanley Gardner", "Novela policiaca", "Sin datos", "Sin datos", "Perry Mason", "Sin datos",
                    "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia.", 26);
        }

        private void LoadDataProgramacion()
        {
            // Agregar filas con valores por defecto
            dataGridView3.Rows.Add("PYTHON", "Python Software Foundation", ".py, .pyc, .pyd, .pyo, .pyw, .pyz", 1991, "Multiplataforma", "Multiparadigma: orientado a objetos, imperativo, funcional y reflexivo",
                "3.8.3", "Python Software Foundation License", 47);
            dataGridView3.Rows.Add("JAVA", "James Gosling y Sun Microsystems", "java, class, jar, jad y jmod", 1996, "Multiplataforma", "Orientado a objetos e imperativ",
                "14.01", "GNU GPL / Java Community Process", 38);
            dataGridView3.Rows.Add("JAVASCRIPT", "Sin datos", ".js", 1995, "Sin datos", "Multiparadigma, programacion funcional, programacion basada en prototipos, imperativo, interpretado (scriping)",
                "ECMAScript2016", "Sin datos", 15);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbEntretenimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEntretenimiento.Checked)
            {
                chart1.Titles.Clear();
                chart1.Titles.Add("Programas de entretenimiento");
            }
            
            //chart1.Series[0].Points.AddXY(dataGridView1[Column1], dataGridView1[Column9]);

        }

        private void rdbLibros_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLibros.Checked)
            {
                chart1.Titles.Clear();
                chart1.Titles.Add("Libros");
            }
        }

        private void rdbProgramacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProgramacion.Checked)
            {
                chart1.Titles.Clear();
                chart1.Titles.Add("Lenguajes de programacion");
            }
        }
    }
}
