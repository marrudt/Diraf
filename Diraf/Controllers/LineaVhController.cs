using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Diraf.Models;

namespace Diraf.Controllers
{
    public class LineaVhController : Controller
    {
        private LineaVhDBContext db = new LineaVhDBContext();

        // GET: /LineaVh/
        public ActionResult Index()
        {
            return View(db.LineasVh.ToList());
        }

        // GET: /LineaVh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaVh lineavh = db.LineasVh.Find(id);
            if (lineavh == null)
            {
                return HttpNotFound();
            }
            return View(lineavh);
        }

        // GET: /LineaVh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LineaVh/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,NombreLineaVh,Activo")] LineaVh lineavh)
        {
            if (ModelState.IsValid)
            {
                db.LineasVh.Add(lineavh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lineavh);
        }

        // GET: /LineaVh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaVh lineavh = db.LineasVh.Find(id);
            if (lineavh == null)
            {
                return HttpNotFound();
            }
            return View(lineavh);
        }

        // POST: /LineaVh/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,NombreLineaVh,Activo")] LineaVh lineavh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineavh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineavh);
        }

        // GET: /LineaVh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaVh lineavh = db.LineasVh.Find(id);
            if (lineavh == null)
            {
                return HttpNotFound();
            }
            return View(lineavh);
        }

        // POST: /LineaVh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaVh lineavh = db.LineasVh.Find(id);
            db.LineasVh.Remove(lineavh);
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
