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
    public class LogService : ILogService
    {
        private readonly ILogRepository _logrepository;
        public LogService(ILogRepository logrepository)
        {
            _logrepository = logrepository;
        }
        public void Adicionar(AA_Log log)
        {
            _logrepository.Adicionar(log);
        }
    }
}
