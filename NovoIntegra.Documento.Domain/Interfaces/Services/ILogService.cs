﻿using NovoIntegra.Documento.Domain.DTO;
using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface ILogService
    {
        void Adicionar(AA_Log log);
        List<AA_Log> ListarLog(DTOFiltroLog filtro);
        void Adicionar(List<AA_Log> listlog);
    }
}
