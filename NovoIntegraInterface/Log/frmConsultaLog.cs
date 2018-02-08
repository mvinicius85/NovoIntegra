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

namespace NovoIntegraInterface.Log
{
    public partial class frmConsultaLog : Form
    {
        private readonly IDocumentoAppService _docappservice;
        public frmConsultaLog(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            InitializeComponent();
            CarregaForm();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new FiltroLogViewModel(dtpInicio.Value, dtpFim.Value,
                    cboCategoria.SelectedValue.ToString(),txtLote.Text, chkErro.Checked);
                var log = _docappservice.BuscarLog(filtro);
                dgvFiltro.DataSource = log;


                Support.DataGridView_ConfigGrid(dgvFiltro, false);
                Support.DataGridView_ConfigCol(dgvFiltro, "Arquivo", "Arquivo", 1, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                Support.DataGridView_ConfigCol(dgvFiltro, "Categoria", "Categoria", 2, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                Support.DataGridView_ConfigCol(dgvFiltro, "Documento", "Documento", 3, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                Support.DataGridView_ConfigCol(dgvFiltro, "Msg", "Msg. Erro", 4, "", 0, DataGridViewAutoSizeColumnMode.Fill);
                Support.DataGridView_ConfigCol(dgvFiltro, "MsgErroSistema", "Msg. Interna", 5, "", 0, DataGridViewAutoSizeColumnMode.Fill);
                Support.DataGridView_ConfigCol(dgvFiltro, "DtEvento", "DtEvento", 6, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                Support.DataGridView_ConfigCol(dgvFiltro, "IndErro", "Erro", 7, "", 0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                ;            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);;
            }
        }

        internal void CarregaForm()
        {
            var categorias = _docappservice.ListarCategorias();
            categorias.Add(new DCCategoryViewModel("", "<Selecione>"));
            cboCategoria.DataSource = categorias.OrderBy(x => x.IDCATEGORY).ToList();
            cboCategoria.ValueMember = "IDCATEGORY";
            cboCategoria.DisplayMember = "codenome";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            if (dgvFiltro.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvFiltro.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvFiltro.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvFiltro.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvFiltro.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvFiltro.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
