using mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository
{
    public class ObraDeArteRepository : Repository<ObraDeArte> , IObraDeArteRepository 
    {
        private readonly ApplicationDbContext _db;
        public ObraDeArteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ObraDeArte obraDeArte)
        {
            var objDesdeDb = _db.ObraDeArte.FirstOrDefault(s => s.Id == obraDeArte.Id);
            objDesdeDb.Titulo = obraDeArte.Titulo;
            objDesdeDb.Descripcion = obraDeArte.Descripcion;
            objDesdeDb.ImagenUrl = obraDeArte.ImagenUrl;
            objDesdeDb.ArtistaId = obraDeArte.ArtistaId;
            objDesdeDb.CategoriaId = obraDeArte.CategoriaId;
            objDesdeDb.FechaCreacion = obraDeArte.FechaCreacion;

            //_db.SaveChanges();
        }
    }
}
