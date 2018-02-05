using NovaIntegra.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.Interfaces
{
    public interface IDocumentoAppService
    {
        List<DCCategoryViewModel> BuscarTodas();
        DataTable AbreArquivo(string path);

        bool InsereDocumento(string pathfile, string path, string file);

        string RetornaDiretorio(string param);
    }
}
