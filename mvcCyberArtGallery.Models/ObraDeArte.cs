using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class ObraDeArte
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el título de la obra de arte")]
        [Display(Name = "Título de la obra de arte")]
        [StringLength(100, ErrorMessage = "El título no debe exceder los 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Ingrese la descripción de la obra de arte")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen de la obra")]
        public string ImagenUrl { get; set; }

        [Required]
        public int ArtistaId { get; set; }

        [ForeignKey("ArtistaId")]
        public Artista Artista { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Display(Name = "Fecha de creación")]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }
    }
}
