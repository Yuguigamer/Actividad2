using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de usuario")]
        [Display(Name = "Nombre de usuario")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no debe exceder los 50 caracteres")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Ingrese la dirección de correo electrónico")]
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una contraseña")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "La contraseña debe tener al menos 4 caracteres", MinimumLength = 4)]
        public string Password { get; set; }

        [Required]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        [Display(Name = "Rol del usuario")]
        public Rol Rol { get; set; }
    }
}
