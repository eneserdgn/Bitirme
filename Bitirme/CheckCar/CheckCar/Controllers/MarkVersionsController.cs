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
    public class MarkVersionsController : Controller
    {
        private CheckCarContext db = new CheckCarContext();

        // GET: MarkVersions
        public ActionResult Index()
        {
            var markVersions = db.MarkVersions.Include(m => m.Mark);
            return View(markVersions.ToList());
        }

        // GET: MarkVersions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkVersion markVersion = db.MarkVersions.Find(id);
            if (markVersion == null)
            {
                return HttpNotFound();
            }
            return View(markVersion);
        }

        // GET: MarkVersions/Create
        public ActionResult Create()
        {
            ViewBag.MarkID = new SelectList(db.Marks, "ID", "MarkName");
            return View();
        }

        // POST: MarkVersions/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VersionName,VersionImage,MarkID")] MarkVersion markVersion)
        {
            if (ModelState.IsValid)
            {
                db.MarkVersions.Add(markVersion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MarkID = new SelectList(db.Marks, "ID", "MarkName", markVersion.MarkID);
            return View(markVersion);
        }

        // GET: MarkVersions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkVersion markVersion = db.MarkVersions.Find(id);
            if (markVersion == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarkID = new SelectList(db.Marks, "ID", "MarkName", markVersion.MarkID);
            return View(markVersion);
        }

        // POST: MarkVersions/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VersionName,VersionImage,MarkID")] MarkVersion markVersion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(markVersion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MarkID = new SelectList(db.Marks, "ID", "MarkName", markVersion.MarkID);
            return View(markVersion);
        }

        // GET: MarkVersions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkVersion markVersion = db.MarkVersions.Find(id);
            if (markVersion == null)
            {
                return HttpNotFound();
            }
            return View(markVersion);
        }

        // POST: MarkVersions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarkVersion markVersion = db.MarkVersions.Find(id);
            db.MarkVersions.Remove(markVersion);
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
