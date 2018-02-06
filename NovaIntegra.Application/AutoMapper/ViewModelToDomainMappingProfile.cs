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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DCCategoryViewModel, DCCATEGORY>();
            CreateMap<AA_ParametrosViewModel, AA_Parametros>();
            CreateMap<gridCategoriasViewModel, DTOgridAtrib>();
        }
    }
}
