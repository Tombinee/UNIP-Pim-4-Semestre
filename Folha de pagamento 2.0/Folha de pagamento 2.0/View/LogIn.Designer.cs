namespace Folha_de_pagamento_2._0
{
    partial class LogIn
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
			this.btn_entrar = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_usuario = new System.Windows.Forms.TextBox();
			this.tb_senha = new System.Windows.Forms.TextBox();
			this.lnk_criarUser = new System.Windows.Forms.LinkLabel();
			this.btn_criar = new System.Windows.Forms.Button();
			this.tb_confirmar = new System.Windows.Forms.TextBox();
			this.lb_confirmar = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_entrar
			// 
			this.btn_entrar.Location = new System.Drawing.Point(57, 168);
			this.btn_entrar.Name = "btn_entrar";
			this.btn_entrar.Size = new System.Drawing.Size(66, 23);
			this.btn_entrar.TabIndex = 0;
			this.btn_entrar.Text = "Entrar";
			this.btn_entrar.UseVisualStyleBackColor = true;
			this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(216, 168);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(66, 23);
			this.btn_sair.TabIndex = 1;
			this.btn_sair.Text = "Sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuário:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha:";
			// 
			// tb_usuario
			// 
			this.tb_usuario.Location = new System.Drawing.Point(125, 28);
			this.tb_usuario.Name = "tb_usuario";
			this.tb_usuario.Size = new System.Drawing.Size(181, 20);
			this.tb_usuario.TabIndex = 4;
			// 
			// tb_senha
			// 
			this.tb_senha.Location = new System.Drawing.Point(125, 79);
			this.tb_senha.Name = "tb_senha";
			this.tb_senha.Size = new System.Drawing.Size(181, 20);
			this.tb_senha.TabIndex = 5;
			this.tb_senha.UseSystemPasswordChar = true;
			// 
			// lnk_criarUser
			// 
			this.lnk_criarUser.AutoSize = true;
			this.lnk_criarUser.Location = new System.Drawing.Point(22, 108);
			this.lnk_criarUser.Name = "lnk_criarUser";
			this.lnk_criarUser.Size = new System.Drawing.Size(92, 13);
			this.lnk_criarUser.TabIndex = 6;
			this.lnk_criarUser.TabStop = true;
			this.lnk_criarUser.Text = "Criar novo usuário";
			this.lnk_criarUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btn_criar
			// 
			this.btn_criar.Location = new System.Drawing.Point(57, 168);
			this.btn_criar.Name = "btn_criar";
			this.btn_criar.Size = new System.Drawing.Size(66, 23);
			this.btn_criar.TabIndex = 7;
			this.btn_criar.Text = "Criar";
			this.btn_criar.UseVisualStyleBackColor = true;
			this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
			// 
			// tb_confirmar
			// 
			this.tb_confirmar.Location = new System.Drawing.Point(125, 125);
			this.tb_confirmar.Name = "tb_confirmar";
			this.tb_confirmar.Size = new System.Drawing.Size(181, 20);
			this.tb_confirmar.TabIndex = 8;
			this.tb_confirmar.UseSystemPasswordChar = true;
			// 
			// lb_confirmar
			// 
			this.lb_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_confirmar.Location = new System.Drawing.Point(21, 121);
			this.lb_confirmar.Name = "lb_confirmar";
			this.lb_confirmar.Size = new System.Drawing.Size(102, 24);
			this.lb_confirmar.TabIndex = 9;
			this.lb_confirmar.Text = "Confirmar:";
			this.lb_confirmar.Click += new System.EventHandler(this.label3_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 222);
			this.Controls.Add(this.lb_confirmar);
			this.Controls.Add(this.tb_confirmar);
			this.Controls.Add(this.btn_criar);
			this.Controls.Add(this.lnk_criarUser);
			this.Controls.Add(this.tb_senha);
			this.Controls.Add(this.tb_usuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_sair);
			this.Controls.Add(this.btn_entrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
		private System.Windows.Forms.LinkLabel lnk_criarUser;
		private System.Windows.Forms.Button btn_criar;
		private System.Windows.Forms.TextBox tb_confirmar;
		private System.Windows.Forms.Label lb_confirmar;
	}
}

