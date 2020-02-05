namespace ProjetoPOO.Formularios
{
    partial class FrmRegente
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodInterno = new System.Windows.Forms.TextBox();
            this.txtNCAS = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlExclusao = new System.Windows.Forms.Panel();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.pnlExclusao.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.txtObs);
            this.pnlDados.Controls.Add(this.txtPeso);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.txtDescricao);
            this.pnlDados.Controls.Add(this.txtCodInterno);
            this.pnlDados.Controls.Add(this.txtNCAS);
            this.pnlDados.Controls.Add(this.lblOperacao);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.cbUnidadeMedida);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Location = new System.Drawing.Point(74, 43);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(565, 409);
            this.pnlDados.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(24, 320);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(521, 62);
            this.txtObs.TabIndex = 56;
            // 
            // txtPeso
            // 
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeso.Location = new System.Drawing.Point(115, 193);
            this.txtPeso.MaxLength = 12;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(124, 27);
            this.txtPeso.TabIndex = 53;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrascos_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Qnt. Peso";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(115, 72);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(328, 27);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtCodInterno
            // 
            this.txtCodInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodInterno.Location = new System.Drawing.Point(115, 112);
            this.txtCodInterno.MaxLength = 10;
            this.txtCodInterno.Name = "txtCodInterno";
            this.txtCodInterno.Size = new System.Drawing.Size(112, 27);
            this.txtCodInterno.TabIndex = 1;
            // 
            // txtNCAS
            // 
            this.txtNCAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNCAS.Location = new System.Drawing.Point(115, 152);
            this.txtNCAS.MaxLength = 15;
            this.txtNCAS.Name = "txtNCAS";
            this.txtNCAS.Size = new System.Drawing.Size(195, 27);
            this.txtNCAS.TabIndex = 2;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(168, 15);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(183, 21);
            this.lblOperacao.TabIndex = 48;
            this.lblOperacao.Text = "Cadastro de Reagentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº CAS";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "ML",
            "G"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(172, 226);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(42, 28);
            this.cbUnidadeMedida.TabIndex = 3;
            this.cbUnidadeMedida.Text = "ML";
            this.cbUnidadeMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUnidadeMedida_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unidade de Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cód. Interno";
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
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(423, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(922, 76);
            this.pnlBotoes.TabIndex = 61;
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
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Reagente";
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
            this.pnlPesquisa.TabIndex = 63;
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
            this.txtMsg.Location = new System.Drawing.Point(26, 480);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(884, 71);
            this.txtMsg.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(20, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(199, 45);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Reagente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "Para excluir o reagente clique\r\nExcluir e depois em Salvar";
            // 
            // pnlExclusao
            // 
            this.pnlExclusao.Controls.Add(this.btnExcluir);
            this.pnlExclusao.Controls.Add(this.label6);
            this.pnlExclusao.Location = new System.Drawing.Point(670, 230);
            this.pnlExclusao.Name = "pnlExclusao";
            this.pnlExclusao.Size = new System.Drawing.Size(240, 113);
            this.pnlExclusao.TabIndex = 50;
            this.pnlExclusao.Visible = false;
            // 
            // pnlEditar
            // 
            this.pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditar.Controls.Add(this.pnlDados);
            this.pnlEditar.Controls.Add(this.pnlExclusao);
            this.pnlEditar.Controls.Add(this.txtMsg);
            this.pnlEditar.Location = new System.Drawing.Point(423, 114);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(922, 567);
            this.pnlEditar.TabIndex = 60;
            // 
            // FrmRegente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 705);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlEditar);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegente";
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlExclusao.ResumeLayout(false);
            this.pnlExclusao.PerformLayout();
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodInterno;
        private System.Windows.Forms.TextBox txtNCAS;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlExclusao;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObs;
    }
}