using NovoIntegraInterface.Documento;
using NovoIntegraInterface.Log;
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
        public MDIPrincipal()
        {
            InitializeComponent();
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
    }
}
