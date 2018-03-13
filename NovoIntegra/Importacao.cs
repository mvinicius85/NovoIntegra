using NovaIntegra.Application.Interfaces;
using NovoIntegra.Core.Domain.Util;
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
        string text = "0";
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
            try
            {
                var pathimport = _docappservice.RetornaDiretorio("PATHIMPORT");
                var pathsucess = _docappservice.RetornaDiretorio("PATHSUCCESS");
                var patherr = _docappservice.RetornaDiretorio("PATHERR");

                var dirimp = new DirectoryInfo(pathimport);
                var dirsuc = new DirectoryInfo(pathsucess);
                var direrr = new DirectoryInfo(patherr);
                if (!dirimp.Exists)
                {
                    Library.WriterLogError("Diretório de importação dos documentos não encontrado.");
                    return;
                }
                if (!dirsuc.Exists)
                {
                    Library.WriterLogError("Diretório de documentos com sucesso não encontrado.");
                    return;
                }
                if (!direrr.Exists)
                {
                    Library.WriterLogError("Diretório de lotes com erro não encontrado.");
                    return;
                }
                var listfiles = dirimp.GetFiles("*.mdb", SearchOption.AllDirectories);
                foreach (var item in listfiles)
                {
                    if (_docappservice.StatusServico())
                    {
                        Library.WriterLogEntry("Importação iniciada");
                        if (_docappservice.ValidarArquivo(item.FullName, item.DirectoryName, item.Name))
                        {
                            if (_docappservice.InsereDocumento(item.FullName, item.DirectoryName, item.Name))
                            {
                                //Directory.Move(item.DirectoryName, Path.Combine(pathsucess, item.Name.Substring(0, item.Name.Length - 4)));
                                item.MoveTo(Path.Combine(pathsucess, item.Name));
                            }
                            else
                            {
                                //Directory.Move(item.DirectoryName, Path.Combine(patherr, item.Name.Substring(0, item.Name.Length - 4)));
                                item.MoveTo(Path.Combine(patherr, item.Name));
                            }
                        }
                        else
                        {
                            //Directory.Move(item.DirectoryName, Path.Combine(patherr, item.Name.Substring(0, item.Name.Length - 4)));
                            item.MoveTo(Path.Combine(patherr, item.Name));
                        }
                    }
                    else
                    {
                        Library.WriterLogEntry("Serviço desligado para importação.");
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                Library.WriterLogError(ex + " " + text);
            }
        }


    }
}
