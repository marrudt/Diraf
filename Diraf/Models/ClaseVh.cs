using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class ClaseVh
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre Clase Vehiculo es obligatorio")]
        [Display(Name = "Clase Vh.")]
        public string NombreClaseVh { get; set; }
        public bool Activo { get; set; }
    }
    public class ClaseVhDBContext : DbContext
    {
        public DbSet<ClaseVh> ClasesVh { get; set; }
    }
}