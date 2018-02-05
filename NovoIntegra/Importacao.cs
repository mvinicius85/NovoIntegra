using NovaIntegra.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra
{
    public class Importacao
    {
        private readonly SimpleInjector.Container container;
        private readonly IDocumentoAppService _docappservice;

        public Importacao(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            container = ServicoIntegracao.Container;
        }
        public string TesteImportacao()
        {
            //var y = container.GetInstance<IDocumentoAppService>();
            var x = _docappservice.BuscarTodas();
            return x[1].IDCATEGORY;
        }

        public void Importar()
        {
            // var doc = container.GetInstance<IDocumentoAppService>();

            var pathimport = _docappservice.RetornaDiretorio("PATHIMPORT");  
            var pathsucess = _docappservice.RetornaDiretorio("PATHSUCCESS");
            var patherr = _docappservice.RetornaDiretorio("PATHERR");

            var dirimp = new DirectoryInfo(pathimport);

            var listfiles = dirimp.GetFiles("*.mdb", SearchOption.AllDirectories);
            foreach (var item in listfiles)
            {
                if (_docappservice.InsereDocumento(item.FullName, item.DirectoryName, item.Name))
                {
                    Directory.Move(item.DirectoryName, Path.Combine(pathsucess, item.Name.Substring(0, item.Name.Length - 4)));
                }
                else
                {
                    Directory.Move(item.DirectoryName, Path.Combine(patherr, item.Name.Substring(0, item.Name.Length - 4)));
                }

            }
        }


    }
}
