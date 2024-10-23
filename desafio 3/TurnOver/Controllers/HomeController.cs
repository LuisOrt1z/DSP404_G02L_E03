using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using TurnOver.Models;

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

        public IActionResult ClienteEmpleado() { 
            return View();
        }

        public IActionResult PanelCliente()
        {
            return View();
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

                string query = "SELECT COUNT (*) FROM Clientes WHERE nombre = @nombre AND contrasena = @contrasena";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        TempData["usuario"] = nombre;
                        return RedirectToAction("PanelCliente", "Home");

                    }
                    else {
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
