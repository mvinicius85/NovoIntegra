using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCDOCUMENTARCHIVAL
    {
        public decimal CDDOCUMENT { get; set; }
        public Nullable<decimal> CDPHYSFILECURRENT { get; set; }
        public Nullable<decimal> CDPHYSFILEINTERMED { get; set; }
        public Nullable<decimal> CDPHYSFILEFINLDEST { get; set; }
        public Nullable<decimal> FGUSESTATUS { get; set; }
        public Nullable<decimal> FGSTATUSPHYSFILE { get; set; }
        public Nullable<decimal> CDUSERARCCURRENT { get; set; }
        public Nullable<System.DateTime> DTARCCURRENT { get; set; }
        public Nullable<decimal> CDUSERARCINTERMED { get; set; }
        public Nullable<System.DateTime> DTARCINTERMED { get; set; }
        public Nullable<decimal> CDUSERARCFINLDEST { get; set; }
        public Nullable<System.DateTime> DTARCFINLDEST { get; set; }
        public Nullable<decimal> CDMEDIA { get; set; }
        public Nullable<decimal> CDUSERREC { get; set; }
        public Nullable<System.DateTime> DTDEADLINECURRENT { get; set; }
        public Nullable<System.DateTime> DTDEADLINEINTERMED { get; set; }
        public Nullable<System.DateTime> DTUSERREC { get; set; }
        public Nullable<System.DateTime> DTDEADLINEREC { get; set; }
        public Nullable<decimal> FGACTIONSTATUS { get; set; }
        public Nullable<decimal> CDCURRENTRECEIPT { get; set; }
        public Nullable<decimal> CDINTERMEDRECEIPT { get; set; }
        public Nullable<decimal> CDFINLDESTRECEIPT { get; set; }
        public string IDMEDIAPOSITION { get; set; }
        public Nullable<decimal> CDMEDIARECEIPT { get; set; }
        public Nullable<decimal> CDCOMPLIENCERET { get; set; }
        public Nullable<decimal> CDREVISION { get; set; }
    }
}
