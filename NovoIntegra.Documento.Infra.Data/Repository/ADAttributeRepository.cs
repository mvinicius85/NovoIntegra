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
    public class ADAttributeRepository : Repository<ADATTRIBUTE>, IADAttributeRepository
    {
        public ADAttributeRepository(SeSuiteContext context) : base(context)
        {

        }

        public List<ADATTRIBUTE> ListarAtributos(string codcategoria)
        {
            var con = Db.Database.Connection;

            var sql = @"SELECT adatrib.* FROM ADATTRIBUTE adatrib
                        INNER JOIN DCCATDOCATTRIB catatrib ON adatrib.CDATTRIBUTE = catatrib.CDATTRIBUTE
                        INNER JOIN DCCATEGORY cat ON cat.CDCATEGORY = catatrib.CDCATEGORY 
                        WHERE cat.IDCATEGORY = @codcategoria";

            var atrib = con.Query<ADATTRIBUTE>(sql, new { codcategoria = codcategoria }).ToList();

            return atrib;
        }
    }
}
