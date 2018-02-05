using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCDOCUMENTATTRIB
    {
        public DCDOCUMENTATTRIB()
        {

        }

        public DCDOCUMENTATTRIB(string tpatrib, decimal _cddoc, decimal _cdatrib, string _nmvalue, decimal _vlvalue,
            DateTime _dtvalue, string _dsvalue, decimal _nrorder, 
            decimal _flreq, DateTime _dtinst, string _nmusrupdt, decimal _cdrev, decimal _flrdonly)
        {
            CDDOCUMENT = _cddoc;
            CDATTRIBUTE = _cdatrib;
            switch (tpatrib.ToUpper())
            {
                case "TEXTO":
                    NMVALUE = _nmvalue;
                    break;
                case "INTEIRO":
                    VLVALUE = _vlvalue;
                    break;
                case "DECIMAL":
                    VLVALUE = _vlvalue;
                    break;
                case "DATA":
                    DTVALUE = _dtvalue;
                    break;
                case "MEMORANDO":
                    DSVALUE = _dsvalue;
                    break;
            }
            NRORDER = _nrorder;
            FGREQUIRED = _flreq;
            DTINSERT = _dtinst;
            NMUSERUPD = _nmusrupdt;
            CDREVISION = _cdrev;
            FGREADONLY = _flrdonly;

        }
        public decimal CDDOCUMENT { get; set; }
        public decimal CDATTRIBUTE { get; set; }
        public Nullable<decimal> CDVALUE { get; set; }
        public string NMVALUE { get; set; }
        public Nullable<decimal> VLVALUE { get; set; }
        public Nullable<System.DateTime> DTVALUE { get; set; }
        public string DSVALUE { get; set; }
        public Nullable<decimal> NRORDER { get; set; }
        public Nullable<decimal> FGREQUIRED { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMUSERUPD { get; set; }
        public string NMREFCODE { get; set; }
        public decimal CDREVISION { get; set; }
        public Nullable<decimal> FGREADONLY { get; set; }
    }
}
