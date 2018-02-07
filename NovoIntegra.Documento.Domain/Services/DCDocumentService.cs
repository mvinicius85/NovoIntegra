using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Services
{
    public class DCDocumentService : IDCDocumentService
    {
        private readonly IDCDocumentRepository _dcdocumentrepository;
        private readonly IGNAssocService _gnassocservice;
        private readonly IGNRevisionService _gnrevisionservice;
        private readonly IGNCompFileContCopyRepository _gncomprepository;
        private readonly IDCDocRevisionRepository _dcdocrevrepository;
        private readonly IDCCategoryRepository _dccategoryrepository;
        private readonly IDCFileRepository _dcfilerepository;
        private readonly IVinculoRepository _vinculorepository;
        private readonly ITipoCampoRepository _tipocamporepository;
        private readonly IDCDocumentAttribRepository _dcdocattribrepository;
        private readonly IADInterfaceRepository _adinterfacerepository;
        private readonly IDcDocumentArchivalRepository _dcarchivalrepository;

        public DCDocumentService(IDCDocumentRepository dcdocumentrepository, IGNAssocService gnassocservice,
            IGNRevisionService gnrevisionservice, IGNCompFileContCopyRepository gncomprepository,
            IDCDocRevisionRepository dcdocrevrepository, IDCCategoryRepository dccategoryrepository,
            IDCFileRepository dcfilerepository, IVinculoRepository vinculorepository,
            ITipoCampoRepository tipocamporepository, IDCDocumentAttribRepository dcdocattribrepository,
            IADInterfaceRepository adinterfacerepository, IDcDocumentArchivalRepository dcarchivalrepository)
        {
            _dcdocumentrepository = dcdocumentrepository;
            _gnassocservice = gnassocservice;
            _gnrevisionservice = gnrevisionservice;
            _gncomprepository = gncomprepository;
            _dcdocrevrepository = dcdocrevrepository;
            _dccategoryrepository = dccategoryrepository;
            _dcfilerepository = dcfilerepository;
            _vinculorepository = vinculorepository;
            _tipocamporepository = tipocamporepository;
            _dcdocattribrepository = dcdocattribrepository;
            _adinterfacerepository = adinterfacerepository;
            _dcarchivalrepository = dcarchivalrepository;
        }

        public void ExcluirArquivo(int cddocument, int cdrevision, int gnassoc, int cdcomp)
        {
            var file = _dcfilerepository.ExcluiRegistros(cddocument);
            var rev = _dcdocrevrepository.ExcluiRegistros(cddocument);
            var attrib = _dcdocattribrepository.ExcluiRegistros(cddocument);
            var docarc = _dcarchivalrepository.ExcluiRegistros(cddocument);
            var doc = _dcdocumentrepository.ExcluiDocumentos(cddocument);
            var gnrev = _gnrevisionservice.ExcluiRegistros(cdrevision);
            var gncomp = _gncomprepository.ExcluiRegistros(cdcomp);
            var gnassc = _gnassocservice.ExcluiRegistros(gnassoc);
        }

        public void InsereDocumento(DataRow linha, List<AA_Vinculo> atributos, int cddocument, int cdassoc, int cdrevision, int cdcomp)
        {
            var dcdoc = new DCDOCUMENT(cddocument, 2, 1, 1);
            _dcdocumentrepository.Adicionar(dcdoc);


            var gnass = new GNASSOC(cdassoc, 99200024);
            _gnassocservice.Adiciona(gnass);

            var gnrev = new GNREVISION(cdrevision, "00", DateTime.Now, 6, DateTime.Now, 1, 21, DateTime.Now, "sesuite", cdassoc);
            _gnrevisionservice.Adiciona(gnrev);

            var gncomp = new GNCOMPFILECONTCOPY(cdcomp, 2, 21);
            _gncomprepository.Adicionar(gncomp);


        }

        public void InsereImagem(string path, DataRow linha, int cddocument,  List<AA_Vinculo> atributos)
        {
            var idcateg = atributos.FirstOrDefault().IDCategory;
            var cdcategory = _dccategoryrepository.Buscar(x => x.IDCATEGORY == idcateg).FirstOrDefault().CDCATEGORY;
            var cdinterface = _adinterfacerepository.RetornaMax();
            var arquivo = new ADINTERFACE(cdinterface + 1, 1, 73, 97, idcateg + cddocument.ToString(), "00", linha["IMAGEM"].ToString(), path + linha["IMAGEM"].ToString(), "0", idcateg);
            _adinterfacerepository.Adicionar(arquivo);
        }

        public void InsereRevision(DataRow linha, List<AA_Vinculo> atributos, int cddocument, int cdassoc, int cdrevision, int cdcomp, string path)
        {
            var idcateg = atributos.FirstOrDefault().IDCategory;
            var atribtitulo = atributos.FirstOrDefault(x => x.Ind_Titulo).NmCampoImagem.ToString();
            var titulo = linha[atribtitulo].ToString();
            var cdcategory = _dccategoryrepository.Buscar(x => x.IDCATEGORY == idcateg).FirstOrDefault().CDCATEGORY;

            var dcdocrev = new DCDOCREVISION(cddocument, cdrevision, 1, titulo, "sesuite", idcateg + cddocument.ToString(),
                cdcategory, 0, DateTime.Now, DateTime.Now, "sesuite");
            _dcdocrevrepository.Adicionar(dcdocrev);

            var dcfl = new DCFILE(cdcomp, cddocument, cdrevision);
            _dcfilerepository.Adicionar(dcfl);

            foreach (var atrib in atributos)
            {
                var tpatrib = _tipocamporepository.ObterPorId(atrib.Cod_TipoCampo).Descricao;
                switch (tpatrib.ToUpper())
                {
                    case "TEXTO":
                        var dcdocatrib1 = new DCDOCUMENTATTRIB(tpatrib, cddocument, (decimal)atrib.CDAttribute_SE, linha[atrib.NmCampoImagem].ToString(), 0, DateTime.Now, "", 1, 0, DateTime.Now, "sesuite", cdrevision, 2);
                        _dcdocattribrepository.Adicionar(dcdocatrib1);
                        break;
                    case "DECIMAL":
                        var dcdocatrib2 = new DCDOCUMENTATTRIB(tpatrib, cddocument, (decimal)atrib.CDAttribute_SE, "", Convert.ToDecimal(linha[atrib.NmCampoImagem]), DateTime.Now, "", 1, 0, DateTime.Now, "sesuite", cdrevision, 2);
                        _dcdocattribrepository.Adicionar(dcdocatrib2);
                        break;
                    case "INTEIRO":
                        var dcdocatrib3 = new DCDOCUMENTATTRIB(tpatrib, cddocument, (decimal)atrib.CDAttribute_SE, "", Convert.ToInt32(linha[atrib.NmCampoImagem]), DateTime.Now, "", 1, 0, DateTime.Now, "sesuite", cdrevision, 2);
                        _dcdocattribrepository.Adicionar(dcdocatrib3);
                        break;
                    case "DATA":
                        var dcdocatrib4 = new DCDOCUMENTATTRIB(tpatrib, cddocument, (decimal)atrib.CDAttribute_SE, "", 0, Convert.ToDateTime(linha[atrib.NmCampoImagem]), "", 1, 0, DateTime.Now, "sesuite", cdrevision, 2);
                        _dcdocattribrepository.Adicionar(dcdocatrib4);
                        break;
                    case "MEMORANDO":
                        var dcdocatrib5 = new DCDOCUMENTATTRIB(tpatrib, cddocument, (decimal)atrib.CDAttribute_SE, "", 0, Convert.ToDateTime(linha[atrib.NmCampoImagem]), "", 1, 0, DateTime.Now, "sesuite", cdrevision, 2);
                        _dcdocattribrepository.Adicionar(dcdocatrib5);
                        break;
                }

            }

        }



        public int RetornaMax()
        {
            return _dcdocumentrepository.RetornaMax();
        }
    }
}
