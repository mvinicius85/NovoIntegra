﻿using NovoIntegra.Core.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Repository
{
    public interface IGNAssocRepository : IRepository<GNASSOC>
    {
        int RetornaMax();
        int ExcluiRegistros(int cdassoc);
    }
}
