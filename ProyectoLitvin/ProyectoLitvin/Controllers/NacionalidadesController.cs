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
    public class NacionalidadesController : Controller
    {
        private ProyectoFinalEntities db = new ProyectoFinalEntities();

        // GET: Nacionalidades
        public ActionResult Index()
        {
            return View(db.Nacionalidades.ToList());
        }

        // GET: Nacionalidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacionalidade nacionalidade = db.Nacionalidades.Find(id);
            if (nacionalidade == null)
            {
                return HttpNotFound();
            }
            return View(nacionalidade);
        }

        // GET: Nacionalidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nacionalidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nacionalidad")] Nacionalidade nacionalidade)
        {
            if (ModelState.IsValid)
            {
                db.Nacionalidades.Add(nacionalidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nacionalidade);
        }

        // GET: Nacionalidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacionalidade nacionalidade = db.Nacionalidades.Find(id);
            if (nacionalidade == null)
            {
                return HttpNotFound();
            }
            return View(nacionalidade);
        }

        // POST: Nacionalidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nacionalidad")] Nacionalidade nacionalidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nacionalidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nacionalidade);
        }

        // GET: Nacionalidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacionalidade nacionalidade = db.Nacionalidades.Find(id);
            if (nacionalidade == null)
            {
                return HttpNotFound();
            }
            return View(nacionalidade);
        }

        // POST: Nacionalidades/Delete/5
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nacionalidade nacionalidade = db.Nacionalidades.Find(id);
            db.Nacionalidades.Remove(nacionalidade);
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
