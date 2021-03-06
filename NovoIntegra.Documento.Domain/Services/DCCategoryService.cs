﻿using NovoIntegra.Documento.Domain.DTO;
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
    public class DCCategoryService : IDCCategoryService
    {
        private readonly IDCCategoryRepository _dccategoryrepository;
        public DCCategoryService(IDCCategoryRepository dccategoryrepository)
        {
            _dccategoryrepository = dccategoryrepository;
        }

        public DCCATEGORY BuscarCategoria(string cod_categoria)
        {
            return _dccategoryrepository.Buscar(x => x.IDCATEGORY == cod_categoria).FirstOrDefault();
        }

        public List<DCCATEGORY> BuscaTodos()
        {
            return _dccategoryrepository.ObterTodos().ToList();
        }

        public List<DTOgridAtrib> ListarCategorias(DCCATEGORY filtro)
        {
            return _dccategoryrepository.ListarCategorias(filtro);
        }
    }
}
