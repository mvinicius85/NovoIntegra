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
        List<AA_ParametrosViewModel> ListarParametros(AA_ParametrosViewModel filtro);
        AA_ParametrosViewModel CarregarParametro(int cod_parametro);
        List<gridCategoriasViewModel> ListarCategorias(DCCategoryViewModel filtro);
        DCCategoryViewModel BuscaCategoria(string cod_categoria);
        List<DCCategoryViewModel> ListarCategorias();
        List<AA_VinculoViewModel> ListarVinculo(string cod_categoria);

    }
}
