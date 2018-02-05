using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Services
{
    public class ParametrosService : IParametrosService
    {
        private readonly IParametrosRepository _parametrosrepository;

        public ParametrosService(IParametrosRepository parametrosrepository)
        {
            _parametrosrepository = parametrosrepository;
        }

        public AA_Parametros CarregaParametro(int cod_parametro)
        {
            return _parametrosrepository.ObterPorId(cod_parametro);
        }

        public List<AA_Parametros> RetornaParametros(AA_Parametros filtro)
        {
            return _parametrosrepository.Buscar(x => x.NomeParametro.Contains(filtro.NomeParametro) && x.Descricao.Contains(filtro.Descricao)).ToList();
        }

        public string RetornaPath(string param)
        {
            return _parametrosrepository.Buscar(x => x.NomeParametro == param).FirstOrDefault().Valor.ToString();
        }
    }
}
