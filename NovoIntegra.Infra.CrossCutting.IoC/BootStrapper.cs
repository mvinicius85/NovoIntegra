using AutoMapper;
using NovaIntegra.Application.Interfaces;
using NovoIntegra.Core.Domain.Interfaces.Services;
using NovoIntegra.Core.Domain.Services;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using NovoIntegra.Documento.Domain.Services;
using NovoIntegra.Documento.Infra.Data.Contexto;
using NovoIntegra.Documento.Infra.Data.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Lifestyles;

namespace NovoIntegra.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            AsyncScopedLifestyle.BeginScope(container);

            // App 
            #region Apps
            container.Register<IDocumentoAppService, NovaIntegra.Application.AppForm.DocumentoAppService>(Lifestyle.Scoped);
            #endregion


            #region Services
            container.Register<IDCCategoryService, DCCategoryService>(Lifestyle.Scoped);
            container.Register<IMdbFileService, MdbFileService>(Lifestyle.Scoped);
            container.Register<IVinculoService, VinculoService>(Lifestyle.Scoped);
            container.Register<IDCDocumentService, DCDocumentService>(Lifestyle.Scoped);
            container.Register<IGNAssocService, GNAssocService>(Lifestyle.Scoped);
            container.Register<IGNRevisionService, GNRevisionService>(Lifestyle.Scoped);
            container.Register<IGNCompFileContCopyService, GNCompFileContCopyService>(Lifestyle.Scoped);
            container.Register<ILogService, LogService>(Lifestyle.Scoped);
            container.Register<IParametrosService, ParametrosService>(Lifestyle.Scoped);

            #endregion

            #region Repository
            container.Register<IDCCategoryRepository, DCCategoryRepository>(Lifestyle.Scoped);
            container.Register<IVinculoRepository, VinculoRepository>(Lifestyle.Scoped);
            container.Register<IDCDocumentRepository, DCDocumentRepository>(Lifestyle.Scoped);
            container.Register<IGNAssocRepository, GNAssocRepository>(Lifestyle.Scoped);
            container.Register<IGNRevisionRepository, GNRevisionRepository>(Lifestyle.Scoped);
            container.Register<IGNCompFileContCopyRepository, GNCompFileContCopyRepository>(Lifestyle.Scoped);
            container.Register<IDCDocRevisionRepository, DCDocRevisionRepository>(Lifestyle.Scoped);
            container.Register<IDCFileRepository, DCFileRepository>(Lifestyle.Scoped);
            container.Register<ITipoCampoRepository, TipoCampoRepository>(Lifestyle.Scoped);
            container.Register<IDCDocumentAttribRepository, DCDocumentAttribRepository>(Lifestyle.Scoped);
            container.Register<IADInterfaceRepository, ADInterfaceRepository>(Lifestyle.Scoped);
            container.Register<ILogRepository, LogRepository>(Lifestyle.Scoped);
            container.Register<IDcDocumentArchivalRepository, DcDocumentArchivalRepository>(Lifestyle.Scoped);
            container.Register<IParametrosRepository, ParametrosRepository>(Lifestyle.Scoped);
            #endregion

            container.RegisterSingleton(Mapper.Configuration);
            container.Register<IMapper>(() => Mapper.Configuration.CreateMapper(container.GetInstance));

            container.Register<NovoIntegra.Documento.Infra.Data.Interfaces.IUnitOfWork, NovoIntegra.Documento.Infra.Data.UoW.UnitOfWork>(Lifestyle.Scoped);
            container.Register<SeSuiteContext>(Lifestyle.Singleton);
        }
    }
}
