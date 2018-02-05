using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class ADINTERFACE
    {
        public ADINTERFACE()
        {

        }

        public ADINTERFACE(decimal _cdinterface, decimal _fgimport, decimal _cdisosys, decimal _fgopt,
            string _nm01, string _nm02, string _nm03, string _nm05, string _nm06, string _nm07)
        {
            CDINTERFACE = _cdinterface;
            FGIMPORT = _fgimport;
            CDISOSYSTEM = _cdisosys;
            FGOPTION = _fgopt;
            NMFIELD01 = _nm01;
            NMFIELD02 = _nm02;
            NMFIELD03 = _nm03;
            NMFIELD05 = _nm05;
            NMFIELD06 = _nm06;
            NMFIELD07 = _nm07;
        }


        public decimal CDINTERFACE { get; set; }
        public Nullable<decimal> CDISOSYSTEM { get; set; }
        public Nullable<decimal> CDSCHEDULE { get; set; }
        public Nullable<System.DateTime> DTEXECUTION { get; set; }
        public Nullable<decimal> FGIMPORT { get; set; }
        public Nullable<decimal> FGBLOBOPTION { get; set; }
        public Nullable<decimal> FGOPTION { get; set; }
        public Nullable<decimal> QTHRFINISH { get; set; }
        public Nullable<decimal> QTHRINIT { get; set; }
        public string DSERROR { get; set; }
        public Nullable<decimal> NRSEQUENCE { get; set; }
        public string NMFIELD01 { get; set; }
        public string NMFIELD02 { get; set; }
        public string NMFIELD03 { get; set; }
        public string NMFIELD04 { get; set; }
        public string NMFIELD05 { get; set; }
        public string NMFIELD06 { get; set; }
        public string NMFIELD07 { get; set; }
        public string NMFIELD08 { get; set; }
        public string NMFIELD09 { get; set; }
        public string NMFIELD10 { get; set; }
        public string NMFIELD11 { get; set; }
        public string NMFIELD12 { get; set; }
        public string NMFIELD13 { get; set; }
        public string NMFIELD14 { get; set; }
        public string NMFIELD15 { get; set; }
        public string NMFIELD16 { get; set; }
        public string NMFIELD17 { get; set; }
        public string NMFIELD18 { get; set; }
        public string NMFIELD19 { get; set; }
        public string NMFIELD20 { get; set; }
        public string NMFIELD21 { get; set; }
        public string NMFIELD22 { get; set; }
        public string NMFIELD23 { get; set; }
        public string NMFIELD24 { get; set; }
        public string NMFIELD25 { get; set; }
        public string NMFIELD26 { get; set; }
        public string NMFIELD27 { get; set; }
        public string NMFIELD28 { get; set; }
        public string NMFIELD29 { get; set; }
        public string NMFIELD30 { get; set; }
        public string NMFIELD31 { get; set; }
        public string NMFIELD32 { get; set; }
        public string NMFIELD33 { get; set; }
        public string NMFIELD34 { get; set; }
        public string NMFIELD35 { get; set; }
        public string NMFIELD36 { get; set; }
        public string NMFIELD37 { get; set; }
        public string NMFIELD38 { get; set; }
        public string NMFIELD39 { get; set; }
        public string NMFIELD40 { get; set; }
        public string NMFIELD41 { get; set; }
        public string NMFIELD42 { get; set; }
        public string NMFIELD43 { get; set; }
        public string NMFIELD44 { get; set; }
        public string NMFIELD45 { get; set; }
        public string NMFIELD46 { get; set; }
        public string NMFIELD47 { get; set; }
        public string NMFIELD48 { get; set; }
        public string NMFIELD49 { get; set; }
        public string NMFIELD50 { get; set; }
        public string NMFIELD51 { get; set; }
        public string NMFIELD52 { get; set; }
        public string NMFIELD53 { get; set; }
        public string NMFIELD54 { get; set; }
        public string NMFIELD55 { get; set; }
        public string NMFIELD56 { get; set; }
        public string NMFIELD57 { get; set; }
        public string NMFIELD58 { get; set; }
        public string NMFIELD59 { get; set; }
        public string NMFIELD60 { get; set; }
        public string NMFIELD61 { get; set; }
        public string NMFIELD62 { get; set; }
        public string NMFIELD63 { get; set; }
        public string NMFIELD64 { get; set; }
        public string NMFIELD65 { get; set; }
        public string NMFIELD66 { get; set; }
        public string NMFIELD67 { get; set; }
        public string NMFIELD68 { get; set; }
        public string NMFIELD69 { get; set; }
        public string NMFIELD70 { get; set; }
        public string NMFIELD71 { get; set; }
        public string NMFIELD72 { get; set; }
        public string NMFIELD73 { get; set; }
        public string NMFIELD74 { get; set; }
        public string NMFIELD75 { get; set; }
        public string DSFIELD01 { get; set; }
        public string DSFIELD02 { get; set; }
        public string DSFIELD03 { get; set; }
        public string DSFIELD04 { get; set; }
        public string DSFIELD05 { get; set; }
        public byte[] FLFIELD01 { get; set; }
    }
}
