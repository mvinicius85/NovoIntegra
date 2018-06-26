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
    public class GNCompFileContCopyRepository : Repository<GNCOMPFILECONTCOPY>, IGNCompFileContCopyRepository
    {
        public GNCompFileContCopyRepository(SeSuiteContext context) : base(context)
        {

        }

        public int ExcluiRegistros(int cdcomp)
        {
            var con = Db.Database.Connection;           

            var sql = "DELETE  FROM GNCOMPFILECONTCOPY WHERE CDCOMPLEXFILECONT > @cdcomp";

            var rows = con.Execute(sql, new { cdcomp = cdcomp }, null,0,null);

            return rows;
        }

        public int RetornaMax()
        {
            var con = Db.Database.Connection;

            var sql = "Select isnull(MAX(CDCOMPLEXFILECONT),0) AS CDCOMPLEXFILECONT from GNCOMPFILECONTCOPY";

            var max = con.Query<int>(sql).FirstOrDefault();

            return max;
        }

    }
}
