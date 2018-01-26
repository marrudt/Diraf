using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class ClaseServicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Clase Servicio es obligatorio")]
        [Display(Name = "Clase Servicio")]
        public string NombreServicio { get; set; }
        public bool Activo { get; set; }
    }
    public class ClaseServicioDBContext : DbContext
    {
        public DbSet<ClaseServicio> Servicioes { get; set; }
    }
}