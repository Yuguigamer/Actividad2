using mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository
{
    public class RolRepository : Repository<Rol> , IRolRepository
    {
        private readonly ApplicationDbContext _db;
        public RolRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Rol rol)
        {
            var objDesdeDb = _db.Rol.FirstOrDefault(s => s.Id == rol.Id);
            objDesdeDb.NombreRol = rol.NombreRol;


            //_db.SaveChanges();
        }
    }
}
