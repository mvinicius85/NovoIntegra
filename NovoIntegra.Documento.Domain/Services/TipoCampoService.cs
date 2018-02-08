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
    public class TipoCampoService : ITipoCampoService
    {
        private readonly ITipoCampoRepository _tipocamporepository;

        public TipoCampoService(ITipoCampoRepository tipocamporepository)
        {
            _tipocamporepository = tipocamporepository;
        }
        public List<AA_TipoCampo> ListarTiposCampo()
        {
            return _tipocamporepository.ObterTodos().ToList();
        }
    }
}
