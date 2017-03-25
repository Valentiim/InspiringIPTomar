using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InspiringIPTomar.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        public ActionResult Index()
        {
            //AlunoContext ac = new AlunoContext();
            //ViewBag.Alunos = new SelectList(ac.Alunos, "AlunoID", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Index(int a)
        {
            return View();
        }

        public ActionResult NovoAluno()
        {

            return View();
        }
        [HttpPost]
        public ActionResult NovoAluno(string exemplo)
        {
            return RedirectToAction("Index", "Alunos");

        }

    }
}
