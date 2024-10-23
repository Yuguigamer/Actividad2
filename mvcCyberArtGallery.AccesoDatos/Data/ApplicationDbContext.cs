using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Poner aquí todos los modelos que se vayan creando
        public DbSet<Artista> Artista { get; set; }
        public DbSet<ObraDeArte> ObraDeArte { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Favorito> Favorito { get; set; }
        
    }
}
