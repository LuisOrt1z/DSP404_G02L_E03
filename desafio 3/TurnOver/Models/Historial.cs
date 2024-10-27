namespace TurnOver.Models
{
    public class Historial
    {
        public int id_historial { get; set; }
        public int id_cliente { get; set; }
        public int id_entrada { get; set; }
        public DateTime fecha_historial { get; set; }
        public string TipoBoleto { get; set; }
        public string NombreConcierto { get; set; }
        public int CantBoletos { get; set; }
        public double total { get; set; }
    }

}
