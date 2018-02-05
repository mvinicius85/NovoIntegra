using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class GNREVISION
    {
        public GNREVISION()
        {

        }

        public GNREVISION(decimal _cdrev, string _idrev, DateTime _dtrev, decimal _fgstat,
            DateTime _dtrevcreate, decimal _cdrevuser, decimal _cdisosys, DateTime _dtinsert,
            string _nmuser, decimal _cdassoc)
        {
            CDREVISION = _cdrev;
            IDREVISION = _idrev;
            DTREVISION = _dtrev;
            FGSTATUS = _fgstat;
            DTREVCREATE = _dtrevcreate;
            CDREVUSERCREATE = _cdrevuser;
            CDISOSYSTEM = _cdisosys;
            DTINSERT = _dtinsert;
            NMUSERUPD = _nmuser;
            CDASSOC = _cdassoc;
        }


        public decimal CDREVISION { get; set; }
        public string IDREVISION { get; set; }
        public Nullable<System.DateTime> DTREVISION { get; set; }
        public Nullable<decimal> FGSTATUS { get; set; }
        public Nullable<System.DateTime> DTREVCREATE { get; set; }
        public Nullable<decimal> CDREVUSERCREATE { get; set; }
        public Nullable<System.DateTime> DTREVRELEASE { get; set; }
        public Nullable<decimal> CDREVUSERRELEASE { get; set; }
        public string DSJUSTIFY { get; set; }
        public Nullable<decimal> FGREVCLOSEMETHOD { get; set; }
        public Nullable<System.DateTime> DTREVPROGSTART { get; set; }
        public Nullable<System.DateTime> DTREVPROGFINISH { get; set; }
        public Nullable<System.DateTime> DTREVREALSTART { get; set; }
        public Nullable<System.DateTime> DTREVREALFINISH { get; set; }
        public Nullable<System.DateTime> DTREVRELEASEDEAD { get; set; }
        public Nullable<decimal> CDREASON { get; set; }
        public Nullable<decimal> CDISOSYSTEM { get; set; }
        public string DSREVISIONRELEASE { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMUSERUPD { get; set; }
        public string TMREVISION { get; set; }
        public Nullable<decimal> CDREVISIONSTATUS { get; set; }
        public Nullable<decimal> CDREVCONFIG { get; set; }
        public Nullable<decimal> CDACTIONASSOC { get; set; }
        public Nullable<System.DateTime> DTVALIDITY { get; set; }
        public Nullable<decimal> FGVALIDITY { get; set; }
        public Nullable<decimal> QTVALIDITY { get; set; }
        public Nullable<decimal> CDASSOC { get; set; }
    }
}
