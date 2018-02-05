using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IDCDocumentService
    {
        int RetornaMax();

        void InsereDocumento(DataRow linha, List<AA_Vinculo> atributos, int cddocument, int cdassoc, int cdrevision, int cdcomp);

        void InsereRevision(DataRow linha, List<AA_Vinculo> atributos, int cddocument, int cdassoc, int cdrevision, int cdcomp, string path);

        void InsereImagem(string path, DataRow linha, int cddocument, List<AA_Vinculo> atributos);

        void ExcluirArquivo(int cddocument, int cdrevision, int gnassoc, int gncomp);
    }
}
