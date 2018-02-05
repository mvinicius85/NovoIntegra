using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class AA_Vinculo
    {
        public int Cod_Vinculo { get; set; }
        public string IDCategory { get; set; }
        public int CDAttribuite_SE { get; set; }
        public string NmCampoImagem { get; set; }
        public bool Ind_Titulo { get; set; }
        public int Cod_TipoCampo { get; set; }
    }
}
