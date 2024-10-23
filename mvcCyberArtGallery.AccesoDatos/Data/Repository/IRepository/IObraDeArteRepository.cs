using mvcCyberArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCyberArtGallery.AccesoDatos.Data.Repository.IRepository
{
    public interface IObraDeArteRepository : IRepository<ObraDeArte>
    {
        void Update(ObraDeArte obraDeArte);
    }
}
