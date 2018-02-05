using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class GNCOMPFILECONTCOPY
    {
        public GNCOMPFILECONTCOPY()
        {

        }

        public GNCOMPFILECONTCOPY(decimal _cdcomp, decimal _fgfile, decimal _cdiso)
        {
            CDCOMPLEXFILECONT = _cdcomp;
            FGFILETYPE = _fgfile;
            CDISOSYSTEM = _cdiso;
        }


        public decimal CDCOMPLEXFILECONT { get; set; }
        public Nullable<decimal> FGFILETYPE { get; set; }
        public string IDCOMPLEXFILECONT { get; set; }
        public string NMCOMPLEXFILECONT { get; set; }
        public Nullable<decimal> FGCONECTOR { get; set; }
        public Nullable<decimal> CDISOSYSTEM { get; set; }
        public Nullable<decimal> FGDRAWTOISODOC { get; set; }
        public Nullable<decimal> CDCATEGORY { get; set; }
        public string IDCONFIGURATION { get; set; }
    }
}
