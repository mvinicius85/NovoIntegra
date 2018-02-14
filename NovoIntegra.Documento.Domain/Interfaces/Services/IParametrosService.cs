using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IParametrosService
    {
        string RetornaPath(string param);
        List<AA_Parametros> RetornaParametros(AA_Parametros filtro);
        AA_Parametros CarregaParametro(int cod_parametro);
        void AtualizarParametro(AA_Parametros param);
        bool StatusServico();
        void LigarServico();
        void DesligarServico();
    }
}
