using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProASP.Models;

namespace ProASP.Controllers
{
    public class VoziloesController : Controller
    {
        private GrasomoniContext db = new GrasomoniContext();

        // GET: Voziloes
        public ActionResult Index()
        {
            return View(db.Vozilo.ToList());
        }

        // GET: Voziloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozilo.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // GET: Voziloes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voziloes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VrstaVozila,RegistracijskiBroj")] Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Vozilo.Add(vozilo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vozilo);
        }

        // GET: Voziloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozilo.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // POST: Voziloes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VrstaVozila,RegistracijskiBroj")] Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vozilo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vozilo);
        }

        // GET: Voziloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozilo.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // POST: Voziloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vozilo vozilo = db.Vozilo.Find(id);
            db.Vozilo.Remove(vozilo);
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
