using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using TurnOver.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TurnOver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HistorialCompras()
        {
            List<Historial> historial = new List<Historial>();
            List<Entradas> TipoEntrada = new List<Entradas>();
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM HistorialCompras";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historial.Add(new Historial
                            {
                                id_historial = reader.GetInt32(0),
                                id_cliente = reader.GetInt32(1),
                                id_entrada = reader.GetInt32(2),
                                fecha_historial = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Entradas";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entradas NuevaEntrada = new Entradas
                            {
                                id_entrada = Convert.ToInt32(reader["id_entrada"]),
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                TipoBoleto = Convert.ToString(reader["id_seccion"]),
                                id_concierto = Convert.ToInt32(reader["id_concierto"]),
                                CantBoletos = Convert.ToInt32(reader["cantidad"]),
                                total = Convert.ToDouble(reader["total"])

                            };

                            TipoEntrada.Add(NuevaEntrada);
                        }
                    }
                }
            }
            TipoEntrada = TipoEntrada.Where(r => r.id_cliente == Convert.ToInt32(TempData["IDusuario"])).ToList();
            historial = historial.Where(r => r.id_cliente == Convert.ToInt32(TempData["IDusuario"])).ToList();

            for (int i = 0; i < historial.Count; i++)
            {
                for (int j = 0; j < TipoEntrada.Count; j++)
                {
                    if (historial[i].id_entrada == TipoEntrada[j].id_entrada)
                    {
                        switch (TipoEntrada[j].TipoBoleto)
                        {
                            case "1":
                                historial[i].TipoBoleto = "General";
                                break;
                            case "2":
                                historial[i].TipoBoleto = "Plateado";
                                break;
                            case "3":
                                historial[i].TipoBoleto = "VIP";
                                break;
                        }
                        historial[i].CantBoletos = TipoEntrada[j].CantBoletos;
                        historial[i].total = TipoEntrada[j].total;
                        historial[i].NombreConcierto = Convert.ToString(TipoEntrada[j].id_concierto);

                    }
                }


            }


            return View(historial);
        }

        public IActionResult ClienteEmpleado() { 
            return View();
        }

        public IActionResult PanelCliente()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");
            List<Concierto> listaConciertos = new List<Concierto>();
            string queryLista = "SELECT id_concierto, nombre_concierto, fecha_concierto, ubicacion FROM Conciertos";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(queryLista, conexion);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    // Leer cada registro de la tabla
                    while (lector.Read())
                    {
                        // Crear un objeto Usuario para cada fila
                        Concierto NuevoConcierto = new Concierto
                        {
                            id_concierto = Convert.ToInt32(lector["id_concierto"]),
                            nombre_concierto = lector["nombre_concierto"].ToString(),
                            fecha_concierto = Convert.ToDateTime(lector["fecha_concierto"]),
                            ubicacion = lector["ubicacion"].ToString()

                        };


                        // Agregar el usuario a la lista
                        listaConciertos.Add(NuevoConcierto);
                    }
                }
            }

            if (TempData["FiltroNombre"] != null)
            {
                string nombreconts = Convert.ToString(TempData["FiltroNombre"]);
                listaConciertos = listaConciertos.Where(r => r.nombre_concierto.ToLower()!.Contains(nombreconts.ToLower())).ToList();
            }
            if (TempData["FiltroFecha"] != null)
            {
                string fechaconts = Convert.ToDateTime(TempData["FiltroFecha"]).ToString("dd/MM/yy");
                listaConciertos = listaConciertos.Where(r => r.fecha_concierto.ToString("dd/MM/yy") == fechaconts).ToList();
            }


            TempData.Keep("usuario");
            TempData.Keep("IDusuario");
            TempData["resultados"] = listaConciertos.Count;
            TempData.Keep("resultados");
            return View(listaConciertos);
        }

        [HttpPost]
        public ActionResult FiltrarConciertos(string BusquedaNombre, DateTime? BusquedaFecha)
        {
            if (BusquedaNombre != null || BusquedaNombre != "")
            {
                TempData["FiltroNombre"] = BusquedaNombre;
            }
            if (BusquedaFecha.HasValue)
            {
                TempData["FiltroFecha"] = BusquedaFecha;
            }

            return RedirectToAction("PanelCliente", "Home");
        }
        [HttpPost]
        public ActionResult ComprarBoleto(string IDconcierto, string tipoSesion, int CantidadSesion, string tTotal)
        {
            double total = Convert.ToDouble(tTotal, System.Globalization.CultureInfo.InvariantCulture);
            
            if(total == 0)
            {
                TempData["MSM"] = "Error: no se puede comprar 0 boletos";
                return RedirectToAction("PanelCliente", "Home");
            }

            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Entradas (id_cliente, id_concierto, id_seccion, cantidad, total) VALUES (@IDCliente, @IDConcierto, @IDSeccion, @cantidad, @total); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDCliente", TempData["IDusuario"].ToString());
                    cmd.Parameters.AddWithValue("@IDConcierto", IDconcierto);
                    switch (tipoSesion)
                    {
                        case "General":
                            cmd.Parameters.AddWithValue("@IDSeccion", "1");
                            break;
                        case "Plateado":
                            cmd.Parameters.AddWithValue("@IDSeccion", "2");
                            break;
                        case "VIP":
                            cmd.Parameters.AddWithValue("@IDSeccion", "3");
                            break;
                    }
                    cmd.Parameters.AddWithValue("@cantidad", CantidadSesion);
                    cmd.Parameters.AddWithValue("@total", total);
                    int IDEntrada = Convert.ToInt32(cmd.ExecuteScalar());
                    string HistorialQuery = "INSERT INTO HistorialCompras (id_cliente, id_entrada) VALUES (@IDCliente, @IDEntrada)";
                    using (SqlCommand cmdGeneral = new SqlCommand(HistorialQuery, conn))
                    {
                        cmdGeneral.Parameters.AddWithValue("@IDCliente", TempData["IDusuario"].ToString());
                        cmdGeneral.Parameters.AddWithValue("@IDEntrada", IDEntrada);
                        int SesionAgregada = cmdGeneral.ExecuteNonQuery();
                    }
                }
            }
            TempData["MSM"] = "Boleto " + tipoSesion + " Comprado Exitosamente";
            return RedirectToAction("PanelCliente", "Home");
        }


        public IActionResult PanelEmpleado()
        {
            return View();
        }
        //////////////////////////////////////////////////////////////////

        [HttpGet]
        public IActionResult LoginCliente() {
            return View();
        }

        [HttpPost]
        public IActionResult LoginCliente(string nombre, string contrasena)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                string query = "SELECT id_cliente FROM Clientes WHERE nombre = @nombre AND contrasena = @contrasena";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    
                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                        int idUsuario = (int)result; 
                        TempData["IDusuario"] = idUsuario; 
                        TempData["usuario"] = nombre; 

                        return RedirectToAction("PanelCliente", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "USUARIO O CONTRASEÑA INCORRECTOS");
                        return View();
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult RegistroCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroCliente(string nombre, string contrasena, string telefono, string email, string direccion)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Clientes (nombre, contrasena, telefono, email, direccion) VALUES (@nombre, @contrasena, @telefono, @email, @direccion)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("LoginCliente");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error al registrar el cliente");
                        return View();
                    }
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public IActionResult LoginEmpleado()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginEmpleado(string nombre, string contrasena)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT (*) FROM Empleados WHERE nombre = @nombre AND contrasena = @contrasena";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        TempData["usuario"] = nombre;
                        return RedirectToAction("PanelEmpleado", "Home");

                    }
                    else
                    {
                        ModelState.AddModelError("", "USUARIO O CONTRASEÑA INCORRECTOS");
                        return View();
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult RegistroEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroEmpleado(string nombre, string contrasena, string telefono, string email)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Empleados (nombre, contrasena, telefono, email) VALUES (@nombre, @contrasena, @telefono, @email)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("LoginEmpleado");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error al registrar el cliente");
                        return View();
                    }
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
