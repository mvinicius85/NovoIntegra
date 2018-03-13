using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Core.Domain.Interfaces.Services
{
    public interface IMdbFileService
    {
        DataTable RetornaArquivo(string path);
        void AlterarArquivo(string fullName);
        void UpdateArquivo(string fullName, string v);
    }
}
