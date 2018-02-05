using NovaIntegra.Application.Interfaces;
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
    public partial class frmCadastroParametros : Form
    {
        public int cod_parametro;
        private readonly IDocumentoAppService _docappservice;
        public frmCadastroParametros(IDocumentoAppService docappservice)
        {
            try
            {
                _docappservice = docappservice;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        public void CarregaForm()
        {
            var c = _docappservice.CarregarParametro(cod_parametro);
            txtNome.Text = c.NomeParametro;
            txtValor.Text = c.Valor;
            txtDescricao.Text = c.Descricao;
        }
    }
}
