namespace NovoIntegraInterface.Documento
{
    partial class frmCadastroParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroParametros));
            this.grpDadosParametro = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlsParametro = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblToolBar = new System.Windows.Forms.ToolStripLabel();
            this.grpDadosParametro.SuspendLayout();
            this.tlsParametro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosParametro
            // 
            this.grpDadosParametro.Controls.Add(this.txtDescricao);
            this.grpDadosParametro.Controls.Add(this.txtValor);
            this.grpDadosParametro.Controls.Add(this.txtNome);
            this.grpDadosParametro.Controls.Add(this.label3);
            this.grpDadosParametro.Controls.Add(this.label2);
            this.grpDadosParametro.Controls.Add(this.label1);
            this.grpDadosParametro.Location = new System.Drawing.Point(7, 3);
            this.grpDadosParametro.Name = "grpDadosParametro";
            this.grpDadosParametro.Size = new System.Drawing.Size(476, 136);
            this.grpDadosParametro.TabIndex = 0;
            this.grpDadosParametro.TabStop = false;
            this.grpDadosParametro.Text = "Dados Parâmetro";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(66, 49);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(405, 81);
            this.txtDescricao.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(268, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(203, 20);
            this.txtValor.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(66, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(129, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // tlsParametro
            // 
            this.tlsParametro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsParametro.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsParametro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnVoltar,
            this.toolStripSeparator3,
            this.lblToolBar});
            this.tlsParametro.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsParametro.Location = new System.Drawing.Point(0, 141);
            this.tlsParametro.Name = "tlsParametro";
            this.tlsParametro.Size = new System.Drawing.Size(490, 31);
            this.tlsParametro.TabIndex = 6;
            this.tlsParametro.Text = "toolStrip1";
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
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
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
            // frmCadastroParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 172);
            this.Controls.Add(this.tlsParametro);
            this.Controls.Add(this.grpDadosParametro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadastroParametros";
            this.Text = "Cadastro Parâmetro";
            this.grpDadosParametro.ResumeLayout(false);
            this.grpDadosParametro.PerformLayout();
            this.tlsParametro.ResumeLayout(false);
            this.tlsParametro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosParametro;
        private System.Windows.Forms.ToolStrip tlsParametro;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblToolBar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}