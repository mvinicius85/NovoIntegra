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
    public class GNRevisionRepository : Repository<GNREVISION>, IGNRevisionRepository
    {
        public GNRevisionRepository(SeSuiteContext context) : base(context)
        {

        }

        public int ExcluiRegistros(int cdrevision)
        {
            var con = Db.Database.Connection;

            var sql = "DELETE  FROM GNREVISION WHERE CDREVISION > @cdrevision";

            var rows = con.Execute(sql, new { cdrevision = cdrevision });

            return rows;
        }

        public int RetornaMax()
        {
            var con = Db.Database.Connection;

            var sql = "Select MAX(CDREVISION) AS CDREVISION from GNREVISION ";

            var max = con.Query<int>(sql).FirstOrDefault();

            return max;
        }
    }
}
