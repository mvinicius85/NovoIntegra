using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class AA_Vinculo
    {
        public int Cod_Vinculo { get; set; }
        public string IDCategory { get; set; }
        public Nullable<decimal> CDAttribute_SE { get; set; }
        public string NmCampoImagem { get; set; }
        public bool Ind_Titulo { get; set; }
        public int Cod_TipoCampo { get; set; }
        public bool ind_localfisico { get; set; }
        public virtual AA_TipoCampo AA_TipoCampo { get; set; }
        public virtual ADATTRIBUTE ADATTRIBUTE { get; set; }
    }
}
