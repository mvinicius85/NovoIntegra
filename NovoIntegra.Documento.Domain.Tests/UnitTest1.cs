using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NovoIntegra.Documento.Domain.Interfaces.Services;

namespace NovoIntegra.Documento.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var container = new SimpleInjector.Container();
            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            NovoIntegra.Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);
            var teste = container.GetInstance<IDCCategoryService>();
            var teste2 = teste.BuscaTodos();
        }
    }
}
