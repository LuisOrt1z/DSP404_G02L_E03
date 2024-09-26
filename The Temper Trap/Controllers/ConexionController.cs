using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace The_Temper_Trap.Controllers
{
    public class ConexionController : Controller
    {

        private readonly IConfiguration configuration;



        public IActionResult Index()
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnectionString");

            SqlConnection conexion = new SqlConnection(connectionstring);

            conexion.Open();
            SqlCommand com = new SqlCommand("select * from Empleados", conexion);
            var count = (int)com.ExecuteScalar();

            ViewData["totalData"]=count;

            conexion.Close();

            return View();
        }

        public IActionResult Welcome(string name, int totalTimes = 5)
        {

            ViewData["message"] = "hi" + name;
            ViewData["totalTimes"] = totalTimes;
            return View();
        }

    }
}
