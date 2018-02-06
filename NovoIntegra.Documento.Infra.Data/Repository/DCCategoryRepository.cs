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
    public class DCCategoryRepository : Repository<DCCATEGORY>, IDCCategoryRepository
    {
        public DCCategoryRepository(SeSuiteContext context) : base(context)
        {

        }

        public List<DTOgridAtrib> ListarCategorias(DCCATEGORY filtro)
        {
            var con = Db.Database.Connection;

            var sql = @"Select cat.CDCATEGORY, cat.IDCATEGORY, NMCATEGORY, count(1) qtdeAtrib from DCCATEGORY  cat INNER JOIN 
                        AA_Vinculo vinc ON cat.IDCATEGORY COLLATE Latin1_General_CI_AS = vinc.IDCategory COLLATE Latin1_General_CI_AS" 
                + filtro.MontaSWhere() + " group by cat.CDCATEGORY, cat.IDCATEGORY, NMCATEGORY";

            var categorias = con.Query<DTOgridAtrib>(sql, filtro).ToList();

            return categorias;
        }
    }
}