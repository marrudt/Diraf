using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Diraf.Models;

namespace Diraf.Controllers
{
    public class DatosContratoController : Controller
    {
        private DatosContratoDBContext db = new DatosContratoDBContext();

        // GET: /DatosContrato/
        public ActionResult Index(string Busqueda)
        {
            var sigea = from a in db.DatosContratoes
                        select a;
            if(!string.IsNullOrEmpty(Busqueda))
            {
                sigea = sigea.Where(s => s.NumeroSigea.Contains(Busqueda));

            }
            return View(sigea);
        }
                               
        // GET: /DatosContrato/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatosContrato datoscontrato = db.DatosContratoes.Find(id);
            if (datoscontrato == null)
            {
                return HttpNotFound();
            }
            this.ViewBag.ListaTalleres = new TallerDBContext().Set<Taller>().Where(m => m.Active == true).ToList();
            this.ViewBag.ListaUnidades = new UnidadDBContext().Set<Unidad>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaUsuarios = new UsuarioDBContext().Set<Usuario>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesServicios = new ClaseServicioDBContext().Set<ClaseServicio>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesVhs = new ClaseVhDBContext().Set<ClaseVh>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaLineasVhs = new LineaVhDBContext().Set<LineaVh>().Where(m => m.Activo == true).ToList();
            return View(datoscontrato);
        }

        public ActionResult Create()
        {
            this.ViewBag.ListaTalleres = new TallerDBContext().Set<Taller>().Where(m => m.Active == true).ToList();
            this.ViewBag.ListaUnidades = new UnidadDBContext().Set<Unidad>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaUsuarios = new UsuarioDBContext().Set<Usuario>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesServicios = new ClaseServicioDBContext().Set<ClaseServicio>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesVhs = new ClaseVhDBContext().Set<ClaseVh>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaLineasVhs = new LineaVhDBContext().Set<LineaVh>().Where(m => m.Activo == true).ToList();

            return View();
        }

        // POST: /DatosContrato/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id_Taller,Id_Unidad,Id_Usuario,NumeroSigea,FechaEmisionSigea,Id_ClaseServicio,FechaIngresoTaller,NumeroOTTaller,DiasTaller,Km,Placa,Sigla,ModeloAno,Id_Clase,Id_Linea,CotizacionValorServicio,CotizacionValorRptosGravados,CotizacionValorRptosExcentos,CotizacionValorDescuento,CotizacionSubtotal,CotizacionValorIva,CotizacionValorTotal,FechaSalidaTaller,TipoFactura,NumeroFactura,FechaFactura,FacturaValorServicio,FacturaValorRptosGravados,FacturaValorRptosExcentos,FacturaValorDescuento,FacturaSubtotal,FacturaValorIva,FacturaValorTotal,NumeroFacturaServicio1,FechaFacturaServicio1,FacturaServicio1Proveedor,FacturaServicio1Concepto,FacturaServicio1ValorServicio,FacturaServicio1ValorIva,FacturaServicio1ValorTotal,NumeroFacturaServicio2,FechaFacturaServicio2,FacturaServicio2Proveedor,FacturaServicio2Concepto,FacturaServicio2ValorServicio,FacturaServicio2ValorIva,FacturaServicio2ValorTotal,DiferenciaTaller,FechaPreliquidacionFinal,PreliquidacionFinalValorServicio,PreliquidacionFinalValorRptosGravados,PreliquidacionFinalValorRptosExcentos,PreliquidacionFinalValorDescuento,PreliquidacionFinalSubtotal,PreliquidacionFinalValorIva,PreliquidacionFinalValorTotal,Utilidad,UtilidadRelativa,ControlPrefacturaFirmadaTaller,ControlFacturaFirmadaTaller,ControlActaRecibidaSatisfaccion,ControlSigeaOriginal,EntregaCoordinador,NombreCompletoConductor,CorreoConductor,TelefonoConductor")] DatosContrato datoscontrato)
        {
            if (ModelState.IsValid)
            {
                db.DatosContratoes.Add(datoscontrato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                this.ViewBag.ListaTalleres = new TallerDBContext().Set<Taller>().Where(m => m.Active == true).ToList();
                this.ViewBag.ListaUnidades = new UnidadDBContext().Set<Unidad>().Where(m => m.Activo == true).ToList();
                this.ViewBag.ListaUsuarios = new UsuarioDBContext().Set<Usuario>().Where(m => m.Activo == true).ToList();
                this.ViewBag.ListaClasesServicios = new ClaseServicioDBContext().Set<ClaseServicio>().Where(m => m.Activo == true).ToList();
                this.ViewBag.ListaClasesVhs = new ClaseVhDBContext().Set<ClaseVh>().Where(m => m.Activo == true).ToList();
                this.ViewBag.ListaLineasVhs = new LineaVhDBContext().Set<LineaVh>().Where(m => m.Activo == true).ToList();
            }
            return View(datoscontrato);
        }
        

    // GET: /DatosContrato/Edit/5
    public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatosContrato datoscontrato = db.DatosContratoes.Find(id);
            if (datoscontrato == null)
            {
                return HttpNotFound();
            }
            this.ViewBag.ListaTalleres = new TallerDBContext().Set<Taller>().Where(m => m.Active == true).ToList();
            this.ViewBag.ListaUnidades = new UnidadDBContext().Set<Unidad>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaUsuarios = new UsuarioDBContext().Set<Usuario>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesServicios = new ClaseServicioDBContext().Set<ClaseServicio>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaClasesVhs = new ClaseVhDBContext().Set<ClaseVh>().Where(m => m.Activo == true).ToList();
            this.ViewBag.ListaLineasVhs = new LineaVhDBContext().Set<LineaVh>().Where(m => m.Activo == true).ToList();
            return View(datoscontrato);
        }

        // POST: /DatosContrato/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Id_Taller,Id_Unidad,Id_Usuario,NumeroSigea,FechaEmisionSigea,Id_ClaseServicio,FechaIngresoTaller,NumeroOTTaller,DiasTaller,Km,Placa,Sigla,ModeloAno,Id_Clase,Id_Linea,CotizacionValorServicio,CotizacionValorRptosGravados,CotizacionValorRptosExcentos,CotizacionValorDescuento,CotizacionSubtotal,CotizacionValorIva,CotizacionValorTotal,FechaSalidaTaller,TipoFactura,NumeroFactura,FechaFactura,FacturaValorServicio,FacturaValorRptosGravados,FacturaValorRptosExcentos,FacturaValorDescuento,FacturaSubtotal,FacturaValorIva,FacturaValorTotal,NumeroFacturaServicio1,FechaFacturaServicio1,FacturaServicio1Proveedor,FacturaServicio1Concepto,FacturaServicio1ValorServicio,FacturaServicio1ValorIva,FacturaServicio1ValorTotal,NumeroFacturaServicio2,FechaFacturaServicio2,FacturaServicio2Proveedor,FacturaServicio2Concepto,FacturaServicio2ValorServicio,FacturaServicio2ValorIva,FacturaServicio2ValorTotal,DiferenciaTaller,FechaPreliquidacionFinal,PreliquidacionFinalValorServicio,PreliquidacionFinalValorRptosGravados,PreliquidacionFinalValorRptosExcentos,PreliquidacionFinalValorDescuento,PreliquidacionFinalSubtotal,PreliquidacionFinalValorIva,PreliquidacionFinalValorTotal,Utilidad,UtilidadRelativa,ControlPrefacturaFirmadaTaller,ControlFacturaFirmadaTaller,ControlActaRecibidaSatisfaccion,ControlSigeaOriginal,EntregaCoordinador,NombreCompletoConductor,CorreoConductor,TelefonoConductor")] DatosContrato datoscontrato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datoscontrato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datoscontrato);
        }

        // GET: /DatosContrato/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatosContrato datoscontrato = db.DatosContratoes.Find(id);
            if (datoscontrato == null)
            {
                return HttpNotFound();
            }
            return View(datoscontrato);
        }

        // POST: /DatosContrato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatosContrato datoscontrato = db.DatosContratoes.Find(id);
            db.DatosContratoes.Remove(datoscontrato);
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
