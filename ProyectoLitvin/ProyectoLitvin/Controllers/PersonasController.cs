using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoLitvin.Models;

namespace ProyectoLitvin.Controllers
{
    public class PersonasController : Controller
    {
        private ProyectoFinalEntities db = new ProyectoFinalEntities();

        // GET: Personas
        public ActionResult Index()
        {            
            var personas = db.Personas.Include(p => p.EstadosJudiciale).Include(p => p.Nacionalidade);
            return View(personas.ToList());
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            ViewBag.IDNacionalidad = new SelectList(db.EstadosJudiciales, "ID", "EstadoJudicial");
            ViewBag.IDNacionalidad = new SelectList(db.Nacionalidades, "ID", "Nacionalidad");
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DNI,Nombre,Apellido,FechaNacimiento,IDNacionalidad,IDEstadoJudicial")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDNacionalidad = new SelectList(db.EstadosJudiciales, "ID", "EstadoJudicial", persona.IDNacionalidad);
            ViewBag.IDNacionalidad = new SelectList(db.Nacionalidades, "ID", "Nacionalidad", persona.IDNacionalidad);
            return View(persona);
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDNacionalidad = new SelectList(db.EstadosJudiciales, "ID", "EstadoJudicial", persona.IDNacionalidad);
            ViewBag.IDNacionalidad = new SelectList(db.Nacionalidades, "ID", "Nacionalidad", persona.IDNacionalidad);
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DNI,Nombre,Apellido,FechaNacimiento,IDNacionalidad,IDEstadoJudicial")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDNacionalidad = new SelectList(db.EstadosJudiciales, "ID", "EstadoJudicial", persona.IDNacionalidad);
            ViewBag.IDNacionalidad = new SelectList(db.Nacionalidades, "ID", "Nacionalidad", persona.IDNacionalidad);
            return View(persona);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
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
