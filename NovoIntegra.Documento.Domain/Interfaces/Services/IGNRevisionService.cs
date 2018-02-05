using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IGNRevisionService
    {
        int RetornaMax();

        void Adiciona(GNREVISION gnrev);
        int ExcluiRegistros(int cdrevision);
    }
}
