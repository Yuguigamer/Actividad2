using mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository;
using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario> , IUsuarioRepository
    {
        private readonly ApplicationDbContext _db;
        public UsuarioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Usuario usuario)
        {
            var objDesdeDb = _db.Usuario.FirstOrDefault(s => s.Id == usuario.Id);
            objDesdeDb.NombreUsuario = usuario.NombreUsuario;
            objDesdeDb.Email = usuario.Email;
            objDesdeDb.Password = usuario.Password;
            objDesdeDb.RolId = usuario.RolId;

            //_db.SaveChanges();
        }
    }
}
