namespace TurnOver.Models
{
    public class Entradas
    {
        public int id_entrada { get; set; }
        public int id_cliente { get; set; }
        public string TipoBoleto { get; set; }
        public int id_concierto {  get; set; }
        public int CantBoletos { get; set; }
        public double total { get; set; }
    }
}
