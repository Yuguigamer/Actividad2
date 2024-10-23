using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la categoría")]
        [Display(Name = "Nombre de la categoría")]
        [StringLength(50, ErrorMessage = "El nombre de la categoría no debe exceder los 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese una descripción")]
        [Display(Name = "Descripción de la categoría")]
        public string Descripcion { get; set; }
    }
}
