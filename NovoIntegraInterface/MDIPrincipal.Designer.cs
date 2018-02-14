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
            this.consultarParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkServico = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrizaçãoToolStripMenuItem,
            this.logToolStripMenuItem});
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
            this.parametrizaçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.parametrizaçãoToolStripMenuItem.Text = "Parametrização";
            // 
            // consultarParametrosToolStripMenuItem
            // 
            this.consultarParametrosToolStripMenuItem.Name = "consultarParametrosToolStripMenuItem";
            this.consultarParametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.consultarParametrosToolStripMenuItem.Text = "Parametros";
            this.consultarParametrosToolStripMenuItem.Click += new System.EventHandler(this.consultarParametrosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLogToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // consultarLogToolStripMenuItem
            // 
            this.consultarLogToolStripMenuItem.Name = "consultarLogToolStripMenuItem";
            this.consultarLogToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.consultarLogToolStripMenuItem.Text = "Consultar Log";
            this.consultarLogToolStripMenuItem.Click += new System.EventHandler(this.consultarLogToolStripMenuItem_Click);
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
            this.Text = "Novo Integra - Interface de Paramentrização/Log";
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
    }
}