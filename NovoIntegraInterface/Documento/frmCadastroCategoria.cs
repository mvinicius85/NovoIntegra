using NovaIntegra.Application.Interfaces;
using NovoIntegraInterface.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoIntegraInterface.Documento
{
    public partial class frmCadastroCategoria : Form
    {
        public string cod_categoria;
        public ModoAcesso acesso;
        private readonly IDocumentoAppService _docappservice;
        public frmCadastroCategoria(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            InitializeComponent();
            MontaForm();
        }

        internal void MontaForm()
        {
            var categorias = _docappservice.ListarCategorias();
            cboCodCategoria.DataSource = categorias;
            cboCodCategoria.ValueMember = "IDCATEGORY";
            cboCodCategoria.DisplayMember = "IDCATEGORY";
        }

        internal void CarregaForm()
        {
            var categ = _docappservice.BuscaCategoria(cod_categoria);
            txtDescCategoria.Text = categ.NMCATEGORY;
            cboCodCategoria.SelectedValue = categ.IDCATEGORY;

            gpbCategoria.Enabled = false;

            var atributos = _docappservice.ListarVinculo(cod_categoria);
            dgvAtributos.DataSource = atributos;
            Support.DataGridView_ConfigGrid(dgvAtributos, false);

            Support.DataGridView_ConfigCol(dgvAtributos, "nmAtributo", "Atributo SE", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmCampoImagem", "Campo Imagem", 2, "", 0, DataGridViewAutoSizeColumnMode.Fill);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmTipoCampo", "Tipo do Atributo", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "Ind_Titulo", "Título", 4, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);

            if (acesso == ModoAcesso.Consulta)
            {
                gpbAtributo.Enabled = false;
                btnGravar.Enabled = false;  
            }
        }
    }
}
