using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaseASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tarea1()
        {
            ViewBag.Message = "Mensaje Bloque Tarea 1";

            return View();
        }
        public ActionResult Tarea2()
        {
            ViewBag.Message = "Mensaje Bloque Tarea 2";

            return View();
        }
        [ActionName ("Hora")]
        public string HoraActual()
        {
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora()
        {
            return "Son las " + DateTime.Now.ToString("T");
        }
    }
}