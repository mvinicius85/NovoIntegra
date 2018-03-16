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

        public void AtualizarParametro(AA_Parametros param)
        {
            var oldparam = _parametrosrepository.ObterPorId(param.Cod_Parametro);
            oldparam.Descricao = param.Descricao;
            oldparam.NomeParametro = param.NomeParametro;
            oldparam.Valor = param.Valor;
            _parametrosrepository.Atualizar(oldparam);
        }

        public AA_Parametros CarregaParametro(int cod_parametro)
        {
            return _parametrosrepository.ObterPorId(cod_parametro);
        }

        public void LigarServico()
        {
            var param = _parametrosrepository.Buscar(x => x.NomeParametro == "SERVICEON").FirstOrDefault();
            param.Valor = "1";
            _parametrosrepository.Atualizar(param);
        }

        public void DesligarServico()
        {
            var param = _parametrosrepository.Buscar(x => x.NomeParametro == "SERVICEON").FirstOrDefault();
            param.Valor = "0";
            _parametrosrepository.Atualizar(param);
        }

        public List<AA_Parametros> RetornaParametros(AA_Parametros filtro)
        {
            return _parametrosrepository.Buscar(x => x.NomeParametro.Contains(filtro.NomeParametro) && x.Descricao.Contains(filtro.Descricao) && x.NomeParametro != "SERVICEON").ToList();
        }

        public string RetornaPath(string param)
        {
            return _parametrosrepository.Buscar(x => x.NomeParametro == param).FirstOrDefault().Valor.ToString();
        }

        public bool StatusServico()
        {
            var status = _parametrosrepository.Buscar(x => x.NomeParametro == "SERVICEON").FirstOrDefault();
            if (status.Valor == "0")
            {
                return false;
            }
            return true;
        }

        public bool ServicoUso()
        {
            var status = _parametrosrepository.Buscar(x => x.NomeParametro == "SERVICEON").FirstOrDefault();
            if (status.Valor == "2")
            {
                return true;
            }
            return false;
        }

        public void AtualizarServico(string st)
        {
            var param = _parametrosrepository.Buscar(x => x.NomeParametro == "SERVICEON").FirstOrDefault();
            param.Valor = st;
            _parametrosrepository.Atualizar(param);
        }
    }
}
