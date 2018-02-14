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
    public partial class frmCadastroParametros : Form
    {
        public int cod_parametro;
        private readonly IDocumentoAppService _docappservice;
        public ModoAcesso acesso;
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

        public void CarregaForm(ModoAcesso acesso)
        {
            var c = _docappservice.CarregarParametro(cod_parametro);
            txtNome.Text = c.NomeParametro;
            txtValor.Text = c.Valor;
            txtDescricao.Text = c.Descricao;
            if (acesso == ModoAcesso.Consulta)
            {
                grpDadosParametro.Enabled = false;
                tlsParametro.Enabled = false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
 
            try
            {
                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("Por favor preencha o campo Valor com uma informação válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show("Por favor faça uma descrição breve do uso do parâmetro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Cursor = Cursors.WaitCursor;
                var param = new AA_ParametrosViewModel(cod_parametro, txtNome.Text, txtDescricao.Text, txtValor.Text);
                _docappservice.AtualizaParametro(param);
                Cursor = Cursors.Default;
                MessageBox.Show("Gravação Concluida","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.GetBaseException().Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
