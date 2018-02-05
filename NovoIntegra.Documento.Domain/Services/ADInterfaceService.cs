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
    public class ADInterfaceService : IADInterfaceService
    {
        private readonly IADInterfaceRepository _adinterfacerepository;

        public ADInterfaceService(IADInterfaceRepository adinterfacerepository)
        {
            _adinterfacerepository = adinterfacerepository;
        }
        public void Adiciona(ADINTERFACE item)
        {
            _adinterfacerepository.Adicionar(item);
        }

        public int RetornaMax()
        {
            return _adinterfacerepository.RetornaMax();
        }
    }
}
