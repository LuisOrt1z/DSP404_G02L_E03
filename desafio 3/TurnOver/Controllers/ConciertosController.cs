using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TurnOver.Models;
using System.Collections.Generic;

namespace TurnOver.Controllers
{
    public class ConciertosController : Controller
    {
        private readonly ILogger<ConciertosController> _logger;
        private readonly IConfiguration _configuration;

        public ConciertosController(ILogger<ConciertosController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult ListaConciertos()
        {
            List<Concierto> conciertos = new List<Concierto>();
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Conciertos"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            conciertos.Add(new Concierto
                            {
                                id_concierto = reader.GetInt32(0), 
                                nombre_concierto = reader.GetString(1), 
                                fecha_concierto = reader.GetDateTime(2), 
                                ubicacion = reader.GetString(3) 
                            });
                        }
                    }
                }
            }
            
            return View("~/Views/Home/ListaConciertos.cshtml", conciertos);
        }


        [HttpGet]
        public IActionResult CrearConcierto()
        {
            return View("~/Views/Home/CrearConcierto.cshtml");
        }

        [HttpPost]
        public IActionResult CrearConcierto(Concierto concierto)
        {
            if (ModelState.IsValid)
            {
                string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Conciertos (nombre_concierto, fecha_concierto, ubicacion) VALUES (@Nombre, @Fecha, @Ubicacion)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", concierto.nombre_concierto);
                        cmd.Parameters.AddWithValue("@Fecha", concierto.fecha_concierto);
                        cmd.Parameters.AddWithValue("@Ubicacion", concierto.ubicacion);
                        cmd.ExecuteNonQuery();
                    }
                }

               
                TempData["SuccessMessage"] = "Concierto guardado con éxito.";
            }

            
            return View("~/Views/Home/CrearConcierto.cshtml", concierto);
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public IActionResult EditarConcierto(int id)
        {
            Concierto concierto = null;
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Conciertos WHERE id_concierto = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            concierto = new Concierto
                            {
                                id_concierto = reader.GetInt32(0),
                                nombre_concierto = reader.GetString(1),
                                fecha_concierto = reader.GetDateTime(2),
                                ubicacion = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            if (concierto == null)
            {
                return NotFound();
            }

            return View("~/Views/Home/EditarConcierto.cshtml", concierto);
        }

        [HttpPost]
        public IActionResult EditarConcierto(Concierto concierto)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Conciertos SET nombre_concierto = @Nombre, fecha_concierto = @Fecha, ubicacion = @Ubicacion WHERE id_concierto = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", concierto.nombre_concierto);
                    cmd.Parameters.AddWithValue("@Fecha", concierto.fecha_concierto);
                    cmd.Parameters.AddWithValue("@Ubicacion", concierto.ubicacion);
                    cmd.Parameters.AddWithValue("@Id", concierto.id_concierto);
                    cmd.ExecuteNonQuery();
                }
            }

            TempData["SuccessMessage"] = "Concierto actualizado correctamente.";
            return RedirectToAction("ListaConciertos", "Conciertos"); 
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        [HttpGet]
        public IActionResult BorrarConcierto(int id)
        {
            Concierto concierto = null;
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Conciertos WHERE id_concierto = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            concierto = new Concierto
                            {
                                id_concierto = reader.GetInt32(0),
                                nombre_concierto = reader.GetString(1),
                                fecha_concierto = reader.GetDateTime(2),
                                ubicacion = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            if (concierto == null)
            {
                return NotFound();
            }

            return View("~/Views/Home/BorrarConcierto.cshtml", concierto);
        }

        [HttpPost]
        public IActionResult ConfirmarBorrarConcierto(int id_concierto)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnectionString");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Conciertos WHERE id_concierto = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id_concierto);
                    cmd.ExecuteNonQuery();
                }
            }

            TempData["Message"] = "Concierto eliminado correctamente.";

            return RedirectToAction("ListaConciertos", "Conciertos");
        }
    }
}