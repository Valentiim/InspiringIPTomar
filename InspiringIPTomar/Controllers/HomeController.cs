using InspiringIPTomar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InspiringIPTomar.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Veja aqui os Contactos.";

            return View();
        }

        public ActionResult Ipt()
        {
            ViewBag.Message = "Saiba quem somos.";

            return View();
        }
    }
}