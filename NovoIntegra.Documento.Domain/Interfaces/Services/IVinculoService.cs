using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IVinculoService
    {
        List<AA_Vinculo> RetornaAtributos(string idcategory);
        void AdicionaVinculo(AA_Vinculo aA_Vinculo);
        void ExcluiVinculos(string codcategoria);
    }
}
