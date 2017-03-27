using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InspiringIPTomar.Models;

namespace InspiringIPTomar.Controllers
{
    public class QuartosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Actividades        
        public ActionResult Index()
        {
            return View(db.Actividades.OrderByDescending(m => m.TipoActividade).ToList());
        }

        // GET: Actividades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Actividades actividades = db.Actividades.Find(id);
            if (actividades == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var nomeIMG = (from act in db.Actividades where id == act.ActividadeID select act.ImagePath).Single();
            if (nomeIMG == null)
            {
                ViewBag.img = "image-not-found.jpg";
            }
            else
            {
                ViewBag.img = nomeIMG;
            }
            return View(actividades);
        }

        // GET: Actividades/Create
        [Authorize(Roles = "Funcionarios")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quartos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Funcionarios")]
        public ActionResult Create([Bind(Include = "ActividadeID,TipoActividade,Descricao,ImagePath")]Actividades actividades, HttpPostedFileBase file)
        {
            TempData["CA"] = "Categoria das Actividades";
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                          + file.FileName);
                    actividades.ImagePath = file.FileName;
                }
               
                return RedirectToAction("Index");
            }
           
            return View(actividades);
        }
        [Authorize(Roles = "Funcionarios")]
        // GET: Actividades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Actividades actividades = db.Actividades.Find(id);
            if (actividades == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(actividades);
        }
        [Authorize(Roles = "Funcionarios")]
        // POST: Quartos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Funcionarios")]
        public ActionResult Edit([Bind(Include = "ActividadeID,TipoActividade,Descricao,ImagePath")] Actividades actividades, HttpPostedFileBase file)
        {
            TempData["CA"] = "Categoria das Actividades";
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                          + file.FileName);
                    actividades.ImagePath = file.FileName;
                }
              
                return RedirectToAction("Index");
            }
           
            return View(actividades);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
