using NovaIntegra.Application.Interfaces;
using NovoIntegraInterface.Arquivos;
using NovoIntegraInterface.Documento;
using NovoIntegraInterface.Log;
using NovoIntegraInterface.Sobre;
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

namespace NovoIntegraInterface
{
    public partial class MDIPrincipal : Form
    {
        private readonly IDocumentoAppService _docappservice;
        public MDIPrincipal(IDocumentoAppService docappservice)
        {
            _docappservice = docappservice;
            InitializeComponent();
            CarregaForm();
        }

        private void CarregaForm()
        {
            try
            {
                if (_docappservice.StatusServico())
                {
                    chkServico.Text = "SERVIÇO LIGADO";
                    chkServico.BackColor = Color.LimeGreen;
                    return;

                }
                chkServico.Text = "SERVIÇO DESLIGADO";
                chkServico.BackColor = Color.Tomato;
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void consultarParametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Support.BuscaForm<frmConsultaParametros>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
            if (!form.Created)
            {
                form.MdiParent = this;
                form.Show();
                return;
            }
            form.BringToFront();
            return;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Support.BuscaForm<frmConsultaCategoria>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
            if (!form.Created)
            {
                form.MdiParent = this;
                form.Show();
                return;
            }
            form.BringToFront();
            return;
        }

        private void consultarLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Support.BuscaForm<frmConsultaLog>();  //  Program.Container.GetInstance<frmCadastroContaContabil>();
            if (!form.Created)
            {
                form.MdiParent = this;
                form.Show();
                return;
            }
            form.BringToFront();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void chkServico_Click(object sender, EventArgs e)
        {
            if (_docappservice.StatusServico())
            {
                if (MessageBox.Show("Deseja desligar o serviço de importação?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _docappservice.DesligarServico();
                    chkServico.Text = "SERVIÇO DESLIGADO";
                    chkServico.BackColor = Color.Tomato;
                }
                return;
            }
            else
            {
                if (MessageBox.Show("Deseja ligar o serviço de importação?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _docappservice.LigarServico();
                    chkServico.Text = "SERVIÇO LIGADO";
                    chkServico.BackColor = Color.LimeGreen;
                }
                return;
            }

        }

        private void inserirCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Support.BuscaForm<frmAlteraMDBs>(); 
            if (!form.Created)
            {
                form.MdiParent = this;
                form.Show();
                return;
            }
            form.BringToFront();
            return;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Support.BuscaForm<frmSobre>();
            if (!form.Created)
            {
                form.MdiParent = this;
                form.Show();
                return;
            }
            form.BringToFront();
            return;
        }
    }
}
