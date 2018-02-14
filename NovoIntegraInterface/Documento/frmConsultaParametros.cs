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
    public partial class frmConsultaParametros : Form
    {
        private readonly IDocumentoAppService _docappservice;
        public frmConsultaParametros(IDocumentoAppService docappservice)
        {
            InitializeComponent();
            _docappservice = docappservice;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = new AA_ParametrosViewModel(txtNome.Text, txtDescricao.Text);
            var param = _docappservice.ListarParametros(filtro);
            dgvFiltro.DataSource = param.OrderBy(x => x.Cod_Parametro).ToList();

            Support.DataGridView_ConfigGrid(dgvFiltro, false);
            Support.DataGridView_ConfigCol(dgvFiltro, "NomeParametro", "Nome", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvFiltro, "Descricao", "Descricao", 2, "", 0, DataGridViewAutoSizeColumnMode.Fill);
            Support.DataGridView_ConfigCol(dgvFiltro, "Valor", "Valor", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void dgvFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var frmcadastro = Program.Container.GetInstance<frmCadastroParametros>();
                if (dgvFiltro.SelectedRows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    frmcadastro.MdiParent = this.MdiParent;
                    var conta = (AA_ParametrosViewModel)dgvFiltro.SelectedRows[0].DataBoundItem;
                    frmcadastro.cod_parametro = conta.Cod_Parametro;
                    frmcadastro.Load += (s, args) => frmcadastro.CarregaForm(ModoAcesso.Consulta);
                    frmcadastro.Show();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                var frmcadastro = Program.Container.GetInstance<frmCadastroParametros>();
                if (dgvFiltro.SelectedRows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    frmcadastro.MdiParent = this.MdiParent;
                    var conta = (AA_ParametrosViewModel)dgvFiltro.SelectedRows[0].DataBoundItem;
                    frmcadastro.cod_parametro = conta.Cod_Parametro;
                    frmcadastro.Load += (s, args) => frmcadastro.CarregaForm(ModoAcesso.Alteracao);
                    frmcadastro.FormClosed += (s, args) => this.btnPesquisar_Click(sender, e);
                    frmcadastro.Show();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
    }
  
}
