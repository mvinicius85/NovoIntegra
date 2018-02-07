using NovoIntegra.Core.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.DTO;
using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Interfaces.Services
{
    public interface IDCCategoryService
    {
        List<DCCATEGORY> BuscaTodos();
        List<DTOgridAtrib> ListarCategorias(DCCATEGORY filtro);
        DCCATEGORY BuscarCategoria(string cod_categoria);
    }
}
