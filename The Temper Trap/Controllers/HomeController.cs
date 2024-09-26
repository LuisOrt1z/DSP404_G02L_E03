using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Web;
using The_Temper_Trap.Models;

namespace The_Temper_Trap.Controllers
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

        public IActionResult ClienteEmpleado()
        {
            return View();
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public IActionResult LoginCliente()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult LoginCliente(string nombre, string password)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Clientes WHERE nombre = @nombre AND contrasena = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        TempData["usuario"] = nombre;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                        return View();
                    }
                }
            }
        }


        [HttpGet]
        public IActionResult RegistroClientes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroCliente(string nombre, string password, string telefono, string email, string direccion)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Clientes (nombre, contrasena, telefono, email, direccion) VALUES (@nombre, @contrasena, @telefono, @email, @direccion)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", password);
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


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public IActionResult LoginEmpleado()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoginEmpleado(string nombre, string password)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Empleados WHERE nombre = @nombre AND contrasena = @contrasena"; 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Usuario o contraseña incorrectos");
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
        public ActionResult RegistroEmpleado(string nombre, string contrasena, string puesto, string telefono, string email)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Empleados (nombre, contrasena, puesto, telefono, email) VALUES (@nombre, @contrasena, @puesto, @telefono, @email)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@puesto", puesto);
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

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
