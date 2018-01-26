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
    public class DatosController : Controller
    {
        private DatosDBContext db = new DatosDBContext();

        // GET: /Datos/
        public ActionResult Index()
        {
            return View(db.Datoes.ToList());
        }

        // GET: /Datos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos datos = db.Datoes.Find(id);
            if (datos == null)
            {
                return HttpNotFound();
            }
            return View(datos);
        }

        // GET: /Datos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Datos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Taller,Id_Unidad,Id_Usuario,NumeroSigea,FechaEmisionSigea,Id_ClaseServicio,FechaIngresoTaller,NumeroOTTaller,DiasTaller,Km,Placa,Sigla,ModeloAno,Id_Clase,Id_Linea,CotizacionValorServicio,CotizacionValorRptosGravados,CotizacionValorRptosExcentos,CotizacionValorDescuento,CotizacionSubtotal,CotizacionValorIva,CotizacionValorTotal,FechaSalidaTaller,TipoFactura,NumeroFactura,FechaFactura,FacturaValorServicio,FacturaValorRptosGravados,FacturaValorRptosExcentos,FacturaValorDescuento,FacturaSubtotal,FacturaValorIva,FacturaValorTotal,NumeroFacturaServicio1,FechaFacturaServicio1,FacturaServicio1Proveedor,FacturaServicio1Concepto,FacturaServicio1ValorServicio,FacturaServicio1ValorIva,FacturaServicio1ValorTotal,NumeroFacturaServicio2,FechaFacturaServicio2,FacturaServicio2Proveedor,FacturaServicio2Concepto,FacturaServicio2ValorServicio,FacturaServicio2ValorIva,FacturaServicio2ValorTotal,DiferenciaTaller,FechaPreliquidacionFinal,PreliquidacionFinalValorServicio,PreliquidacionFinalValorRptosGravados,PreliquidacionFinalValorRptosExcentos,PreliquidacionFinalValorDescuento,PreliquidacionFinalSubtotal,PreliquidacionFinalValorIva,PreliquidacionFinalValorTotal,Utilidad,UtilidadRelativa,ControlPrefacturaFirmadaTaller,ControlFacturaFirmadaTaller,ControlActaRecibidaSatisfaccion,ControlSigeaOriginal,EntregaCoordinador,NombreCompletoConductor,CorreoConductor,TelefonoConductor")] Datos datos)
        {
            if (ModelState.IsValid)
            {
                db.Datoes.Add(datos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datos);
        }

        // GET: /Datos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos datos = db.Datoes.Find(id);
            if (datos == null)
            {
                return HttpNotFound();
            }
            return View(datos);
        }

        // POST: /Datos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Id_Taller,Id_Unidad,Id_Usuario,NumeroSigea,FechaEmisionSigea,Id_ClaseServicio,FechaIngresoTaller,NumeroOTTaller,DiasTaller,Km,Placa,Sigla,ModeloAno,Id_Clase,Id_Linea,CotizacionValorServicio,CotizacionValorRptosGravados,CotizacionValorRptosExcentos,CotizacionValorDescuento,CotizacionSubtotal,CotizacionValorIva,CotizacionValorTotal,FechaSalidaTaller,TipoFactura,NumeroFactura,FechaFactura,FacturaValorServicio,FacturaValorRptosGravados,FacturaValorRptosExcentos,FacturaValorDescuento,FacturaSubtotal,FacturaValorIva,FacturaValorTotal,NumeroFacturaServicio1,FechaFacturaServicio1,FacturaServicio1Proveedor,FacturaServicio1Concepto,FacturaServicio1ValorServicio,FacturaServicio1ValorIva,FacturaServicio1ValorTotal,NumeroFacturaServicio2,FechaFacturaServicio2,FacturaServicio2Proveedor,FacturaServicio2Concepto,FacturaServicio2ValorServicio,FacturaServicio2ValorIva,FacturaServicio2ValorTotal,DiferenciaTaller,FechaPreliquidacionFinal,PreliquidacionFinalValorServicio,PreliquidacionFinalValorRptosGravados,PreliquidacionFinalValorRptosExcentos,PreliquidacionFinalValorDescuento,PreliquidacionFinalSubtotal,PreliquidacionFinalValorIva,PreliquidacionFinalValorTotal,Utilidad,UtilidadRelativa,ControlPrefacturaFirmadaTaller,ControlFacturaFirmadaTaller,ControlActaRecibidaSatisfaccion,ControlSigeaOriginal,EntregaCoordinador,NombreCompletoConductor,CorreoConductor,TelefonoConductor")] Datos datos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datos);
        }

        // GET: /Datos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos datos = db.Datoes.Find(id);
            if (datos == null)
            {
                return HttpNotFound();
            }
            return View(datos);
        }

        // POST: /Datos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Datos datos = db.Datoes.Find(id);
            db.Datoes.Remove(datos);
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
