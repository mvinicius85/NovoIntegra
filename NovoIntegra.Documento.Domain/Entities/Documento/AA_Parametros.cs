using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class AA_Parametros
    {
        public int Cod_Parametro { get; set; }
        public string NomeParametro { get; set; }   
        public string Descricao { get; set; }
        public string Valor { get; set; }
    }
}
