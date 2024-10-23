using mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository
{
    public class FavoritoRepository : Repository<Favorito> , IFavoritoRepository
    {
        private readonly ApplicationDbContext _db;
        public FavoritoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Favorito favorito)
        {
            var objDesdeDb = _db.Favorito.FirstOrDefault(s => s.Id == favorito.Id);
            objDesdeDb.UsuarioId = favorito.UsuarioId;
            objDesdeDb.ObraDeArteId = favorito.ObraDeArteId;
            //objDesdeDb.FechaAgregado = favorito.FechaAgregado;

            //_db.SaveChanges();
        }
    }
}
