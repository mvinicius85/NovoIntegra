using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class GNASSOC
    {
        public GNASSOC()
        {

        }

        public GNASSOC(decimal _cdassoc, decimal _nrobject)
        {
            CDASSOC = _cdassoc;
            NROBJECTPARENT = _nrobject;
        }
        public decimal CDASSOC { get; set; }
        public Nullable<decimal> NROBJECTPARENT { get; set; }
    }
}
