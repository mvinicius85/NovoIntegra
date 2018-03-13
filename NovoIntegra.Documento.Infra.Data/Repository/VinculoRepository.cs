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
    public class VinculoRepository : Repository<AA_Vinculo>, IVinculoRepository
    {
        public VinculoRepository(SeSuiteContext context) : base(context)
        {

        }

        public void ExcluirVinculos(string codcategoria)
        {
            var con = Db.Database.Connection;

            var sql = "Delete from AA_Vinculo where IDCATEGORY = @codcategoria";

            //var max = con.Query<int>(sql).FirstOrDefault();
            var teste = con.Execute(sql, new { codcategoria = codcategoria }, null, 0, null);
        }
    }
}
