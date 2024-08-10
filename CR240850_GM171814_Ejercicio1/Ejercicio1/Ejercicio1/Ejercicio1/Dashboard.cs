using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void InitializeDataGridViewEntretenimiento()
        {
            // Agregar filas con valores por defecto
            dataGridView1.Rows.Add("GAME OF THRONES", "Juego de tronos", "David Benioff \n D. B. Weiss", "Sean Bena \n Nikolaj Coster-Waldau", "Estados Unidos", 8, 73, "La trama de Game of\r\nThrones está basada en la\r\nserie de novelas Canción de\r\nhielo y fuego, y relata las\r\nvivencias de un grupo de\r\npersonajes de distintas casas\r\nnobiliarias en el continente\r\nficticio Poniente para tener el\r\ncontrol del Trono de Hierro y\r\ngobernar los siete reinos que\r\nconforman el territorio");
            dataGridView1.Rows.Add("CHERNOBYL", "Chernóbil", "David Benioff \n D. B. Weiss", "Sean Bena \n Nikolaj Coster-Waldau", "Estados Unidos \r\n Reino Unido", 1, 5, "La serie gira en torno al\r\ndesastre nuclear de Chernóbil\r\nde abril de 1986 y los\r\nesfuerzos de limpieza sin\r\nprecedentes que siguieron.\r\nCuenta con un reparto\r\nencabezado por Jared Harris,\r\nStellan Skarsgård y Emily\r\nWatson");
            dataGridView1.Rows.Add("THE \r\nMARVELOU \r\nS MRS. \r\nMAISEL", "La maravillosa Señora Maisel ", "David Benioff \n D. B. Weiss", "Sean Bena \n Nikolaj Coster-Waldau", "Estados Unidos", 3, 26, "La serie cuenta la historia de\r\nun ama de casa en Nueva\r\nYork que descubre que tiene\r\nuna habilidad especial para la\r\ncomedia en vivo. El primer\r\nepisodio se estrenó como\r\nparte de la temporada de\r\npilotos de primavera de\r\nAmazon Studios el 17 de\r\nmarzo de 2017, recibiendo la\r\naclamación de la crítica.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewEntretenimiento();
        }
    }
}
