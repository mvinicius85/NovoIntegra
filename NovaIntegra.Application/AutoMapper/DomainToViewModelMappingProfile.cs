using AutoMapper;
using NovaIntegra.Application.ViewModel;
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
        }
    }
}
