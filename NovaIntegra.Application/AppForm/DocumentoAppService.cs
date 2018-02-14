using AutoMapper;
using NovaIntegra.Application.Interfaces;
using NovaIntegra.Application.ViewModel;
using NovoIntegra.Core.Domain.Interfaces.Services;
using NovoIntegra.Documento.Domain.DTO;
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
        private readonly ITipoCampoService _tipocamposervice;
        private readonly IADAttributeService _adattributeservice;

        string msg;
        string lote;
        string documento;
        string idcateg;
        int cddocumentini;
        int cdassocini;
        int cdrevisionini;
        int cdcompini;

        DataTable arquivomdb = new DataTable();
        public DocumentoAppService(IDCCategoryService dccategoryservice, IMdbFileService mdbservice,
            IVinculoService vinculoservice, IDCDocumentService dcdocumentservice, IGNAssocService gnassocservice,
            IGNRevisionService gnrevisionservice, IGNCompFileContCopyService gncompservice,
            ILogService logervice, IParametrosService parametrosserivce, ITipoCampoService tipocamposervice,
            IADAttributeService adattributeservice, 
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
            _tipocamposervice = tipocamposervice;
            _adattributeservice = adattributeservice;
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
                msg = "";
                lote = "";
                documento = "";
                idcateg = "";

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
                    idcateg = item["IDCATEGORY"].ToString();

                    msg = "O documento não foi identificado.";
                    documento = item["IMAGEM"].ToString();

                    msg = "Categoria informada não identificada no SE Suite";
                    var atrib = _vinculoservice.RetornaAtributos(idcateg);
                    if (atrib.Count.Equals(0))
                    {
                        throw new Exception();
                    }

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

                            msg = "Erro ao inserir log";
                            var log = new AA_Log(lote, documento, idcateg, "Documento inserido com sucesso.", "", DateTime.Now, false);
                            BeginDocumentoTransaction();
                            _logservice.Adicionar(log);
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
                var log = new AA_Log(lote,documento, idcateg, msg, ex.GetBaseException().Message.ToString(), DateTime.Now, true);
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

        public List<AA_ParametrosViewModel> ListarParametros(AA_ParametrosViewModel filtro)
        {
            return Mapper.Map<List<AA_ParametrosViewModel>>(_parametrosserivce.RetornaParametros(Mapper.Map<AA_Parametros>(filtro)));
        }

        public AA_ParametrosViewModel CarregarParametro(int cod_parametro)
        {
            return Mapper.Map<AA_ParametrosViewModel>(_parametrosserivce.CarregaParametro(cod_parametro));
        }

        public List<gridCategoriasViewModel> ListarCategorias(DCCategoryViewModel filtro)
        {
            return Mapper.Map<List<gridCategoriasViewModel>>(_dccategoryservice.ListarCategorias(Mapper.Map<DCCATEGORY>(filtro)));
        }

        public DCCategoryViewModel BuscaCategoria(string cod_categoria)
        {
            return Mapper.Map<DCCategoryViewModel>(_dccategoryservice.BuscarCategoria(cod_categoria));
        }

        public List<AA_VinculoViewModel> ListarVinculo(string cod_categoria)
        {
            return Mapper.Map<List<AA_VinculoViewModel>>(_vinculoservice.RetornaAtributos(cod_categoria));
        }

        public List<DCCategoryViewModel> ListarCategorias()
        {
            return Mapper.Map<List<DCCategoryViewModel>>(_dccategoryservice.BuscaTodos());
        }

        public List<AA_TipoCampoViewModel> ListarTiposCampo()
        {
            return Mapper.Map<List<AA_TipoCampoViewModel>>(_tipocamposervice.ListarTiposCampo());
        }

        public List<ADATTRIBUTEViewModel> BuscarAtributos(string codcategoria)
        {
            return Mapper.Map<List<ADATTRIBUTEViewModel>>(_adattributeservice.ListaAtributos(codcategoria));
        }

        public void AdicionaVinculo(AA_VinculoViewModel item)
        {
            BeginDocumentoTransaction();
            item.AA_TipoCampo = null;
            item.ADATTRIBUTE = null;
            _vinculoservice.AdicionaVinculo(Mapper.Map<AA_Vinculo>(item));
            CommitDocumento();
        }

        public List<AA_LogViewModel> BuscarLog(FiltroLogViewModel filtro)
        {
            return Mapper.Map<List<AA_LogViewModel>>(_logservice.ListarLog(Mapper.Map<DTOFiltroLog>(filtro)));
        }

        public void ExcluirVinculos(string codcategoria)
        {
            BeginDocumentoTransaction();
            _vinculoservice.ExcluiVinculos(codcategoria);
            CommitDocumento();
        }

        public void AtualizaParametro(AA_ParametrosViewModel param)
        {
            BeginDocumentoTransaction();
            _parametrosserivce.AtualizarParametro(Mapper.Map<AA_Parametros>(param));
            CommitDocumento();
        }

        public bool StatusServico()
        {
            return _parametrosserivce.StatusServico();
        }

        public void LigarServico()
        {
            BeginDocumentoTransaction();
            _parametrosserivce.LigarServico();
            CommitDocumento();
            DisposeContexto();
        }

        public void DesligarServico()
        {
            BeginDocumentoTransaction();
            _parametrosserivce.DesligarServico();
            CommitDocumento();
            DisposeContexto();
        }
    }
}
