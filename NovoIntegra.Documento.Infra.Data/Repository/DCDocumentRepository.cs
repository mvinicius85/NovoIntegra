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
    public class DCDocumentRepository : Repository<DCDOCUMENT>, IDCDocumentRepository
    {
        public DCDocumentRepository(SeSuiteContext context) : base(context)
        {

        }

        public int ExcluiDocumentos(int cddocument)
        {
            var con = Db.Database.Connection;

            var sql = "DELETE FROM DCDOCUMENT WHERE CDDOCUMENT > @cddocument";

            var rows = con.Execute(sql, new { cddocument = cddocument });

            return rows;
        }

        public int RetornaMax()
        {
            var con = Db.Database.Connection;

            var sql = "Select MAX(CDDOCUMENT) AS cddocument from DCDOCUMENT";

            var max = con.Query<int>(sql).FirstOrDefault();

            return max;
        }
    }
}
