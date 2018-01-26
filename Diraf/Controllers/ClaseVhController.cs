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
    public class ClaseVhController : Controller
    {
        private ClaseVhDBContext db = new ClaseVhDBContext();

        // GET: /ClaseVh/
        public ActionResult Index()
        {
            return View(db.ClasesVh.ToList());
        }

        // GET: /ClaseVh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseVh clasevh = db.ClasesVh.Find(id);
            if (clasevh == null)
            {
                return HttpNotFound();
            }
            return View(clasevh);
        }

        // GET: /ClaseVh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ClaseVh/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,NombreClaseVh,Activo")] ClaseVh clasevh)
        {
            if (ModelState.IsValid)
            {
                db.ClasesVh.Add(clasevh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasevh);
        }

        // GET: /ClaseVh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseVh clasevh = db.ClasesVh.Find(id);
            if (clasevh == null)
            {
                return HttpNotFound();
            }
            return View(clasevh);
        }

        // POST: /ClaseVh/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,NombreClaseVh,Activo")] ClaseVh clasevh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasevh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasevh);
        }

        // GET: /ClaseVh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseVh clasevh = db.ClasesVh.Find(id);
            if (clasevh == null)
            {
                return HttpNotFound();
            }
            return View(clasevh);
        }

        // POST: /ClaseVh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClaseVh clasevh = db.ClasesVh.Find(id);
            db.ClasesVh.Remove(clasevh);
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
