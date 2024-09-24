namespace The_Temper_Trap.Models
{
    public class Empleado
    {
        public int id_empleado { get; set; } // Puedes dejarlo sin usar si es autoincremental
        public string nombre { get; set; }
        public string puesto { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
    }
}
