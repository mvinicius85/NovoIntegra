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
    public class GNAssocRepository : Repository<GNASSOC>, IGNAssocRepository
    {
        public GNAssocRepository(SeSuiteContext context) : base(context)
        {

        }

        public int ExcluiRegistros(int cdassoc)
        {
            var con = Db.Database.Connection;

            var sql = "DELETE FROM GNASSOC WHERE CDASSOC > @cdassoc";

            var rows = con.Execute(sql, new { cdassoc = cdassoc });

            return rows;
        }

        public int RetornaMax()
        {
            var con = Db.Database.Connection;

            var sql = "Select MAX(CDASSOC) AS CDASSOC from  GNASSOC";

            var max = con.Query<int>(sql).FirstOrDefault();

            return max;
        }
    }
}
