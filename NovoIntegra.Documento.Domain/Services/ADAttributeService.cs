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
    public class ADAttributeService : IADAttributeService
    {
        private readonly IADAttributeRepository _adatributerepository;
        public ADAttributeService(IADAttributeRepository adatributerepository)
        {
            _adatributerepository = adatributerepository;
        }

        public List<ADATTRIBUTE> ListaAtributos(string codcategoria)
        {
            return _adatributerepository.ListarAtributos(codcategoria);
        }
    }
}
