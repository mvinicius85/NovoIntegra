namespace NovoIntegraInterface.Documento
{
    partial class frmCadastroCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCategoria));
            this.tlsVendasPesquisa = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblToolBar = new System.Windows.Forms.ToolStripLabel();
            this.dgvAtributos = new System.Windows.Forms.DataGridView();
            this.gpbAtributo = new System.Windows.Forms.GroupBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCodCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAtribSeSuite = new System.Windows.Forms.ComboBox();
            this.cboTipoAtributo = new System.Windows.Forms.ComboBox();
            this.txtAtribImagem = new System.Windows.Forms.TextBox();
            this.chkTitulo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.tlsVendasPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
            this.gpbAtributo.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsVendasPesquisa
            // 
            this.tlsVendasPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsVendasPesquisa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsVendasPesquisa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.toolStripSeparator3,
            this.btnVoltar,
            this.lblToolBar});
            this.tlsVendasPesquisa.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsVendasPesquisa.Location = new System.Drawing.Point(0, 313);
            this.tlsVendasPesquisa.Name = "tlsVendasPesquisa";
            this.tlsVendasPesquisa.Size = new System.Drawing.Size(658, 31);
            this.tlsVendasPesquisa.TabIndex = 7;
            this.tlsVendasPesquisa.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // lblToolBar
            // 
            this.lblToolBar.Name = "lblToolBar";
            this.lblToolBar.Size = new System.Drawing.Size(0, 0);
            // 
            // dgvAtributos
            // 
            this.dgvAtributos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtributos.Location = new System.Drawing.Point(5, 160);
            this.dgvAtributos.Name = "dgvAtributos";
            this.dgvAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtributos.Size = new System.Drawing.Size(649, 150);
            this.dgvAtributos.TabIndex = 8;
            // 
            // gpbAtributo
            // 
            this.gpbAtributo.Controls.Add(this.button2);
            this.gpbAtributo.Controls.Add(this.button1);
            this.gpbAtributo.Controls.Add(this.chkTitulo);
            this.gpbAtributo.Controls.Add(this.txtAtribImagem);
            this.gpbAtributo.Controls.Add(this.cboTipoAtributo);
            this.gpbAtributo.Controls.Add(this.cboAtribSeSuite);
            this.gpbAtributo.Controls.Add(this.label5);
            this.gpbAtributo.Controls.Add(this.label4);
            this.gpbAtributo.Controls.Add(this.label3);
            this.gpbAtributo.Location = new System.Drawing.Point(5, 68);
            this.gpbAtributo.Name = "gpbAtributo";
            this.gpbAtributo.Size = new System.Drawing.Size(649, 86);
            this.gpbAtributo.TabIndex = 9;
            this.gpbAtributo.TabStop = false;
            this.gpbAtributo.Text = "Atributo";
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.txtDescCategoria);
            this.gpbCategoria.Controls.Add(this.cboCodCategoria);
            this.gpbCategoria.Controls.Add(this.label2);
            this.gpbCategoria.Controls.Add(this.label1);
            this.gpbCategoria.Location = new System.Drawing.Point(5, 12);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(649, 50);
            this.gpbCategoria.TabIndex = 10;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // cboCodCategoria
            // 
            this.cboCodCategoria.FormattingEnabled = true;
            this.cboCodCategoria.Location = new System.Drawing.Point(56, 17);
            this.cboCodCategoria.Name = "cboCodCategoria";
            this.cboCodCategoria.Size = new System.Drawing.Size(210, 21);
            this.cboCodCategoria.TabIndex = 2;
            // 
            // txtDescCategoria
            // 
            this.txtDescCategoria.Location = new System.Drawing.Point(336, 17);
            this.txtDescCategoria.Name = "txtDescCategoria";
            this.txtDescCategoria.Size = new System.Drawing.Size(307, 20);
            this.txtDescCategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Atrib. SE Suite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Atrib. Imagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Atributo:";
            // 
            // cboAtribSeSuite
            // 
            this.cboAtribSeSuite.FormattingEnabled = true;
            this.cboAtribSeSuite.Location = new System.Drawing.Point(91, 24);
            this.cboAtribSeSuite.Name = "cboAtribSeSuite";
            this.cboAtribSeSuite.Size = new System.Drawing.Size(145, 21);
            this.cboAtribSeSuite.TabIndex = 4;
            // 
            // cboTipoAtributo
            // 
            this.cboTipoAtributo.FormattingEnabled = true;
            this.cboTipoAtributo.Location = new System.Drawing.Point(91, 48);
            this.cboTipoAtributo.Name = "cboTipoAtributo";
            this.cboTipoAtributo.Size = new System.Drawing.Size(145, 21);
            this.cboTipoAtributo.TabIndex = 5;
            // 
            // txtAtribImagem
            // 
            this.txtAtribImagem.Location = new System.Drawing.Point(347, 24);
            this.txtAtribImagem.Name = "txtAtribImagem";
            this.txtAtribImagem.Size = new System.Drawing.Size(294, 20);
            this.txtAtribImagem.TabIndex = 6;
            // 
            // chkTitulo
            // 
            this.chkTitulo.AutoSize = true;
            this.chkTitulo.Location = new System.Drawing.Point(347, 51);
            this.chkTitulo.Name = "chkTitulo";
            this.chkTitulo.Size = new System.Drawing.Size(54, 17);
            this.chkTitulo.TabIndex = 7;
            this.chkTitulo.Text = "Título";
            this.chkTitulo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::NovoIntegraInterface.Properties.Resources.Plus_Blue_24x24;
            this.button2.Location = new System.Drawing.Point(613, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::NovoIntegraInterface.Properties.Resources.Document_New_Blue_24x24;
            this.button1.Location = new System.Drawing.Point(583, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 32);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(28, 28);
            this.btnGravar.Text = "toolStripButton4";
            this.btnGravar.ToolTipText = "Salva os dados da tela";
            // 
            // btnVoltar
            // 
            this.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(28, 28);
            this.btnVoltar.Text = "toolStripButton5";
            this.btnVoltar.ToolTipText = "Retorna a tela anterior";
            this.btnVoltar.Visible = false;
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 344);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.gpbAtributo);
            this.Controls.Add(this.dgvAtributos);
            this.Controls.Add(this.tlsVendasPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadastroCategoria";
            this.Text = "Cadastro Categoria";
            this.tlsVendasPesquisa.ResumeLayout(false);
            this.tlsVendasPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
            this.gpbAtributo.ResumeLayout(false);
            this.gpbAtributo.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsVendasPesquisa;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblToolBar;
        private System.Windows.Forms.DataGridView dgvAtributos;
        private System.Windows.Forms.GroupBox gpbAtributo;
        private System.Windows.Forms.CheckBox chkTitulo;
        private System.Windows.Forms.TextBox txtAtribImagem;
        private System.Windows.Forms.ComboBox cboTipoAtributo;
        private System.Windows.Forms.ComboBox cboAtribSeSuite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.TextBox txtDescCategoria;
        private System.Windows.Forms.ComboBox cboCodCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}