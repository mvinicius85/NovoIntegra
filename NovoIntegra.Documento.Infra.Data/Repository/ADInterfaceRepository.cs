using Dapper;
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
    public class ADInterfaceRepository : Repository<ADINTERFACE>, IADInterfaceRepository
    {
        public ADInterfaceRepository(SeSuiteContext context) : base(context)
        {

        }

        public int RetornaMax()
        {
            var con = Db.Database.Connection;

            var sql = "SELECT isnull(max(CDINTERFACE),0) CDINTERFACE FROM ADINTERFACE";

            var max = con.Query<int>(sql).FirstOrDefault();

            return max;
        }
    }
}
