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
        public string RetornaPath(string param)
        {
            return _parametrosrepository.Buscar(x => x.NomeParametro == param).FirstOrDefault().Valor.ToString();
        }
    }
}
