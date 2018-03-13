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

            var rows = con.Execute(sql, new { cddocument = cddocument }, null, 0, null);

            return rows;
        }

        public decimal RetornaCaixa(string rua, string coluna, string prateleira, string fileira, string caixa)
        {
            var con = Db.Database.Connection;
            var sql = @"Select DCPHYSICALFILE.CDPHYSICALFILE FROM DCPHYSICALFILE DCPHYSICALFILE, DCPHYSLOCATION DCPHYSLOCATION,
                        DCPHYSLOCATION DCPHYSLOCATION_1, DCPHYSLOCATION DCPHYSLOCATION_2, DCPHYSLOCATION DCPHYSLOCATION_3
                        WHERE DCPHYSLOCATION.CDPHYSLOCATION = DCPHYSLOCATION_1.CDPHYSLOCOWNER AND 
                        DCPHYSLOCATION_1.CDPHYSLOCATION = DCPHYSLOCATION_2.CDPHYSLOCOWNER AND 
                        DCPHYSLOCATION_2.CDPHYSLOCATION = DCPHYSLOCATION_3.CDPHYSLOCOWNER AND 
                        DCPHYSICALFILE.CDPHYSLOCATION = DCPHYSLOCATION_3.CDPHYSLOCATION
                        AND  Replace(DCPHYSLOCATION.NMPHYSLOCATION ,'Rua ' ,'R') = @rua
                        AND  Replace(DCPHYSLOCATION_1.NMPHYSLOCATION ,'Coluna ' ,'C') = @coluna
                        AND  Replace(DCPHYSLOCATION_2.NMPHYSLOCATION ,'Prateleira ' ,'P') = @prateleira
                        AND  Replace(DCPHYSLOCATION_3.NMPHYSLOCATION ,'Fileira ' ,'F') = @fileira
                        AND  Replace(DCPHYSICALFILE.NMBOX ,'Caixa ' ,'CX') = @caixa";
                

            var codcaixa = con.Query<decimal>(sql, new {rua = rua, coluna = coluna, prateleira = prateleira, fileira = fileira, caixa = caixa }).FirstOrDefault();

            return codcaixa;
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
