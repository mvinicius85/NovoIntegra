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
    public class VinculoService : IVinculoService
    {
        private readonly IVinculoRepository _vinculorepository;

        public VinculoService(IVinculoRepository vinculorepository)
        {
            _vinculorepository = vinculorepository;
        }

        public void AdicionaVinculo(AA_Vinculo aA_Vinculo)
        {
            _vinculorepository.Adicionar(aA_Vinculo);
        }

        public void ExcluiVinculos(string codcategoria)
        {
            _vinculorepository.ExcluirVinculos(codcategoria);
        }

        public List<AA_Vinculo> RetornaAtributos(string idcategory)
        {
            return _vinculorepository.Buscar(x => x.IDCategory == idcategory).ToList();
        }
    }
}
