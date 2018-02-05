using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IGNAssocService
    {
        int RetornaMax();
        void Adiciona(GNASSOC gnass);
        int ExcluiRegistros(int cdassoc);
    }
}
