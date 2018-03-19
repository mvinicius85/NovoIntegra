using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.ViewModel
{
    public class FiltroLogViewModel
    {
        public FiltroLogViewModel()
        {

        }
        public FiltroLogViewModel(DateTime _dtini, DateTime _dtfim, string _idcateg,
            string _lote, bool _inderr, string _iddoc)
        {
            DtInicio = _dtini;
            DtFim = _dtfim;
            IDCategoria = _idcateg;
            Lote = _lote;
            inderro = _inderr;
            IdDocumento = _iddoc;
        }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string IDCategoria { get; set; }
        public string Lote { get; set; }
        public bool inderro { get; set; }
        public string IdDocumento { get; set; }
    }
}
