namespace listaAnimes
{
    partial class frmCadastroConteudo
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
            this.components = new System.ComponentModel.Container();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClassificação = new System.Windows.Forms.Label();
            this.lblQuantEp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtquantidadeEp = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 110);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "&Categoria:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 50);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "&Genero:";
            // 
            // lblClassificação
            // 
            this.lblClassificação.AutoSize = true;
            this.lblClassificação.Location = new System.Drawing.Point(192, 54);
            this.lblClassificação.Name = "lblClassificação";
            this.lblClassificação.Size = new System.Drawing.Size(72, 13);
            this.lblClassificação.TabIndex = 5;
            this.lblClassificação.Text = "&Classificação:";
            // 
            // lblQuantEp
            // 
            this.lblQuantEp.AutoSize = true;
            this.lblQuantEp.Location = new System.Drawing.Point(8, 77);
            this.lblQuantEp.Name = "lblQuantEp";
            this.lblQuantEp.Size = new System.Drawing.Size(58, 13);
            this.lblQuantEp.TabIndex = 6;
            this.lblQuantEp.Text = "&Quant. Ep:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Status:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(72, 48);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(115, 20);
            this.txtGenero.TabIndex = 9;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(270, 47);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(100, 20);
            this.txtClassificacao.TabIndex = 10;
            // 
            // txtquantidadeEp
            // 
            this.txtquantidadeEp.Location = new System.Drawing.Point(72, 73);
            this.txtquantidadeEp.Name = "txtquantidadeEp";
            this.txtquantidadeEp.Size = new System.Drawing.Size(70, 20);
            this.txtquantidadeEp.TabIndex = 11;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Anime",
            "Serie",
            "Filme"});
            this.cbxCategoria.Location = new System.Drawing.Point(72, 103);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 14;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Em Andamento",
            "Finalizado",
            "Cancelado"});
            this.cbxStatus.Location = new System.Drawing.Point(270, 103);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(100, 21);
            this.cbxStatus.TabIndex = 16;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(295, 148);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(205, 148);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastroConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 198);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtquantidadeEp);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQuantEp);
            this.Controls.Add(this.lblClassificação);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblClassificação;
        private System.Windows.Forms.Label lblQuantEp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.TextBox txtquantidadeEp;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSair;
    }
}