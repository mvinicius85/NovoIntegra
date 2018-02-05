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
    }
}
