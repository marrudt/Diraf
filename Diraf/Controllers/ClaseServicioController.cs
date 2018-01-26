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
    public class ClaseServicioController : Controller
    {
        private ClaseServicioDBContext db = new ClaseServicioDBContext();

        // GET: /ClaseServicio/
        public ActionResult Index()
        {
            return View(db.Servicioes.ToList());
        }

        // GET: /ClaseServicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseServicio claseservicio = db.Servicioes.Find(id);
            if (claseservicio == null)
            {
                return HttpNotFound();
            }
            return View(claseservicio);
        }

        // GET: /ClaseServicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ClaseServicio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,NombreServicio,Activo")] ClaseServicio claseservicio)
        {
            if (ModelState.IsValid)
            {
                db.Servicioes.Add(claseservicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(claseservicio);
        }

        // GET: /ClaseServicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseServicio claseservicio = db.Servicioes.Find(id);
            if (claseservicio == null)
            {
                return HttpNotFound();
            }
            return View(claseservicio);
        }

        // POST: /ClaseServicio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,NombreServicio,Activo")] ClaseServicio claseservicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(claseservicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(claseservicio);
        }

        // GET: /ClaseServicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaseServicio claseservicio = db.Servicioes.Find(id);
            if (claseservicio == null)
            {
                return HttpNotFound();
            }
            return View(claseservicio);
        }

        // POST: /ClaseServicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClaseServicio claseservicio = db.Servicioes.Find(id);
            db.Servicioes.Remove(claseservicio);
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
