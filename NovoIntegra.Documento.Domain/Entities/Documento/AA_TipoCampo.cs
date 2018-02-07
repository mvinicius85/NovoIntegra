using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class AA_TipoCampo
    {
        public AA_TipoCampo()
        {
            this.AA_Vinculo = new List<AA_Vinculo>();
        }

        public int Cod_TipoCampo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AA_Vinculo> AA_Vinculo { get; set; }
    }
}
