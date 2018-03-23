namespace NovoIntegraInterface
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkServico = new System.Windows.Forms.CheckBox();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrizaçãoToolStripMenuItem,
            this.logToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrizaçãoToolStripMenuItem
            // 
            this.parametrizaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarParametrosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.parametrizaçãoToolStripMenuItem.Name = "parametrizaçãoToolStripMenuItem";
            this.parametrizaçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.parametrizaçãoToolStripMenuItem.Text = "Administração";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLogToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.logToolStripMenuItem.Text = "Auditoria";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirCategoriaToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.manutençãoToolStripMenuItem.Text = "Ajustes";
            // 
            // chkServico
            // 
            this.chkServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkServico.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkServico.BackColor = System.Drawing.Color.LimeGreen;
            this.chkServico.Location = new System.Drawing.Point(620, 27);
            this.chkServico.Margin = new System.Windows.Forms.Padding(0);
            this.chkServico.Name = "chkServico";
            this.chkServico.Size = new System.Drawing.Size(140, 70);
            this.chkServico.TabIndex = 3;
            this.chkServico.Text = "SERVIÇO DESLIGADO";
            this.chkServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkServico.UseVisualStyleBackColor = false;
            this.chkServico.Click += new System.EventHandler(this.chkServico_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::NovoIntegraInterface.Properties.Resources.icons8_about_26;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // consultarParametrosToolStripMenuItem
            // 
            this.consultarParametrosToolStripMenuItem.Image = global::NovoIntegraInterface.Properties.Resources.icons8_support_26;
            this.consultarParametrosToolStripMenuItem.Name = "consultarParametrosToolStripMenuItem";
            this.consultarParametrosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.consultarParametrosToolStripMenuItem.Text = "Parâmetros do sistema";
            this.consultarParametrosToolStripMenuItem.Click += new System.EventHandler(this.consultarParametrosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = global::NovoIntegraInterface.Properties.Resources.icons8_settings_26;
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.categoriasToolStripMenuItem.Text = "Configuração de categorias ";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultarLogToolStripMenuItem
            // 
            this.consultarLogToolStripMenuItem.Image = global::NovoIntegraInterface.Properties.Resources.icons8_edit_property_filled_50;
            this.consultarLogToolStripMenuItem.Name = "consultarLogToolStripMenuItem";
            this.consultarLogToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarLogToolStripMenuItem.Text = "Registros de importação";
            this.consultarLogToolStripMenuItem.Click += new System.EventHandler(this.consultarLogToolStripMenuItem_Click);
            // 
            // inserirCategoriaToolStripMenuItem
            // 
            this.inserirCategoriaToolStripMenuItem.Image = global::NovoIntegraInterface.Properties.Resources.icons8_database_26;
            this.inserirCategoriaToolStripMenuItem.Name = "inserirCategoriaToolStripMenuItem";
            this.inserirCategoriaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inserirCategoriaToolStripMenuItem.Text = "Base de dados prodimage";
            this.inserirCategoriaToolStripMenuItem.Click += new System.EventHandler(this.inserirCategoriaToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 364);
            this.Controls.Add(this.chkServico);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrador OM30 SE Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarParametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkServico;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}