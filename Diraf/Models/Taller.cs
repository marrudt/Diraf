using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class Taller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre Taller es obligatorio")]
        [Display(Name = "Taller")]
        public string NombreTaller { get; set; }

        public bool Active { get; set; }       
    }
    public class TallerDBContext : DbContext
    {
        public DbSet<Taller> Talleres { get; set; }
    }
}