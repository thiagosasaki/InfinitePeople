namespace InfinitePeople
{
    partial class frmConsultaGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGeral));
            this.listaConsulta = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.Documento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaConsulta
            // 
            this.listaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Documento,
            this.Nome,
            this.Sexo,
            this.Email,
            this.Telefone});
            this.listaConsulta.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listaConsulta.FullRowSelect = true;
            this.listaConsulta.GridLines = true;
            this.listaConsulta.HideSelection = false;
            this.listaConsulta.Location = new System.Drawing.Point(15, 60);
            this.listaConsulta.MultiSelect = false;
            this.listaConsulta.Name = "listaConsulta";
            this.listaConsulta.Size = new System.Drawing.Size(883, 358);
            this.listaConsulta.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listaConsulta.TabIndex = 0;
            this.listaConsulta.UseCompatibleStateImageBehavior = false;
            this.listaConsulta.View = System.Windows.Forms.View.Details;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(15, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Documento
            // 
            this.Documento.Text = "Documento";
            this.Documento.Width = 117;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 180;
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 90;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = 206;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 113;
            // 
            // frmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.listaConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ColumnHeader Documento;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefone;
    }
}