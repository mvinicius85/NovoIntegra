using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.ViewModel
{
    public class AA_LogViewModel
    {
        public int Cod_EntradaLog { get; set; }
        public string Arquivo { get; set; }
        public string Documento { get; set; }
        public string Categoria { get; set; }
        public string Msg { get; set; }
        public string MsgErroSistema { get; set; }
        public System.DateTime DtEvento { get; set; }
        public bool IndErro { get; set; }
    }
}
