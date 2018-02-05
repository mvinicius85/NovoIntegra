using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Infra.Data.Repository
{
    public class VinculoRepository : Repository<AA_Vinculo>, IVinculoRepository
    {
        public VinculoRepository(SeSuiteContext context) : base(context)
        {

        }
    }
}
