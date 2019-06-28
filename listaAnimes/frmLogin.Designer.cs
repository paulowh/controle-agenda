namespace listaAnimes
{
    partial class frmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.linkCadastrar = new System.Windows.Forms.LinkLabel();
            this.linkEsqSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "&Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "&Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(54, 110);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(85, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(54, 65);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(54, 28);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(168, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // linkCadastrar
            // 
            this.linkCadastrar.AutoSize = true;
            this.linkCadastrar.Location = new System.Drawing.Point(167, 147);
            this.linkCadastrar.Name = "linkCadastrar";
            this.linkCadastrar.Size = new System.Drawing.Size(52, 13);
            this.linkCadastrar.TabIndex = 4;
            this.linkCadastrar.TabStop = true;
            this.linkCadastrar.Text = "&Cadastrar";
            this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrar_LinkClicked);
            // 
            // linkEsqSenha
            // 
            this.linkEsqSenha.AutoSize = true;
            this.linkEsqSenha.Location = new System.Drawing.Point(134, 171);
            this.linkEsqSenha.Name = "linkEsqSenha";
            this.linkEsqSenha.Size = new System.Drawing.Size(88, 13);
            this.linkEsqSenha.TabIndex = 5;
            this.linkEsqSenha.TabStop = true;
            this.linkEsqSenha.Text = "&Esqueci a Senha";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 204);
            this.ControlBox = false;
            this.Controls.Add(this.linkEsqSenha);
            this.Controls.Add(this.linkCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel linkCadastrar;
        private System.Windows.Forms.LinkLabel linkEsqSenha;
    }
}

