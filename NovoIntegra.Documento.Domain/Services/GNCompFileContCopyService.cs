using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Services
{
    public class GNCompFileContCopyService : IGNCompFileContCopyService
    {
        private readonly IGNCompFileContCopyRepository _gncomprepository;

        public GNCompFileContCopyService(IGNCompFileContCopyRepository gncomprepository)
        {
            _gncomprepository = gncomprepository;
        }

        public int RetornaMax()
        {
            return _gncomprepository.RetornaMax();
        }
    }
}
