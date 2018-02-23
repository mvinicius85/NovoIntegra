using NovoIntegra.Core.Domain.Util;
using NovoIntegra.Documento.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoIntegraInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static SimpleInjector.Container container;


        public static SimpleInjector.Container Container
        {
            get { return RetornarContainer(); }

        }

        private static SimpleInjector.Container RetornarContainer()
        {
            return container;
        }
        [STAThread]
        static void Main()
        {
            Start();
            container.GetInstance<SeSuiteContext>().ChangeConnection(StringCipher.Decrypt(ConfigurationManager.AppSettings["conn"],"0m3o"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.GetInstance<MDIPrincipal>());
        }

        private static void Start()
        {
            //Inicia a injeção de dependencia
            container = new SimpleInjector.Container();
            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            NovoIntegra.Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);


        }
    }
}
