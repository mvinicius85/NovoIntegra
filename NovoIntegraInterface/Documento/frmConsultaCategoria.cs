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

        }
    }
}
