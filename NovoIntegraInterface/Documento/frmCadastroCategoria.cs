using NovaIntegra.Application.Interfaces;
using NovaIntegra.Application.ViewModel;
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
        public List<AA_VinculoViewModel> atributos;
        public frmCadastroCategoria(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            InitializeComponent();
            MontaForm();
        }

        internal void MontaForm()
        {
            var categorias = _docappservice.ListarCategorias();

            categorias.Add(new DCCategoryViewModel(" <Selecione uma categoria>", ""));
            cboCodCategoria.DataSource = categorias.OrderBy(x => x.IDCATEGORY).ToList();
            cboCodCategoria.ValueMember = "IDCATEGORY";
            cboCodCategoria.DisplayMember = "IDCATEGORY";

            var tiposcampo = _docappservice.ListarTiposCampo();
            tiposcampo.Add(new AA_TipoCampoViewModel(0, "<Selecione>"));
            cboTipoAtributo.DataSource = tiposcampo.OrderBy(x => x.Cod_TipoCampo).ToList();
            cboTipoAtributo.ValueMember = "Cod_TipoCampo";
            cboTipoAtributo.DisplayMember = "Descricao";

            if (acesso == ModoAcesso.Inclusao)
            {
                atributos = new List<AA_VinculoViewModel>();
                gpbAtributo.Enabled = false;
            }
        }

        internal void CarregaForm()
        {
            var categ = _docappservice.BuscaCategoria(cod_categoria);
            txtDescCategoria.Text = categ.NMCATEGORY;
            cboCodCategoria.SelectedValue = categ.IDCATEGORY;

            gpbCategoria.Enabled = false;

            atributos = _docappservice.ListarVinculo(cod_categoria);
            dgvAtributos.DataSource = atributos;
            Support.DataGridView_ConfigGrid(dgvAtributos, false);

            Support.DataGridView_ConfigCol(dgvAtributos, "nmAtributo", "Atributo SE", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmCampoImagem", "Campo Imagem", 2, "", 0, DataGridViewAutoSizeColumnMode.Fill);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmTipoCampo", "Tipo do Atributo", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "Ind_Titulo", "Título", 4, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "ind_LocalFisico", "Local Fisico", 5, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);

            if (acesso == ModoAcesso.Consulta)
            {
                gpbAtributo.Enabled = false;
                btnGravar.Enabled = false;
            }
        }

        private void cboCodCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCodCategoria.SelectedIndex > 1)
            {
                var categoria = _docappservice.BuscaCategoria(cboCodCategoria.SelectedValue.ToString());
                txtDescCategoria.Text = categoria.codenome;
                var adatributos = _docappservice.BuscarAtributos(cboCodCategoria.SelectedValue.ToString());
                cboAtribSeSuite.DataSource = adatributos;
                cboAtribSeSuite.ValueMember = "CDattribute";
                cboAtribSeSuite.DisplayMember = "NMATTRIBUTE";

                var vinculo = _docappservice.ListarVinculo(cboCodCategoria.SelectedValue.ToString());
                if (vinculo.Count > 0 && acesso == ModoAcesso.Inclusao)
                {
                    atributos = vinculo;
                    dgvAtributos.DataSource = atributos;
                    gpbAtributo.Enabled = false;
                    tlsVendasPesquisa.Enabled = false;
                }
                else
                {
                    atributos = new List<AA_VinculoViewModel>();
                    dgvAtributos.DataSource = atributos;
                    gpbAtributo.Enabled = true;
                    tlsVendasPesquisa.Enabled = true;
                }
                RefazGrid();

            }
            else
            {
                cboAtribSeSuite.DataSource = null;
                gpbAtributo.Enabled = false;
            }


        }

        private void btnLimparAtributos_Click(object sender, EventArgs e)
        {
            cboAtribSeSuite.SelectedIndex = -1;
            cboTipoAtributo.SelectedIndex = 0;
            txtAtribImagem.Text = "";
            chkTitulo.Checked = false;
            chkLocalFisico.Checked = false;
        }

        private void btnAdicionarVinculo_Click(object sender, EventArgs e)
        {
            if ((int)cboTipoAtributo.SelectedValue == 0)
            {
                MessageBox.Show("Por favor selecione o tipo do campo.");
                return;
            }
            var vinculo = new AA_VinculoViewModel(cboCodCategoria.SelectedValue.ToString(), (decimal)cboAtribSeSuite.SelectedValue,
                txtAtribImagem.Text, chkTitulo.Checked, (int)cboTipoAtributo.SelectedValue, chkLocalFisico.Checked,
                (ADATTRIBUTEViewModel)cboAtribSeSuite.SelectedItem, (AA_TipoCampoViewModel)cboTipoAtributo.SelectedItem);
            atributos.Add(vinculo);
            dgvAtributos.DataSource = atributos.ToList();
            RefazGrid();
            btnLimparAtributos_Click(sender, e);

        }
        private void RefazGrid()
        {

            Support.DataGridView_ConfigGrid(dgvAtributos, false);
            Support.DataGridView_ConfigCol(dgvAtributos, "nmAtributo", "Atributo SE", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmCampoImagem", "Campo Imagem", 2, "", 0, DataGridViewAutoSizeColumnMode.Fill);
            Support.DataGridView_ConfigCol(dgvAtributos, "NmTipoCampo", "Tipo do Atributo", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "Ind_Titulo", "Título", 4, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvAtributos, "ind_LocalFisico", "Local Físico", 5, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (acesso == ModoAcesso.Alteracao)
                {
                    _docappservice.ExcluirVinculos(cboCodCategoria.SelectedValue.ToString());
                }
                foreach (var item in atributos)
                {
                    _docappservice.AdicionaVinculo(item);
                }
                Cursor = Cursors.Default;
                MessageBox.Show("Gravação concluida.");
                this.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retirar = new AA_VinculoViewModel(cboCodCategoria.SelectedValue.ToString(), (decimal)cboAtribSeSuite.SelectedValue,
                txtAtribImagem.Text, chkTitulo.Checked, (int)cboTipoAtributo.SelectedValue, chkLocalFisico.Checked,
                (ADATTRIBUTEViewModel)cboAtribSeSuite.SelectedItem, (AA_TipoCampoViewModel)cboTipoAtributo.SelectedItem);
            var item = atributos.Find(x => x.CDAttribute_SE == retirar.CDAttribute_SE && x.Cod_TipoCampo == retirar.Cod_TipoCampo
                && x.NmCampoImagem == retirar.NmCampoImagem);
            atributos.Remove(item);
            dgvAtributos.DataSource = null;
            dgvAtributos.DataSource = atributos;
            RefazGrid();
            dgvAtributos.SelectAll();
        }

        private void dgvAtributos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAtributos.SelectedRows.Count > 0)
            {
                var categoria = (AA_VinculoViewModel)dgvAtributos.SelectedRows[0].DataBoundItem;
                cboTipoAtributo.SelectedValue = categoria.Cod_TipoCampo;
                cboAtribSeSuite.SelectedValue = categoria.CDAttribute_SE;
                txtAtribImagem.Text = categoria.NmCampoImagem;
                chkTitulo.Checked = categoria.Ind_Titulo;
                chkLocalFisico.Checked = categoria.ind_LocalFisico;
            }

            if (acesso == ModoAcesso.Alteracao)
            {
                btnExcluir.Enabled = true;
            }
        }

        private void cboAtribSeSuite_SelectedValueChanged(object sender, EventArgs e)
        {
            DesativaExcluir();
        }

        private void cboTipoAtributo_SelectedValueChanged(object sender, EventArgs e)
        {
            DesativaExcluir();
        }

        internal void DesativaExcluir()
        {
            if (acesso == ModoAcesso.Alteracao)
            {
                btnExcluir.Enabled = false;
            }
        }

        private void chkTitulo_CheckedChanged(object sender, EventArgs e)
        {
            DesativaExcluir();
        }

        private void txtAtribImagem_TextChanged(object sender, EventArgs e)
        {
            DesativaExcluir();
        }

        private void chkLocalFisico_CheckedChanged(object sender, EventArgs e)
        {
            DesativaExcluir();
        }
    }
}
