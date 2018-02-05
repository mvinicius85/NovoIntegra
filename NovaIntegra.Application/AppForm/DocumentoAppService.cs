using AutoMapper;
using NovaIntegra.Application.Interfaces;
using NovaIntegra.Application.ViewModel;
using NovoIntegra.Core.Domain.Interfaces.Services;
using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.AppForm
{
    public class DocumentoAppService : ApplicationService, IDocumentoAppService
    {
        private readonly IDCCategoryService _dccategoryservice;
        private readonly IVinculoService _vinculoservice;
        private readonly IMdbFileService _mdbservice;
        private readonly IDCDocumentService _dcdocumentservice;
        private readonly IGNAssocService _gnassocservice;
        private readonly IGNRevisionService _gnrevisionservice;
        private readonly IGNCompFileContCopyService _gncompservice;
        private readonly ILogService _logservice;
        private readonly IParametrosService _parametrosserivce;

        string msg;
        string lote;
        string documento;
        int cddocumentini;
        int cdassocini;
        int cdrevisionini;
        int cdcompini;

        DataTable arquivomdb = new DataTable();
        public DocumentoAppService(IDCCategoryService dccategoryservice, IMdbFileService mdbservice,
            IVinculoService vinculoservice, IDCDocumentService dcdocumentservice, IGNAssocService gnassocservice,
            IGNRevisionService gnrevisionservice, IGNCompFileContCopyService gncompservice,
            ILogService logervice, IParametrosService parametrosserivce,
            NovoIntegra.Documento.Infra.Data.Interfaces.IUnitOfWork uow) : base(uow)
        {
            _dccategoryservice = dccategoryservice;
            _vinculoservice = vinculoservice;
            _mdbservice = mdbservice;
            _dcdocumentservice = dcdocumentservice;
            _gnassocservice = gnassocservice;
            _gnrevisionservice = gnrevisionservice;
            _gncompservice = gncompservice;
            _logservice = logervice;
            _parametrosserivce = parametrosserivce;
        }
        public List<DCCategoryViewModel> BuscarTodas()
        {
            return Mapper.Map<List<DCCategoryViewModel>>(_dccategoryservice.BuscaTodos());
        }
        public DataTable AbreArquivo(string path)
        {
            var dt = _mdbservice.RetornaArquivo(path);
            return dt;
        }
        public bool InsereDocumento(string pathfile, string path, string file)
        {
            try
            {

                var cddocument = _dcdocumentservice.RetornaMax();
                var cdassoc = _gnassocservice.RetornaMax();
                var cdrevision = _gnrevisionservice.RetornaMax();
                var cdcomp = _gncompservice.RetornaMax();

                cddocumentini = cddocument;
                cdassocini = cdassoc;
                cdrevisionini = cdrevision;
                cdcompini = cdcomp;
                lote = file;

                msg = "Erro ao abrir o arquivo";
                arquivomdb = this.AbreArquivo(pathfile);

                foreach (DataRow item in arquivomdb.Rows)
                {
                    BeginDocumentoTransaction();
                    cddocument = cddocument + 1;
                    cdassoc = cdassoc + 1;
                    cdrevision = cdrevision + 1;
                    cdcomp = cdcomp + 1;

                    msg = "Não foi encontrada a coluna com a categoria do documento";
                    var idcateg = item["IDCATEGORY"].ToString();

                    msg = "Categoria informada não identificada no SE Suite";
                    var atrib = _vinculoservice.RetornaAtributos(idcateg);

                    msg = "Erro ao inserir documento";
                    _dcdocumentservice.InsereDocumento(item, atrib, cddocument, cdassoc, cdrevision, cdcomp);
                    if (CommitDocumento() > 0)
                    {
                        msg = "Erro ao inserir atributos";
                        BeginDocumentoTransaction();
                        _dcdocumentservice.InsereRevision(item, atrib, cddocument, cdassoc, cdrevision, cdcomp, path);
                        if (CommitDocumento() > 0)
                        {
                            msg = "Erro ao inserir imagem";
                            BeginDocumentoTransaction();
                            _dcdocumentservice.InsereImagem(path, item, cddocument, atrib);
                            CommitDocumento();
                        }
                       
                    } 

                }
                arquivomdb.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                arquivomdb.Dispose();
                DisposeAdd();
                DisposeContexto();
                BeginDocumentoTransaction();
                _dcdocumentservice.ExcluirArquivo(cddocumentini, cdrevisionini, cdassocini, cdcompini);
                CommitDocumento();
                var log = new AA_Log(lote, "", "", msg, ex.GetBaseException().Message.ToString(), DateTime.Now, true);
                BeginDocumentoTransaction();
                _logservice.Adicionar(log);
                CommitDocumento();
                return false;
            }

        }

        public string RetornaDiretorio(string param)
        {
            try
            {
                return _parametrosserivce.RetornaPath(param);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
       
    }
}
