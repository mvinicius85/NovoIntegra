using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class ADATTRIBUTE
    {
        public ADATTRIBUTE()
        {
            this.AA_Vinculo = new List<AA_Vinculo>();
        }

        public decimal CDATTRIBUTE { get; set; }
        public Nullable<decimal> CDISOSYSTEM { get; set; }
        public string NMATTRIBUTE { get; set; }
        public string DSATTRIBUTE { get; set; }
        public Nullable<decimal> FGDATATYPE { get; set; }
        public Nullable<decimal> FGATTRIBUTETYPE { get; set; }
        public Nullable<decimal> QTDATALENGTH { get; set; }
        public Nullable<decimal> VLINITIAL { get; set; }
        public Nullable<decimal> VLFINAL { get; set; }
        public Nullable<System.DateTime> DTFINAL { get; set; }
        public Nullable<System.DateTime> DTINITIAL { get; set; }
        public Nullable<decimal> FGATTRIBENABLE { get; set; }
        public string NMCONNDBSERVER { get; set; }
        public Nullable<decimal> FGCONNDBTYPE { get; set; }
        public string NMCONNDBALIAS { get; set; }
        public string DSCONNDBSQL { get; set; }
        public string NMCONNDBUSER { get; set; }
        public string NMCONNDBPASSWD { get; set; }
        public Nullable<decimal> FGENABLELINK { get; set; }
        public Nullable<decimal> CDATTRIBUTELINK { get; set; }
        public string NMFILTERFIELD { get; set; }
        public string NMFILTEREDFIELD { get; set; }
        public string NMREFERENCECOLUMN { get; set; }
        public string NMLABEL { get; set; }
        public string NMUSERUPD { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMCONNDBSQL { get; set; }
        public Nullable<decimal> FGSELECTIONTYPE { get; set; }
        public Nullable<decimal> FGDEFAULTOPERATOR { get; set; }
        public Nullable<decimal> FGMULTIVALUED { get; set; }
        public Nullable<decimal> QTMEMLINES { get; set; }
        public Nullable<decimal> FGMEMZOOM { get; set; }
        public string NMFILTER { get; set; }
        public virtual ICollection<AA_Vinculo> AA_Vinculo { get; set; }
    }
}
