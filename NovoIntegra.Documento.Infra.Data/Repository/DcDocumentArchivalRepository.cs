﻿using Dapper;
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
    public class DcDocumentArchivalRepository : Repository<DCDOCUMENTARCHIVAL>, IDcDocumentArchivalRepository
    {
        public DcDocumentArchivalRepository(SeSuiteContext context) : base(context)
        {

        }

        public int ExcluiRegistros(int cddocument)
        {
            var con = Db.Database.Connection;

            var sql = "DELETE FROM DCDOCUMENTARCHIVAL WHERE CDDOCUMENT > @cddocument";

            var rows = con.Execute(sql, new { cddocument = cddocument });

            return rows;
        }
    }
}
