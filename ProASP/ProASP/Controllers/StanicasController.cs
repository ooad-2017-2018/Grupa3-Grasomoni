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
    public class StanicasController : Controller
    {
        private GrasomoniContext db = new GrasomoniContext();

        // GET: Stanicas
        public ActionResult Index()
        {
            return View(db.Stanica.ToList());
        }

        // GET: Stanicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanica stanica = db.Stanica.Find(id);
            if (stanica == null)
            {
                return HttpNotFound();
            }
            return View(stanica);
        }

        // GET: Stanicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stanicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NazivStanice,Lokacija")] Stanica stanica)
        {
            if (ModelState.IsValid)
            {
                db.Stanica.Add(stanica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stanica);
        }

        // GET: Stanicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanica stanica = db.Stanica.Find(id);
            if (stanica == null)
            {
                return HttpNotFound();
            }
            return View(stanica);
        }

        // POST: Stanicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NazivStanice,Lokacija")] Stanica stanica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stanica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stanica);
        }

        // GET: Stanicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanica stanica = db.Stanica.Find(id);
            if (stanica == null)
            {
                return HttpNotFound();
            }
            return View(stanica);
        }

        // POST: Stanicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stanica stanica = db.Stanica.Find(id);
            db.Stanica.Remove(stanica);
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
