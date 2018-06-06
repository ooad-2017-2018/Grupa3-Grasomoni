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
    public class KarticasController : Controller
    {
        private GrasomoniContext db = new GrasomoniContext();

        // GET: Karticas
        public ActionResult Index()
        {
            return View(db.Kartica.ToList());
        }

        // GET: Karticas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kartica kartica = db.Kartica.Find(id);
            if (kartica == null)
            {
                return HttpNotFound();
            }
            return View(kartica);
        }

        // GET: Karticas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Karticas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StanjeRacuna,DatumIsteka")] Kartica kartica)
        {
            if (ModelState.IsValid)
            {
                db.Kartica.Add(kartica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kartica);
        }

        // GET: Karticas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kartica kartica = db.Kartica.Find(id);
            if (kartica == null)
            {
                return HttpNotFound();
            }
            return View(kartica);
        }

        // POST: Karticas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StanjeRacuna,DatumIsteka")] Kartica kartica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kartica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kartica);
        }

        // GET: Karticas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kartica kartica = db.Kartica.Find(id);
            if (kartica == null)
            {
                return HttpNotFound();
            }
            return View(kartica);
        }

        // POST: Karticas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kartica kartica = db.Kartica.Find(id);
            db.Kartica.Remove(kartica);
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
