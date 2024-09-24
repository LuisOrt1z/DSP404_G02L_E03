using System.ComponentModel.DataAnnotations;

namespace The_Temper_Trap.Models
{
    public class ModeloClientes
    {
            public int id_cliente { get; set; }

            public string nombre { get; set; }

            public string contrasena { get; set; }

            public string telefono { get; set; }

            public string email { get; set; }

            public string direccion { get; set; }
     
    }
}
