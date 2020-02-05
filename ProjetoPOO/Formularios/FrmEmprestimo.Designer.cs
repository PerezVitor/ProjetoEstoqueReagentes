namespace ProjetoPOO.Formularios
{
    partial class FrmEmprestimo
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.btnAtualizarReagente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaReagente = new System.Windows.Forms.Button();
            this.txtBuscaReagente = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReagentes = new System.Windows.Forms.DataGridView();
            this.pnlExclusao = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnlEditar.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReagentes)).BeginInit();
            this.pnlExclusao.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
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
            // pnlPesquisa
            // 
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPesquisa.Controls.Add(this.dgvDados);
            this.pnlPesquisa.Controls.Add(this.txtBusca);
            this.pnlPesquisa.Controls.Add(this.label1);
            this.pnlPesquisa.Controls.Add(this.btnBuscar);
            this.pnlPesquisa.Location = new System.Drawing.Point(10, 10);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(396, 671);
            this.pnlPesquisa.TabIndex = 66;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Reagente Emprestado";
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
            // txtMsg
            // 
            this.txtMsg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMsg.Enabled = false;
            this.txtMsg.Location = new System.Drawing.Point(26, 487);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(884, 64);
            this.txtMsg.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(20, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(199, 45);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Empréstimo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(277, 12);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(201, 21);
            this.lblOperacao.TabIndex = 48;
            this.lblOperacao.Text = "Cadastro de Emprestimos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "Para excluir o empréstimo clique\r\nExcluir e depois em Salvar";
            // 
            // pnlEditar
            // 
            this.pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditar.Controls.Add(this.label4);
            this.pnlEditar.Controls.Add(this.txtObs);
            this.pnlEditar.Controls.Add(this.pnlDados);
            this.pnlEditar.Controls.Add(this.pnlExclusao);
            this.pnlEditar.Controls.Add(this.txtMsg);
            this.pnlEditar.Location = new System.Drawing.Point(423, 114);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(922, 567);
            this.pnlEditar.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(102, 393);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(408, 88);
            this.txtObs.TabIndex = 53;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnAtualizarReagente);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.btnBuscaReagente);
            this.pnlDados.Controls.Add(this.txtBuscaReagente);
            this.pnlDados.Controls.Add(this.txtPeso);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.dgvReagentes);
            this.pnlDados.Controls.Add(this.lblOperacao);
            this.pnlDados.Location = new System.Drawing.Point(80, 19);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(772, 343);
            this.pnlDados.TabIndex = 52;
            // 
            // btnAtualizarReagente
            // 
            this.btnAtualizarReagente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarReagente.Location = new System.Drawing.Point(448, 70);
            this.btnAtualizarReagente.Name = "btnAtualizarReagente";
            this.btnAtualizarReagente.Size = new System.Drawing.Size(87, 29);
            this.btnAtualizarReagente.TabIndex = 64;
            this.btnAtualizarReagente.Text = "Atualizar";
            this.btnAtualizarReagente.UseVisualStyleBackColor = true;
            this.btnAtualizarReagente.Click += new System.EventHandler(this.btnAtualizarReagente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nome do Reagente";
            // 
            // btnBuscaReagente
            // 
            this.btnBuscaReagente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaReagente.Location = new System.Drawing.Point(231, 71);
            this.btnBuscaReagente.Name = "btnBuscaReagente";
            this.btnBuscaReagente.Size = new System.Drawing.Size(80, 29);
            this.btnBuscaReagente.TabIndex = 63;
            this.btnBuscaReagente.Text = "Buscar";
            this.btnBuscaReagente.UseVisualStyleBackColor = true;
            this.btnBuscaReagente.Click += new System.EventHandler(this.btnBuscaReagente_Click);
            // 
            // txtBuscaReagente
            // 
            this.txtBuscaReagente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaReagente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaReagente.Location = new System.Drawing.Point(32, 71);
            this.txtBuscaReagente.MaxLength = 20;
            this.txtBuscaReagente.Name = "txtBuscaReagente";
            this.txtBuscaReagente.Size = new System.Drawing.Size(193, 29);
            this.txtBuscaReagente.TabIndex = 62;
            // 
            // txtPeso
            // 
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeso.Location = new System.Drawing.Point(603, 203);
            this.txtPeso.MaxLength = 12;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(124, 27);
            this.txtPeso.TabIndex = 60;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrascos_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Qnt. Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Dados do Emprestimo";
            // 
            // dgvReagentes
            // 
            this.dgvReagentes.AllowUserToAddRows = false;
            this.dgvReagentes.AllowUserToDeleteRows = false;
            this.dgvReagentes.AllowUserToResizeColumns = false;
            this.dgvReagentes.AllowUserToResizeRows = false;
            this.dgvReagentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvReagentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReagentes.Location = new System.Drawing.Point(32, 106);
            this.dgvReagentes.MultiSelect = false;
            this.dgvReagentes.Name = "dgvReagentes";
            this.dgvReagentes.ReadOnly = true;
            this.dgvReagentes.RowHeadersVisible = false;
            this.dgvReagentes.Size = new System.Drawing.Size(503, 198);
            this.dgvReagentes.TabIndex = 48;
            this.dgvReagentes.SelectionChanged += new System.EventHandler(this.dgvReagentes_SelectionChanged);
            // 
            // pnlExclusao
            // 
            this.pnlExclusao.Controls.Add(this.btnExcluir);
            this.pnlExclusao.Controls.Add(this.label6);
            this.pnlExclusao.Location = new System.Drawing.Point(612, 368);
            this.pnlExclusao.Name = "pnlExclusao";
            this.pnlExclusao.Size = new System.Drawing.Size(240, 113);
            this.pnlExclusao.TabIndex = 50;
            this.pnlExclusao.Visible = false;
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
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(423, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(922, 76);
            this.pnlBotoes.TabIndex = 65;
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
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 705);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.pnlBotoes);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmprestimo";
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReagentes)).EndInit();
            this.pnlExclusao.ResumeLayout(false);
            this.pnlExclusao.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlExclusao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvReagentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaReagente;
        private System.Windows.Forms.TextBox txtBuscaReagente;
        private System.Windows.Forms.Button btnAtualizarReagente;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label4;
    }
}