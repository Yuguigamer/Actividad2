using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del rol")]
        [Display(Name = "Nombre del rol")]
        [StringLength(50, ErrorMessage = "El nombre del rol no debe exceder los 50 caracteres")]
        public string NombreRol { get; set; }
    }
}
