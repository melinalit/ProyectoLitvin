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
    public class EstadosJudicialesController : Controller
    {
        private ProyectoFinalEntities db = new ProyectoFinalEntities();

        // GET: EstadosJudiciales
        public ActionResult Index()
        {
            return View(db.EstadosJudiciales.ToList());
        }

        // GET: EstadosJudiciales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosJudiciale estadosJudiciale = db.EstadosJudiciales.Find(id);
            if (estadosJudiciale == null)
            {
                return HttpNotFound();
            }
            return View(estadosJudiciale);
        }

        // GET: EstadosJudiciales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadosJudiciales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EstadoJudicial")] EstadosJudiciale estadosJudiciale)
        {
            if (ModelState.IsValid)
            {
                db.EstadosJudiciales.Add(estadosJudiciale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadosJudiciale);
        }

        // GET: EstadosJudiciales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosJudiciale estadosJudiciale = db.EstadosJudiciales.Find(id);
            if (estadosJudiciale == null)
            {
                return HttpNotFound();
            }
            return View(estadosJudiciale);
        }

        // POST: EstadosJudiciales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EstadoJudicial")] EstadosJudiciale estadosJudiciale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadosJudiciale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadosJudiciale);
        }

        // GET: EstadosJudiciales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosJudiciale estadosJudiciale = db.EstadosJudiciales.Find(id);
            if (estadosJudiciale == null)
            {
                return HttpNotFound();
            }
            return View(estadosJudiciale);
        }

        // POST: EstadosJudiciales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadosJudiciale estadosJudiciale = db.EstadosJudiciales.Find(id);
            db.EstadosJudiciales.Remove(estadosJudiciale);
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
