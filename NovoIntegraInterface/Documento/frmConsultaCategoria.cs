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
    public partial class frmConsultaCategoria : Form
    {
        private readonly IDocumentoAppService _docappservice;
        public frmConsultaCategoria(IDocumentoAppService docappservice)
        {
            InitializeComponent();
            _docappservice = docappservice;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = new DCCategoryViewModel(txtCodCategoria.Text, txtDescCategoria.Text);
            var param = _docappservice.ListarCategorias(filtro);
            dgvFiltro.DataSource = param;

            Support.DataGridView_ConfigGrid(dgvFiltro, false);
            Support.DataGridView_ConfigCol(dgvFiltro, "IDCATEGORY", "Código", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Support.DataGridView_ConfigCol(dgvFiltro, "NMCATEGORY", "Descricao", 2, "", 0, DataGridViewAutoSizeColumnMode.Fill);
            Support.DataGridView_ConfigCol(dgvFiltro, "qtdeAtrib", "Qtde. Atributos", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void dgvFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var form = Support.BuscaForm<frmCadastroCategoria>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
                if (form.Created)
                {

                    var conf = MessageBox.Show("A Categoria aberta será fechada, deseja continuar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (conf == DialogResult.Yes)
                    {
                        form.Dispose();
                        dgvFiltro_CellDoubleClick(sender, e);
                        return;
                    }
                    form.BringToFront();
                    return;
                }

                var frmcadastro = Program.Container.GetInstance<frmCadastroCategoria>();
                frmcadastro.FormClosed += (s, args) => this.btnPesquisar_Click(sender, e);
                CarregaCadastro(frmcadastro, ModoAcesso.Consulta);
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


                var form = Support.BuscaForm<frmCadastroCategoria>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
                if (form.Created)
                {

                    var conf = MessageBox.Show("A Categoria aberta será fechada, deseja continuar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (conf == DialogResult.Yes)
                    {
                        form.Dispose();
                        btnAlterar_Click(sender, e);
                        return;
                    }
                    form.BringToFront();
                    return;
                }

                var frmcadastro = Program.Container.GetInstance<frmCadastroCategoria>();
                frmcadastro.FormClosed += (s, args) => this.btnPesquisar_Click(sender, e);
                CarregaCadastro(frmcadastro, ModoAcesso.Alteracao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void CarregaCadastro(frmCadastroCategoria frmcadastro, ModoAcesso acesso)
        {
            if (dgvFiltro.SelectedRows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmcadastro.MdiParent = this.MdiParent;
                frmcadastro.acesso = acesso;
                if (acesso != ModoAcesso.Inclusao)
                {
                    var categoria = (gridCategoriasViewModel)dgvFiltro.SelectedRows[0].DataBoundItem;
                    frmcadastro.cod_categoria = categoria.IDCATEGORY;
                    frmcadastro.Load += (s, args) => frmcadastro.CarregaForm();
                }
                frmcadastro.Show();
                Cursor = Cursors.Default;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {


                var form = Support.BuscaForm<frmCadastroCategoria>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
                if (form.Created)
                {

                    var conf = MessageBox.Show("A Categoria aberta será fechada, deseja continuar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (conf == DialogResult.Yes)
                    {
                        form.Dispose();
                        btnIncluir_Click(sender, e);
                        return;
                    }
                    form.BringToFront();
                    return;
                }

                var frmcadastro = Program.Container.GetInstance<frmCadastroCategoria>();
                frmcadastro.FormClosed += (s, args) => this.btnPesquisar_Click(sender, e);
                CarregaCadastro(frmcadastro, ModoAcesso.Inclusao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
    }
}
