namespace ProjetoPOO.Formularios
{
    partial class FrmUsuario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVisualizarSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlExclusao = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlEditar.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlExclusao.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(295, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 38);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlEditar
            // 
            this.pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditar.Controls.Add(this.pnlDados);
            this.pnlEditar.Controls.Add(this.pnlExclusao);
            this.pnlEditar.Controls.Add(this.txtMsg);
            this.pnlEditar.Location = new System.Drawing.Point(425, 116);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(922, 567);
            this.pnlEditar.TabIndex = 57;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.btnVisualizarSenha);
            this.pnlDados.Controls.Add(this.txtSenha);
            this.pnlDados.Controls.Add(this.txtEmail);
            this.pnlDados.Controls.Add(this.lblOperacao);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.cbTipo);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Location = new System.Drawing.Point(74, 43);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(565, 300);
            this.pnlDados.TabIndex = 52;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(96, 58);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 27);
            this.txtNome.TabIndex = 0;
            // 
            // btnVisualizarSenha
            // 
            this.btnVisualizarSenha.Location = new System.Drawing.Point(430, 121);
            this.btnVisualizarSenha.Name = "btnVisualizarSenha";
            this.btnVisualizarSenha.Size = new System.Drawing.Size(106, 26);
            this.btnVisualizarSenha.TabIndex = 51;
            this.btnVisualizarSenha.Text = "Ver Senha";
            this.btnVisualizarSenha.UseVisualStyleBackColor = true;
            this.btnVisualizarSenha.Click += new System.EventHandler(this.btnVisualizarSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(96, 120);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(328, 27);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(96, 175);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(168, 15);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(168, 21);
            this.lblOperacao.TabIndex = 48;
            this.lblOperacao.Text = "Cadastro de Usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "USUÁRIO",
            "ADMINISTRADOR"});
            this.cbTipo.Location = new System.Drawing.Point(152, 243);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 28);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.Text = "USUÁRIO";
            this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo do Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // pnlExclusao
            // 
            this.pnlExclusao.Controls.Add(this.btnExcluir);
            this.pnlExclusao.Controls.Add(this.label6);
            this.pnlExclusao.Location = new System.Drawing.Point(655, 313);
            this.pnlExclusao.Name = "pnlExclusao";
            this.pnlExclusao.Size = new System.Drawing.Size(240, 113);
            this.pnlExclusao.TabIndex = 50;
            this.pnlExclusao.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(20, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(199, 45);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Usuário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "Para excluir o usuário clique\r\nExcluir e depois em Salvar";
            // 
            // txtMsg
            // 
            this.txtMsg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMsg.Enabled = false;
            this.txtMsg.Location = new System.Drawing.Point(26, 477);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(884, 74);
            this.txtMsg.TabIndex = 7;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPesquisa.Controls.Add(this.dgvDados);
            this.pnlPesquisa.Controls.Add(this.txtBusca);
            this.pnlPesquisa.Controls.Add(this.label1);
            this.pnlPesquisa.Controls.Add(this.btnBuscar);
            this.pnlPesquisa.Location = new System.Drawing.Point(12, 12);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(396, 671);
            this.pnlPesquisa.TabIndex = 59;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(10, 82);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.Size = new System.Drawing.Size(375, 573);
            this.dgvDados.TabIndex = 8;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // txtBusca
            // 
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusca.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(10, 47);
            this.txtBusca.MaxLength = 20;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(375, 29);
            this.txtBusca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Usuário";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(425, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(922, 76);
            this.pnlBotoes.TabIndex = 58;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(811, 17);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 45);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(121, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 45);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(26, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 45);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1360, 705);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.pnlPesquisa);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlExclusao.ResumeLayout(false);
            this.pnlExclusao.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Panel pnlExclusao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVisualizarSenha;
        private System.Windows.Forms.Panel pnlDados;
    }
}