using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NovaIntegra.Application.Interfaces;

namespace NovoIntegra.Application.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            var container = new SimpleInjector.Container();
            Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);
            var teste = container.GetInstance<IDocumentoAppService>();
            var teste2 = teste.BuscarTodas();
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = "C:\\teste\\LOTE 148 a 149\\C001_2149\\C001_2149.mdb";
            string pathfile = @"C:\teste\LOTE 148 a 149\C001_2149\";
            string connectionName = "Provider=Microsoft.Jet.OLEDB.4.0;"
              + "Data Source= " + path + " ;";

            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            var container = new SimpleInjector.Container();
            Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);
            var teste = container.GetInstance<IDocumentoAppService>();
            var teste2 = teste.AbreArquivo(connectionName);

            foreach (DataRow item in teste2.Rows)
            {
                //Process.Start(pathfile + teste2.Rows[4].ItemArray[4].ToString());
                var X = item["clie_codigo"].ToString();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            string pathfile = "C:\\teste\\LOTE 148 a 149\\C001_2149\\";
            string file = "C001_2149.mdb";
            string connectionName = "Provider=Microsoft.Jet.OLEDB.4.0;"
                    + "Data Source= " + pathfile + file + " ;";


            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            var container = new SimpleInjector.Container();
            Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);
            var teste = container.GetInstance<IDocumentoAppService>();
            teste.InsereDocumento(connectionName,pathfile, file);
        }
    }
}
