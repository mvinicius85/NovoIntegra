using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IADInterfaceService
    {
        void Adiciona(ADINTERFACE item);

        int RetornaMax();
    }
}
