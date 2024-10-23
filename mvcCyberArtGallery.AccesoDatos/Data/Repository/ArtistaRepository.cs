using mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository
{
    public class ArtistaRepository : Repository<Artista>, IArtistaRepository
    {
        private readonly ApplicationDbContext _db;
        public ArtistaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Artista artista)
        {
            var objDesdeDb = _db.Artista.FirstOrDefault(s => s.Id == artista.Id);
            objDesdeDb.Nombre = artista.Nombre;
            objDesdeDb.Apellido = artista.Apellido;
            objDesdeDb.Descripcion = artista.Descripcion;
            objDesdeDb.ImagenPerfil = artista.ImagenPerfil;

            //_db.SaveChanges();
        }
    }
}
