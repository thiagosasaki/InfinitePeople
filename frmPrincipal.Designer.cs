namespace InfinitePeople
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorDocumentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ttToolStripMenuItem
            // 
            this.ttToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ttToolStripMenuItem.BackgroundImage")));
            this.ttToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ttToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttToolStripMenuItem.Enabled = false;
            this.ttToolStripMenuItem.Name = "ttToolStripMenuItem";
            this.ttToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPessoaToolStripMenuItem,
            this.excluirPessoaToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarPessoaToolStripMenuItem
            // 
            this.cadastrarPessoaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cadastrarPessoaToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarPessoaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cadastrarPessoaToolStripMenuItem.Name = "cadastrarPessoaToolStripMenuItem";
            this.cadastrarPessoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrarPessoaToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarPessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPessoaToolStripMenuItem_Click);
            // 
            // excluirPessoaToolStripMenuItem
            // 
            this.excluirPessoaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.excluirPessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPorDocumentoToolStripMenuItem,
            this.consultaPorDocumentoToolStripMenuItem1});
            this.excluirPessoaToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirPessoaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.excluirPessoaToolStripMenuItem.Name = "excluirPessoaToolStripMenuItem";
            this.excluirPessoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.excluirPessoaToolStripMenuItem.Text = "Consultar";
            // 
            // consultaPorDocumentoToolStripMenuItem
            // 
            this.consultaPorDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.consultaPorDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.consultaPorDocumentoToolStripMenuItem.Name = "consultaPorDocumentoToolStripMenuItem";
            this.consultaPorDocumentoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.consultaPorDocumentoToolStripMenuItem.Text = "Consulta geral";
            this.consultaPorDocumentoToolStripMenuItem.Click += new System.EventHandler(this.consultaPorDocumentoToolStripMenuItem_Click);
            // 
            // consultaPorDocumentoToolStripMenuItem1
            // 
            this.consultaPorDocumentoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.consultaPorDocumentoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.consultaPorDocumentoToolStripMenuItem1.Name = "consultaPorDocumentoToolStripMenuItem1";
            this.consultaPorDocumentoToolStripMenuItem1.Size = new System.Drawing.Size(261, 26);
            this.consultaPorDocumentoToolStripMenuItem1.Text = "Consulta por documento";
            this.consultaPorDocumentoToolStripMenuItem1.Click += new System.EventHandler(this.consultaPorDocumentoToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.excluirToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.excluirToolStripMenuItem.Text = "Editar/excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorDocumentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttToolStripMenuItem;
    }
}

