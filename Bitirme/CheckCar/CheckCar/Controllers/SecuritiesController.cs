using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CheckCar.Models;

namespace CheckCar.Controllers
{
    public class SecuritiesController : Controller
    {
        private CheckCarContext db = new CheckCarContext();

        // GET: Securities
        public ActionResult Index()
        {
            var securities = db.Securities.Include(s => s.CarDetail);
            return View(securities.ToList());
        }

        // GET: Securities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security security = db.Securities.Find(id);
            if (security == null)
            {
                return HttpNotFound();
            }
            return View(security);
        }

        // GET: Securities/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName");
            return View();
        }

        // POST: Securities/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SurucuHavaYastigi,YanPerdeHavaYastigi,LastikBasıncKontrolSistemi,EBD,ASR,LedGunduzFari,YolcuHavaYastigi,DizHavaYastigi,ABS,ESP,OnSisFarlari,AlasimJantlar")] Security security)
        {
            if (ModelState.IsValid)
            {
                db.Securities.Add(security);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", security.ID);
            return View(security);
        }

        // GET: Securities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security security = db.Securities.Find(id);
            if (security == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", security.ID);
            return View(security);
        }

        // POST: Securities/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SurucuHavaYastigi,YanPerdeHavaYastigi,LastikBasıncKontrolSistemi,EBD,ASR,LedGunduzFari,YolcuHavaYastigi,DizHavaYastigi,ABS,ESP,OnSisFarlari,AlasimJantlar")] Security security)
        {
            if (ModelState.IsValid)
            {
                db.Entry(security).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", security.ID);
            return View(security);
        }

        // GET: Securities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security security = db.Securities.Find(id);
            if (security == null)
            {
                return HttpNotFound();
            }
            return View(security);
        }

        // POST: Securities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Security security = db.Securities.Find(id);
            db.Securities.Remove(security);
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
