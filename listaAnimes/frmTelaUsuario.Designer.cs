namespace listaAnimes
{
    partial class frmTelaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaUsuario));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridConteudo = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOpcao = new System.Windows.Forms.GroupBox();
            this.rbnGeral = new System.Windows.Forms.RadioButton();
            this.rbnSeries = new System.Windows.Forms.RadioButton();
            this.rbnFilmes = new System.Windows.Forms.RadioButton();
            this.rbnAnime = new System.Windows.Forms.RadioButton();
            this.btnAdiconar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConteudo)).BeginInit();
            this.grbOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(626, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridConteudo
            // 
            this.dataGridConteudo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridConteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConteudo.Location = new System.Drawing.Point(163, 78);
            this.dataGridConteudo.Name = "dataGridConteudo";
            this.dataGridConteudo.Size = new System.Drawing.Size(538, 327);
            this.dataGridConteudo.TabIndex = 7;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(163, 39);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(439, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar Conteúdo";
            // 
            // grbOpcao
            // 
            this.grbOpcao.Controls.Add(this.rbnGeral);
            this.grbOpcao.Controls.Add(this.rbnSeries);
            this.grbOpcao.Controls.Add(this.rbnFilmes);
            this.grbOpcao.Controls.Add(this.rbnAnime);
            this.grbOpcao.Location = new System.Drawing.Point(25, 23);
            this.grbOpcao.Name = "grbOpcao";
            this.grbOpcao.Size = new System.Drawing.Size(116, 131);
            this.grbOpcao.TabIndex = 9;
            this.grbOpcao.TabStop = false;
            this.grbOpcao.Text = "Opções";
            // 
            // rbnGeral
            // 
            this.rbnGeral.AutoSize = true;
            this.rbnGeral.Location = new System.Drawing.Point(11, 32);
            this.rbnGeral.Name = "rbnGeral";
            this.rbnGeral.Size = new System.Drawing.Size(50, 17);
            this.rbnGeral.TabIndex = 3;
            this.rbnGeral.TabStop = true;
            this.rbnGeral.Text = "Geral";
            this.rbnGeral.UseVisualStyleBackColor = true;
            // 
            // rbnSeries
            // 
            this.rbnSeries.AutoSize = true;
            this.rbnSeries.Location = new System.Drawing.Point(11, 78);
            this.rbnSeries.Name = "rbnSeries";
            this.rbnSeries.Size = new System.Drawing.Size(54, 17);
            this.rbnSeries.TabIndex = 2;
            this.rbnSeries.TabStop = true;
            this.rbnSeries.Text = "Séries";
            this.rbnSeries.UseVisualStyleBackColor = true;
            // 
            // rbnFilmes
            // 
            this.rbnFilmes.AutoSize = true;
            this.rbnFilmes.Location = new System.Drawing.Point(11, 55);
            this.rbnFilmes.Name = "rbnFilmes";
            this.rbnFilmes.Size = new System.Drawing.Size(54, 17);
            this.rbnFilmes.TabIndex = 1;
            this.rbnFilmes.TabStop = true;
            this.rbnFilmes.Text = "Filmes";
            this.rbnFilmes.UseVisualStyleBackColor = true;
            // 
            // rbnAnime
            // 
            this.rbnAnime.AutoSize = true;
            this.rbnAnime.Location = new System.Drawing.Point(11, 101);
            this.rbnAnime.Name = "rbnAnime";
            this.rbnAnime.Size = new System.Drawing.Size(54, 17);
            this.rbnAnime.TabIndex = 0;
            this.rbnAnime.TabStop = true;
            this.rbnAnime.Text = "Anime";
            this.rbnAnime.UseVisualStyleBackColor = true;
            // 
            // btnAdiconar
            // 
            this.btnAdiconar.Location = new System.Drawing.Point(25, 169);
            this.btnAdiconar.Name = "btnAdiconar";
            this.btnAdiconar.Size = new System.Drawing.Size(75, 41);
            this.btnAdiconar.TabIndex = 10;
            this.btnAdiconar.Text = "Adicionar Conteudo";
            this.btnAdiconar.UseCompatibleTextRendering = true;
            this.btnAdiconar.UseVisualStyleBackColor = true;
            this.btnAdiconar.Click += new System.EventHandler(this.btnAdiconar_Click);
            // 
            // frmTelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 439);
            this.Controls.Add(this.btnAdiconar);
            this.Controls.Add(this.grbOpcao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridConteudo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConteudo)).EndInit();
            this.grbOpcao.ResumeLayout(false);
            this.grbOpcao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridConteudo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbOpcao;
        private System.Windows.Forms.RadioButton rbnGeral;
        private System.Windows.Forms.RadioButton rbnSeries;
        private System.Windows.Forms.RadioButton rbnFilmes;
        private System.Windows.Forms.RadioButton rbnAnime;
        private System.Windows.Forms.Button btnAdiconar;
    }
}