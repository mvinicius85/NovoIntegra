using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCDOCUMENT
    {
        public DCDOCUMENT()
        {

        }
        public DCDOCUMENT(decimal _cddoc, decimal _fgstat, decimal _fgusecat, decimal _cdcreat)
        {
            CDDOCUMENT = _cddoc;
            FGSTATUS = _fgstat;
            FGUSECATACCESSROLE = _fgusecat;
            CDCREATEDBY = _cdcreat;
        }
        public decimal CDDOCUMENT { get; set; }
        public Nullable<decimal> CDCATEGORY { get; set; }
        public Nullable<System.DateTime> DTDOCUMENT { get; set; }
        public Nullable<decimal> FGSTATUS { get; set; }
        public string DSSUMMARY { get; set; }
        public string NMTITLE { get; set; }
        public string NMAUTHOR { get; set; }
        public string IDDOCUMENT { get; set; }
        public string DSDOCCANCEL { get; set; }
        public Nullable<decimal> FGUSECATACCESSROLE { get; set; }
        public Nullable<decimal> CDCREATEDBY { get; set; }
        public Nullable<decimal> NRHITS { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMUSERUPD { get; set; }
        public Nullable<System.DateTime> DTVALIDITY { get; set; }
        public Nullable<decimal> QTVALIDITY { get; set; }
        public Nullable<decimal> FGTYPEVALID { get; set; }
        public Nullable<decimal> CDPROD { get; set; }
        public Nullable<decimal> CDAPPROV { get; set; }
        public Nullable<decimal> CDTEMPARCHIVAL { get; set; }
        public Nullable<decimal> CDFAVORITE { get; set; }
    }
}
