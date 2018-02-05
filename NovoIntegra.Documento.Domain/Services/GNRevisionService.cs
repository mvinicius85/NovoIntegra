using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Services
{
    public class GNRevisionService : IGNRevisionService
    {
        private readonly IGNRevisionRepository _gnrevisionrepository;

        public GNRevisionService(IGNRevisionRepository gnrevisionrepository)
        {
            _gnrevisionrepository = gnrevisionrepository;
        }

        public void Adiciona(GNREVISION gnrev)
        {
            _gnrevisionrepository.Adicionar(gnrev);
        }

        public int ExcluiRegistros(int cdrevision)
        {
            return _gnrevisionrepository.ExcluiRegistros(cdrevision);
        }

        public int RetornaMax()
        {
            return _gnrevisionrepository.RetornaMax();
        }
    }
}
