using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using The_Temper_Trap.Models;

namespace The_Temper_Trap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public IActionResult LoginCliente()
        {
            return View();
        }

        public IActionResult LoginEmpleado()
        {
            return View();
        }

        public IActionResult RegistroClientes()
        {
            return View();
        }
        public IActionResult RegistroEmpleados()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
