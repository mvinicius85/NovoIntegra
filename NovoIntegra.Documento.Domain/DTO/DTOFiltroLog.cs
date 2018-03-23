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
        public string IdDocumento { get; set; }
        public string Documento { get; set; }

        public string SWhere()
        {
            StringBuilder swhere = new StringBuilder();

            if (!String.IsNullOrEmpty(IdDocumento))
            {
                return "IdDocumentSE = @IdDocumento ";
            }

            swhere.Append(" dtevento between @DtInicio  and @DtFim ");

            if (!String.IsNullOrEmpty(IDCategoria))
            {
                swhere.Append(" and Categoria = @IDCategoria ");
            }

            if (!String.IsNullOrEmpty(Documento))
            {
                Documento = "%" + Documento + "%";
                swhere.Append(" and Documento like @Documento ");
            }

            if (inderro)
            {
                swhere.Append(" and IndErro = 1 ");
            }

            

            return swhere.ToString();
        }
    }
}
