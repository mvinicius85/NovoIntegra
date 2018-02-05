using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCDOCREVISION
    {
        public DCDOCREVISION()
        {

        }

        public DCDOCREVISION(decimal _cddoc, decimal _cdrev, decimal _fgcur, string _nmtitle,
            string _nmaut, string _iddoc, decimal _cdcateg, decimal _nrhits, DateTime _dtinsert,
            DateTime _dtupt, string _nmuserupt)
        {
            CDDOCUMENT = _cddoc;
            CDREVISION = _cdrev;
            FGCURRENT = _fgcur;
            NMTITLE = _nmtitle;
            NMAUTHOR = _nmaut;
            IDDOCUMENT = _iddoc;
            CDCATEGORY = _cdcateg;
            NRHITS = _nrhits;
            DTINSERT = _dtinsert;
            DTUPDATE = _dtupt;
            NMUSERUPD = _nmuserupt;
        }
        public decimal CDDOCUMENT { get; set; }
        public decimal CDREVISION { get; set; }
        public Nullable<decimal> FGCURRENT { get; set; }
        public Nullable<decimal> FGTRAINREQUIRED { get; set; }
        public string DSSUMMARY { get; set; }
        public string NMTITLE { get; set; }
        public string NMAUTHOR { get; set; }
        public string IDDOCUMENT { get; set; }
        public Nullable<decimal> CDCATEGORY { get; set; }
        public Nullable<decimal> NRHITS { get; set; }
        public Nullable<System.DateTime> DTVALIDITY { get; set; }
        public Nullable<decimal> QTVALIDITY { get; set; }
        public Nullable<decimal> FGTYPEVALID { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMUSERUPD { get; set; }
    }
}
