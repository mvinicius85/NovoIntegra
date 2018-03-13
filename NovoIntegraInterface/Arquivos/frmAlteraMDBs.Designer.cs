namespace NovoIntegraInterface.Arquivos
{
    partial class frmAlteraMDBs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlteraMDBs));
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btnSelecionaDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tlsVendasPesquisa = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.lblToolBar = new System.Windows.Forms.ToolStripLabel();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.tlsVendasPesquisa.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(71, 75);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(438, 20);
            this.txtDiretorio.TabIndex = 0;
            // 
            // btnSelecionaDir
            // 
            this.btnSelecionaDir.Image = global::NovoIntegraInterface.Properties.Resources.icons8_open_50;
            this.btnSelecionaDir.Location = new System.Drawing.Point(12, 68);
            this.btnSelecionaDir.Name = "btnSelecionaDir";
            this.btnSelecionaDir.Size = new System.Drawing.Size(49, 33);
            this.btnSelecionaDir.TabIndex = 1;
            this.btnSelecionaDir.UseVisualStyleBackColor = true;
            this.btnSelecionaDir.Click += new System.EventHandler(this.btnSelecionaDir_Click);
            // 
            // tlsVendasPesquisa
            // 
            this.tlsVendasPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsVendasPesquisa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsVendasPesquisa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.lblToolBar});
            this.tlsVendasPesquisa.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsVendasPesquisa.Location = new System.Drawing.Point(0, 116);
            this.tlsVendasPesquisa.Name = "tlsVendasPesquisa";
            this.tlsVendasPesquisa.Size = new System.Drawing.Size(521, 31);
            this.tlsVendasPesquisa.TabIndex = 8;
            this.tlsVendasPesquisa.Text = "toolStrip1";
            // 
            // btnGravar
            // 
            this.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(28, 28);
            this.btnGravar.Text = "toolStripButton4";
            this.btnGravar.ToolTipText = "Inserir Categoria no Arquivos Indexados";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblToolBar
            // 
            this.lblToolBar.Name = "lblToolBar";
            this.lblToolBar.Size = new System.Drawing.Size(0, 0);
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.cboCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(9, 12);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(507, 50);
            this.gpbCategoria.TabIndex = 11;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(6, 19);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(490, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // frmAlteraMDBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 147);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.tlsVendasPesquisa);
            this.Controls.Add(this.btnSelecionaDir);
            this.Controls.Add(this.txtDiretorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAlteraMDBs";
            this.Text = "Inserir Categoria";
            this.tlsVendasPesquisa.ResumeLayout(false);
            this.tlsVendasPesquisa.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btnSelecionaDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStrip tlsVendasPesquisa;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripLabel lblToolBar;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}