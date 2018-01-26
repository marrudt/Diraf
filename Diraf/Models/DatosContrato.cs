using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class DatosContrato
    {
        [Display(Name = "No. Preliquidación")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Taller")] 
        public int Id_Taller { get; set; }
        
        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Unidad")] 
        public int Id_Unidad { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Usuario")] 
        public int Id_Usuario { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "No. Sigea")] 
        public string NumeroSigea { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Emision Sigea")] 
        public DateTime FechaEmisionSigea { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Clase Servicio")] 
        public int Id_ClaseServicio { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Ingreso Taller")] 
        public DateTime FechaIngresoTaller { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "No. OT Taller")] 
        public string NumeroOTTaller { get; set; }

        [Display(Name = "Días en Taller")] 
        public int? DiasTaller { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        public int Km { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Modelo Año")]
        public int ModeloAno { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Clase Vh.")]
        public int Id_Clase { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "Línea Vh.")]
        public int Id_Linea { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Servicio")] //Cotizacion
        public decimal? CotizacionValorServicio { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Gravados")] 
        public decimal? CotizacionValorRptosGravados { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Excentos")] 
        public decimal? CotizacionValorRptosExcentos { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Descuento")] 
        public decimal? CotizacionValorDescuento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Subtotal")] 
        public decimal? CotizacionSubtotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor IVA")] 
        public decimal? CotizacionValorIva { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Total")] 
        public decimal? CotizacionValorTotal { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Salida Taller")] 
        public DateTime? FechaSalidaTaller { get; set; }

        [Display(Name = "Tipo Factura")] //Factura
        public string TipoFactura { get; set; }

        [Display(Name = "No. Factura")] 
        public string NumeroFactura { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Factura")] 
        public DateTime? FechaFactura { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Servicio")] 
        public decimal? FacturaValorServicio { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Gravados")] 
        public decimal? FacturaValorRptosGravados { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Excentos")] 
        public decimal? FacturaValorRptosExcentos { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Descuento")] 
        public decimal? FacturaValorDescuento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Subtotal")] 
        public decimal? FacturaSubtotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor IVA")] 
        public decimal? FacturaValorIva { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Total")] 
        public decimal? FacturaValorTotal { get; set; }

        [Display(Name = "No. Factura Servicio")] //Factura Servicio 1
        public string NumeroFacturaServicio1 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Factura")] 
        public DateTime? FechaFacturaServicio1 { get; set; }

        [Display(Name = "Proveedor")] 
        public string FacturaServicio1Proveedor { get; set; }

        [Display(Name = "Concepto")] 
        public string FacturaServicio1Concepto { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Servicio")] 
        public decimal? FacturaServicio1ValorServicio { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor IVA")] 
        public decimal? FacturaServicio1ValorIva { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Total")] 
        public decimal? FacturaServicio1ValorTotal { get; set; }

        
        [Display(Name = "No. Factura Servicio")] //Factura Servicio 2
        public string NumeroFacturaServicio2 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Factura")] 
        public DateTime? FechaFacturaServicio2 { get; set; }

        [Display(Name = "Proveedor")] 
        public string FacturaServicio2Proveedor { get; set; }

        [Display(Name = "Concepto")] 
        public string FacturaServicio2Concepto { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Servicio")] 
        public decimal? FacturaServicio2ValorServicio { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor IVA")] 
        public decimal? FacturaServicio2ValorIva { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Total")] 
        public decimal? FacturaServicio2ValorTotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Diferencia Taller")] 
        public decimal? DiferenciaTaller { get; set; }

        [DataType(DataType.Date)] //Preliquidacion
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Preliquidación Final")] 
        public DateTime? FechaPreliquidacionFinal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Servicio")] 
        public decimal? PreliquidacionFinalValorServicio { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Gravados")]  
        public decimal? PreliquidacionFinalValorRptosGravados { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Rptos. Excentos")] 
        public decimal? PreliquidacionFinalValorRptosExcentos { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Descuento")] 
        public decimal? PreliquidacionFinalValorDescuento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Subtotal")] 
        public decimal? PreliquidacionFinalSubtotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor IVA")] 
        public decimal? PreliquidacionFinalValorIva { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Valor Total")] 
        public decimal? PreliquidacionFinalValorTotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal? Utilidad { get; set; }

        [Display(Name = "Utilidad Relativa %")] 
        public decimal? UtilidadRelativa { get; set; }

        [Display(Name = "Prefactura Firmada Taller")] //Control
        public bool ControlPrefacturaFirmadaTaller { get; set; }

        [Display(Name = "Factura Firmada Taller")] 
        public bool ControlFacturaFirmadaTaller { get; set; }

        [Display(Name = "Acta Recibida a Satidfacción")] 
        public bool ControlActaRecibidaSatisfaccion { get; set; }

        [Display(Name = "Sigea Original")] 
        public bool ControlSigeaOriginal { get; set; }

        [Display(Name = "Entrega Coordinador")] 
        public bool EntregaCoordinador { get; set; }

        [Display(Name = "Nombre Conductor")] 
        public string NombreCompletoConductor { get; set; }

        [Display(Name = "Correo Conductor")] 
        public string CorreoConductor { get; set; }

        [Display(Name = "Teléfono Conductor")] 
        public string TelefonoConductor { get; set; } 
    }
    public class DatosContratoDBContext : DbContext
    {
        public DbSet<DatosContrato> DatosContratoes { get; set; }
    }
}
    