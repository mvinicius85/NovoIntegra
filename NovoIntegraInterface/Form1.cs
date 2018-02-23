using NovaIntegra.Application.Interfaces;
using NovoIntegra;
using NovoIntegra.Core.Domain.Util;
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

namespace NovoIntegraInterface
{
    public partial class Form1 : Form
    {
        private readonly SimpleInjector.Container container;
        private readonly IDocumentoAppService _docappservice;
        public Form1(IDocumentoAppService docappservice)
        {
            container = Program.Container;
            _docappservice = docappservice;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var teste = container.GetInstance<Importacao>();
            teste.Importar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox3.Text = StringCipher.Encrypt(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = StringCipher.Decrypt(textBox5.Text, textBox6.Text);
        }
    }
}
