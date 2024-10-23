using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.Models
{
    public class Favorito
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required]
        public int ObraDeArteId { get; set; }

        [ForeignKey("ObraDeArteId")]
        public ObraDeArte ObraDeArte { get; set; }

        [Display(Name = "Fecha agregada a favoritos")]
        [DataType(DataType.Date)]
        public DateTime FechaAgregado { get; set; } = DateTime.Now;
    }
}
