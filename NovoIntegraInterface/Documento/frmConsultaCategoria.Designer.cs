namespace NovoIntegraInterface.Documento
{
    partial class frmConsultaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCategoria));
            this.tlsVendasPesquisa = new System.Windows.Forms.ToolStrip();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnConstultar = new System.Windows.Forms.ToolStripButton();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblToolBar = new System.Windows.Forms.ToolStripLabel();
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.lblResultPesquisa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.txtDescCategoria = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tlsVendasPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsVendasPesquisa
            // 
            this.tlsVendasPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsVendasPesquisa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsVendasPesquisa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpar,
            this.btnIncluir,
            this.btnAlterar,
            this.btnConstultar,
            this.btnVoltar,
            this.toolStripSeparator3,
            this.lblToolBar});
            this.tlsVendasPesquisa.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsVendasPesquisa.Location = new System.Drawing.Point(0, 276);
            this.tlsVendasPesquisa.Name = "tlsVendasPesquisa";
            this.tlsVendasPesquisa.Size = new System.Drawing.Size(453, 31);
            this.tlsVendasPesquisa.TabIndex = 146;
            this.tlsVendasPesquisa.Text = "toolStrip1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(28, 28);
            this.btnLimpar.Text = "toolStripButton1";
            this.btnLimpar.ToolTipText = "Limpa os campos da tela";
            this.btnLimpar.Visible = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(28, 28);
            this.btnIncluir.Text = "toolStripButton2";
            this.btnIncluir.ToolTipText = "Insere novo registro";
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAlterar.Text = "toolStripButton3";
            this.btnAlterar.ToolTipText = "Altera o registro selecionado";
            // 
            // btnConstultar
            // 
            this.btnConstultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConstultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConstultar.Image")));
            this.btnConstultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConstultar.Name = "btnConstultar";
            this.btnConstultar.Size = new System.Drawing.Size(28, 28);
            this.btnConstultar.Text = "toolStripButton4";
            this.btnConstultar.ToolTipText = "Consulta o registro selecionado";
            this.btnConstultar.Visible = false;
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
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.AllowUserToResizeColumns = false;
            this.dgvFiltro.AllowUserToResizeRows = false;
            this.dgvFiltro.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Location = new System.Drawing.Point(6, 106);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(439, 167);
            this.dgvFiltro.TabIndex = 147;
            this.dgvFiltro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltro_CellDoubleClick);
            // 
            // lblResultPesquisa
            // 
            this.lblResultPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResultPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPesquisa.ForeColor = System.Drawing.Color.White;
            this.lblResultPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultPesquisa.Location = new System.Drawing.Point(3, 84);
            this.lblResultPesquisa.Name = "lblResultPesquisa";
            this.lblResultPesquisa.Size = new System.Drawing.Size(442, 19);
            this.lblResultPesquisa.TabIndex = 148;
            this.lblResultPesquisa.Tag = "Resultado Pesquisa";
            this.lblResultPesquisa.Text = "Resultado Pesquisa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtDescCategoria);
            this.groupBox1.Controls.Add(this.txtCodCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 79);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(70, 24);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(159, 20);
            this.txtCodCategoria.TabIndex = 2;
            // 
            // txtDescCategoria
            // 
            this.txtDescCategoria.Location = new System.Drawing.Point(70, 50);
            this.txtDescCategoria.Name = "txtDescCategoria";
            this.txtDescCategoria.Size = new System.Drawing.Size(273, 20);
            this.txtDescCategoria.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(394, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(39, 40);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultPesquisa);
            this.Controls.Add(this.dgvFiltro);
            this.Controls.Add(this.tlsVendasPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaCategoria";
            this.Text = "Consulta Categoria";
            this.tlsVendasPesquisa.ResumeLayout(false);
            this.tlsVendasPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsVendasPesquisa;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnConstultar;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblToolBar;
        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.Label lblResultPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescCategoria;
        private System.Windows.Forms.Button btnPesquisar;
    }
}