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
    public class TechnicalSpecificationsController : Controller
    {
        private CheckCarContext db = new CheckCarContext();

        // GET: TechnicalSpecifications
        public ActionResult Index()
        {
            var technicalSpecifications = db.TechnicalSpecifications.Include(t => t.CarDetail);
            return View(technicalSpecifications.ToList());
        }

        // GET: TechnicalSpecifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechnicalSpecification technicalSpecification = db.TechnicalSpecifications.Find(id);
            if (technicalSpecification == null)
            {
                return HttpNotFound();
            }
            return View(technicalSpecification);
        }

        // GET: TechnicalSpecifications/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName");
            return View();
        }

        // POST: TechnicalSpecifications/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SilindirHacmi,BeygirGucu,YakitTuru,SehirIciOrtalamaTuketim,SehirDisiOrtalamaTuketim,KarmaYakitTuketimi,VitesTipi,MaksimimTork,LastikOlculeri,SifirdanTuzeHizlanma,MaksimumHiz,Uzunluk,Genişlik,Tukseklik,BagajHacmi,BosAgırlik,YakitDeposu,YıllıkVergisi")] TechnicalSpecification technicalSpecification)
        {
            if (ModelState.IsValid)
            {
                db.TechnicalSpecifications.Add(technicalSpecification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technicalSpecification.ID);
            return View(technicalSpecification);
        }

        // GET: TechnicalSpecifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechnicalSpecification technicalSpecification = db.TechnicalSpecifications.Find(id);
            if (technicalSpecification == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technicalSpecification.ID);
            return View(technicalSpecification);
        }

        // POST: TechnicalSpecifications/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SilindirHacmi,BeygirGucu,YakitTuru,SehirIciOrtalamaTuketim,SehirDisiOrtalamaTuketim,KarmaYakitTuketimi,VitesTipi,MaksimimTork,LastikOlculeri,SifirdanTuzeHizlanma,MaksimumHiz,Uzunluk,Genişlik,Tukseklik,BagajHacmi,BosAgırlik,YakitDeposu,YıllıkVergisi")] TechnicalSpecification technicalSpecification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technicalSpecification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technicalSpecification.ID);
            return View(technicalSpecification);
        }

        // GET: TechnicalSpecifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechnicalSpecification technicalSpecification = db.TechnicalSpecifications.Find(id);
            if (technicalSpecification == null)
            {
                return HttpNotFound();
            }
            return View(technicalSpecification);
        }

        // POST: TechnicalSpecifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TechnicalSpecification technicalSpecification = db.TechnicalSpecifications.Find(id);
            db.TechnicalSpecifications.Remove(technicalSpecification);
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
