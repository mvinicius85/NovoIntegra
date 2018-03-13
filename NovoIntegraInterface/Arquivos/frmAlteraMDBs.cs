using NovaIntegra.Application.Interfaces;
using NovaIntegra.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoIntegraInterface.Arquivos
{
    public partial class frmAlteraMDBs : Form
    {
        private readonly IDocumentoAppService _docappservice;
        public frmAlteraMDBs(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            InitializeComponent();
            CarregaForm();
        }

        private void CarregaForm()
        {
            var categorias = _docappservice.ListarCategorias();
            categorias.Add(new DCCategoryViewModel("", "<Selecione>"));
            cboCategoria.DataSource = categorias.OrderBy(x => x.IDCATEGORY).ToList();
            cboCategoria.ValueMember = "IDCATEGORY";
            cboCategoria.DisplayMember = "codenome";
        }

        private void btnSelecionaDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtDiretorio.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var arq = new List<string>();
            if (String.IsNullOrEmpty(txtDiretorio.Text))
            {
                MessageBox.Show(this,"Por favor selecione um diretorio!","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show(this, "Por favor selecione uma categoria!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var msg = MessageBox.Show(this, "Os arquivos serão alterados, deseja prosseguir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (msg.ToString() == "OK")
            {
                var dirimp = new DirectoryInfo(txtDiretorio.Text);
                var listfiles = dirimp.GetFiles("*.mdb", SearchOption.AllDirectories);
                foreach (var item in listfiles)
                {
                    var nomearquivo = item.FullName;
                    if (_docappservice.ValidaMDB(item.FullName))
                    {
                        if (_docappservice.AlteraArquivo(item.FullName))
                        {
                            var teste = _docappservice.UpdateArquivo(item.FullName, cboCategoria.SelectedValue.ToString());
                        }
                    }
                    else
                    {
                        arq.Add(item.Name);
                    }
                }
                MessageBox.Show(this,"Não foi possível alterar os seguintes arquivos: " + String.Join(", ",arq.ToList()),"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
