using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class LineaVh
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre Línea Vehículo es obligatorio")]
        [Display(Name = "Linea Vh.")]
        public string NombreLineaVh { get; set; }
        public bool Activo { get; set; }
    }
    public class LineaVhDBContext : DbContext
    {
        public DbSet<LineaVh> LineasVh { get; set; }
    }
}