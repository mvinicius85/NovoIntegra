using Dapper;
using NovoIntegra.Documento.Domain.DTO;
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
    public class LogRepository : Repository<AA_Log>, ILogRepository
    {
        public LogRepository(SeSuiteContext context) : base(context)
        {

        }

        public List<AA_Log> ListarLog(DTOFiltroLog filtro)
        {
            var con = Db.Database.Connection;

            var sql = "SELECT * from AA_Log where " + filtro.SWhere();

            var log = con.Query<AA_Log>(sql, filtro).ToList();

            return log;
        }
    }
}
