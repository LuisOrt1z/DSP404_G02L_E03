using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroWeb.Controllers
{
    public class SaldoController : Controller
    {
        // GET: Saldo
        public ActionResult Saldo(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
        [HttpPost]
        public ActionResult Saldo(string sNumeroTarjeta, double sSaldo, double cantidad)
        {
            return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
        }
    }
}