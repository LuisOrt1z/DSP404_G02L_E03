using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace TurnOver.Controllers
{
    public class ConexionController : Controller
    {

        private readonly IConfiguration configuration;



        public IActionResult Index()
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnectionString");

            SqlConnection conexion = new SqlConnection(connectionstring);    

            conexion.Open();


            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

    }
}
