namespace ProjetoPOO.Formularios
{
    partial class FrmMenu
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
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReagentes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.msBottom = new System.Windows.Forms.MenuStrip();
            this.txtUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.msTop.SuspendLayout();
            this.msBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnReagentes,
            this.btnEmprestimo,
            this.btnRelatorio,
            this.btnSair,
            this.btnLogin});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msTop.Size = new System.Drawing.Size(725, 29);
            this.msTop.TabIndex = 13;
            this.msTop.Text = "MenuStrip";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(84, 25);
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReagentes
            // 
            this.btnReagentes.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReagentes.Name = "btnReagentes";
            this.btnReagentes.Size = new System.Drawing.Size(99, 25);
            this.btnReagentes.Text = "Reagentes";
            this.btnReagentes.Click += new System.EventHandler(this.btnReagentes_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(117, 25);
            this.btnEmprestimo.Text = "Empréstimos";
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(89, 25);
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 25);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogin.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(63, 25);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(642, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 30);
            this.lblUsuario.TabIndex = 14;
            // 
            // msBottom
            // 
            this.msBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msBottom.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUsuario});
            this.msBottom.Location = new System.Drawing.Point(0, 424);
            this.msBottom.Name = "msBottom";
            this.msBottom.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msBottom.Size = new System.Drawing.Size(725, 29);
            this.msBottom.TabIndex = 12;
            this.msBottom.Text = "MenuStrip";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 25);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 453);
            this.Controls.Add(this.msTop);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.msBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.msBottom.ResumeLayout(false);
            this.msBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnReagentes;
        private System.Windows.Forms.ToolStripMenuItem btnEmprestimo;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorio;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip msBottom;
        private System.Windows.Forms.ToolStripTextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnLogin;
    }
}



