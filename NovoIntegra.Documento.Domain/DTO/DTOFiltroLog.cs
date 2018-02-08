using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.DTO
{
    public class DTOFiltroLog
    {
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string IDCategoria { get; set; }
        public string Lote { get; set; }
        public bool inderro { get; set; }

        public string SWhere()
        {
            StringBuilder swhere = new StringBuilder();

            swhere.Append(" dtevento between @DtInicio  and @DtFim ");

            if (!String.IsNullOrEmpty(IDCategoria))
            {
                swhere.Append(" and IDCategoria = @IDCategoria ");
            }

            if (!String.IsNullOrEmpty(Lote))
            {
                Lote = "%" + Lote + "%";
                swhere.Append(" and Lote like @Lote ");
            }

            return swhere.ToString();
        }
    }
}
