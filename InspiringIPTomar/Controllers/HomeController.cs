using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InspiringIPTomar.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            ViewBag.Title = "Notícias do IPT";

            return View();
        }

        public ActionResult SobreNos(string a)
        {
            ViewBag.Title = "Sobre nós";

            return View();
        }
        public ActionResult Cursos(string a)
        {
            ViewBag.Title = "Cursos do IPT";

            return View();
        }
        public ActionResult Noticias(string a)
        {
            ViewBag.Title = "Notícias do IPT";

            return View();
        }
        public ActionResult Agenda(string a)
        {
            ViewBag.Title = "Agenda do IPT";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}