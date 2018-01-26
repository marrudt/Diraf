using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class Unidad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre Unidad es obligatorio")]
        [Display(Name = "Unidad")]
        public string NombreUnidad { get; set; }

        public bool Activo { get; set; }
    }
    public class UnidadDBContext : DbContext
    {
        public DbSet<Unidad> Unidades { get; set; }
    }
}