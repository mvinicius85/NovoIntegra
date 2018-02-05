using System;
using System.Collections.Generic;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class AA_Log
    {
        public AA_Log()
        {

        }
        public AA_Log(string _arq, string _doc, string _cat, string _msg, string _errsis, DateTime _data, bool _inderr)
        {
            Arquivo = _arq;
            Documento = _doc;
            Categoria = _cat;
            Msg = _msg;
            MsgErroSistema = _errsis;
            DtEvento = _data;
            IndErro = _inderr;
        }
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
