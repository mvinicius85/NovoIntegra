using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NovoIntegra
{

    public partial class ServicoIntegracao : ServiceBase
    {
        private Timer timer1 = null;
        private static SimpleInjector.Container container;
        public ServicoIntegracao()
        {
            InitializeComponent();
        }

        public static SimpleInjector.Container Container
        {
            get { return RetornarContainer(); }

        }

        private static SimpleInjector.Container RetornarContainer()
        {
            return container;
        }

        protected override void OnStart(string[] args)
        {
            NovoIntegra.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
            container = new SimpleInjector.Container();
            Infra.CrossCutting.IoC.BootStrapper.RegisterServices(container);
            timer1 = new Timer();
            this.timer1.Interval = 120000;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            Library.WriterLogError("Teste windows service");
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            var teste = container.GetInstance<Importacao>();
            string x = teste.TesteImportacao();
            
            Library.WriterLogError("teste ticking" + x);
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriterLogError("teste service stop");
        }
    }
}
