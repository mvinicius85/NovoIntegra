using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCFILE
    {
        public DCFILE()
        {

        }

        public DCFILE(Decimal _cdcomp, decimal _cddoc, decimal _cdrev)
        {
            CDCOMPLEXFILECONT = _cdcomp;
            CDDOCUMENT = _cddoc;
            CDREVISION = _cdrev;
        }
        public decimal CDCOMPLEXFILECONT { get; set; }
        public Nullable<decimal> CDDOCUMENT { get; set; }
        public Nullable<decimal> CDREVISION { get; set; }
    }
}
