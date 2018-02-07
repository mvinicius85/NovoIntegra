using AutoMapper;
using NovaIntegra.Application.ViewModel;
using NovoIntegra.Documento.Domain.DTO;
using NovoIntegra.Documento.Domain.Entities.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<DCCATEGORY, DCCategoryViewModel>();
            CreateMap<AA_Parametros, AA_ParametrosViewModel>();
            CreateMap<DTOgridAtrib, gridCategoriasViewModel>();
            CreateMap<AA_Vinculo, AA_VinculoViewModel>();
            CreateMap<AA_TipoCampo, AA_TipoCampoViewModel>();
        }
    }
}
