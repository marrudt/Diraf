using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diraf.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo Documento es obligatorio")]
        [Display(Name = "No. Documento")] 
        public string Documento { get; set; }
        
        [Required(ErrorMessage = "El campo Nombre Usuario es obligatorio")]
        [Display(Name = "Nombre Usuario")]
        public string Nombre_Usuario { get; set; }
        public bool Activo { get; set; }
    }
    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}