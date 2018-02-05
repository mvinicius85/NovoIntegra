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
    public class ParametrosRepository : Repository<AA_Parametros>, IParametrosRepository
    {
        public ParametrosRepository(SeSuiteContext context) : base(context)
        {

        }
    }
}
