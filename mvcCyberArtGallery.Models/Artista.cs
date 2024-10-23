using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class Artista
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del artista")]
        [Display(Name = "Nombre del artista")]
        [StringLength(150, ErrorMessage = "El nombre no debe exceder los 150 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el apellido del artista")]
        [Display(Name = "Apellido del artista")]
        [StringLength(150, ErrorMessage = "El apellido no debe exceder los 150 caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Ingrese una descripción")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen de perfil")]
        public string ImagenPerfil { get; set; }
    }
}
