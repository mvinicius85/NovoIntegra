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
        List<AA_TipoCampoViewModel> ListarTiposCampo();
        List<AA_LogViewModel> BuscarLog(FiltroLogViewModel filtro);
        List<ADATTRIBUTEViewModel> BuscarAtributos(string codcategoria);
        void AdicionaVinculo(AA_VinculoViewModel item);
        void ExcluirVinculos(string codcategoria);
        void AtualizaParametro(AA_ParametrosViewModel param);
        bool StatusServico();
        void LigarServico();
        void DesligarServico();
        bool ValidarArquivo(string fullName, string directoryName, string name);
        bool AlteraArquivo(string fullName);
        bool UpdateArquivo(string fullName, string v);
        bool ValidaMDB(string fullName);
    }
}
