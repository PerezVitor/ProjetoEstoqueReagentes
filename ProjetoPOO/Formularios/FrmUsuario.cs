using ProjetoPOO.Classes;
using System.Data;
using System.Windows.Forms;

namespace ProjetoPOO.Formularios
{
    public partial class FrmUsuario : Form
    {
        string operacao = "CADASTRO";
        ClsUsuario usuario = new ClsUsuario();
        DataSet dataSet;
        ClsUsuario logado = new ClsUsuario();

        public FrmUsuario(string nome, char tipo)
        {
            InitializeComponent();
            if(tipo == 'U')
            {
                logado.Tipo = tipo;
                txtBusca.Text = nome;
                txtBusca.Enabled = false;
                cbTipo.Enabled = false;
                btnLimpar.Enabled = false;
                txtMsg.Text = "VOCÊ SOMENTE PODE ALTERAR SEUS DADOS";
            }
            carregarDgvDados();
        }

        private void carregarDgvDados()
        {
            usuario.Nome = txtBusca.Text;
            dataSet = usuario.Consultar();

            if (dataSet == null)
            {
                txtMsg.Text = usuario.erro;
            }
            else
            {
                dgvDados.DataSource = dataSet.Tables[0];
                if (dgvDados.RowCount == 0)
                {
                    txtMsg.Text = "NÃO HÁ USUÁRIOS CADASTRADOS";
                    dgvDados.DataSource = null;
                }
                else
                {
                    dgvDados.Columns[0].Visible = false;
                    dgvDados.Columns[2].Visible = false;
                    dgvDados.Columns[3].Visible = false;
                    dgvDados.Columns[1].HeaderText = "NOME DO USUÁRIO";
                    dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDados.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDados.Columns[4].HeaderText = "TIPO";
                    dgvDados.Columns[4].Width = 50;
                }
            }
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            carregarDgvDados();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (logado.Tipo == 'U' && operacao == "CADASTRO")
            {
                LimparCampo();
                txtMsg.Text = "VOCÊ NÃO PODE CADASTRAR NOVOS USUÁRIOS";                
            }
            else
            {
                if (txtNome.Text.Trim() == string.Empty || txtSenha.Text.Trim() == string.Empty ||
                    txtEmail.Text.Trim() == string.Empty)
                {
                    txtMsg.Text = "COMPLETE TODOS OS CAMPOS";
                }
                else
                {
                    txtMsg.Text = string.Empty;
                    if (operacao == "CADASTRO")
                    {
                        usuario.Nome = txtNome.Text;
                        usuario.Senha = txtSenha.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.Tipo = 'A';
                        if (cbTipo.Text == "USUÁRIO")
                        {
                            usuario.Tipo = 'U';
                        }

                        if (usuario.Cadastrar())
                        {
                            LimparCampo();
                            txtMsg.Text = "NOVO USUÁRIO CADASTRADO COM SUCESSO";
                        }
                        else
                        {
                            txtMsg.Text = usuario.erro;
                        }
                    }
                    else if (operacao == "EDIÇÃO")
                    {
                        usuario.Nome = txtNome.Text;
                        usuario.Senha = txtSenha.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.Tipo = 'A';
                        if (cbTipo.Text == "USUÁRIO")
                        {
                            usuario.Tipo = 'U';
                        }

                        if (usuario.Alterar())
                        {
                            LimparCampo();
                            txtMsg.Text = "DADOS ALTERADOS";
                        }
                        else
                        {
                            txtMsg.Text = usuario.erro;
                        }
                    }
                    else if (operacao == "EXCLUSÃO")
                    {
                        if (usuario.Excluir())
                        {
                            LimparCampo();
                            txtMsg.Text = "USUÁRIO EXCLUÍDO";
                        }
                        else
                        {
                            txtMsg.Text = usuario.erro;
                        }
                    }
                    carregarDgvDados();
                }
            }
        }

        public void LimparCampo()
        {
            txtEmail.Text = txtMsg.Text = txtNome.Text = txtSenha.Text = string.Empty;
            operacao = "CADASTRO";
            pnlExclusao.Visible = false;
            cbTipo.Text = "USUÁRIO";
            txtNome.Focus();
            lblOperacao.Text = "Cadastro de Usuários";
            pnlDados.Enabled = true;
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            LimparCampo();
        }

        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.ID = int.Parse(dgvDados.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = txtNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            usuario.Senha = txtSenha.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            usuario.Email = txtEmail.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
            usuario.Tipo = char.Parse(dgvDados.CurrentRow.Cells[4].Value.ToString());
            if (usuario.Tipo == 'U')
            {
               cbTipo.Text = "USUÁRIO";
            }
            else
            {
                cbTipo.Text = "ADMINISTRADOR";
            }             

            if(logado.Tipo != 'U')
            {
                pnlExclusao.Visible = true;
            }
            lblOperacao.Text = "EDIÇÃO DE USUÁRIO";
            operacao = "EDIÇÃO";
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            operacao = "EXCLUSÃO";
            pnlDados.Enabled = false;
        }

        private void btnVisualizarSenha_Click(object sender, System.EventArgs e)
        {
            if(btnVisualizarSenha.Text == "Ver Senha")
            {
                txtSenha.UseSystemPasswordChar = false;
                btnVisualizarSenha.Text = "Esconder";
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnVisualizarSenha.Text = "Ver Senha";
            }          
        }

        private void cbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
