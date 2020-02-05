using ProjetoPOO.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoPOO.Formularios
{
    public partial class FrmEmprestimo : Form
    {
        ClsEmprestimo emprestimo = new ClsEmprestimo();
        ClsReagente reagente = new ClsReagente();
        ClsUsuario usuario = new ClsUsuario();
        string operacao = "CADASTRO";
        DataSet dataSetReagentes;
        DataSet dataSetEmprestimo;

        public FrmEmprestimo(int ID_Usuario)
        {
            InitializeComponent();
            carregarDgvReagentes();
            carregarDgvDados();
            usuario.ID = ID_Usuario;
        }

        public FrmEmprestimo(int ID_Usuario, int ID_Emprestimo)
        {
            InitializeComponent();
            usuario.ID = ID_Usuario;
            emprestimo.ID = ID_Emprestimo;
            carregaEmprestimoEspecifico();
        }

        private void carregaEmprestimoEspecifico()
        {
            dataSetEmprestimo = emprestimo.ConsultarEspecifico();
            dgvDados.DataSource = dataSetEmprestimo.Tables[0];
            dgvDados.Columns[0].Visible = dgvDados.Columns[1].Visible = false;
            dgvDados.Columns[2].Visible = dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[4].HeaderText = "REAGENTE";
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDados.Columns[5].HeaderText = "DATA";

            dgvDados.CurrentCell = dgvDados.Rows[0].Cells[4];
            emprestimo.ID = int.Parse(dgvDados.CurrentRow.Cells[0].Value.ToString());
            emprestimo.ID_Usuario = int.Parse(dgvDados.CurrentRow.Cells[1].Value.ToString());
            emprestimo.ID_Reagente = int.Parse(dgvDados.CurrentRow.Cells[2].Value.ToString());
            emprestimo.Peso = double.Parse(txtPeso.Text = dgvDados.CurrentRow.Cells[3].Value.ToString());
            consultaReagente(emprestimo.ID_Reagente);

            pnlExclusao.Visible = true;
            lblOperacao.Text = "EDIÇÃO DE EMPRÉSTIMO";
            operacao = "EDIÇÃO";
        }

        private void carregarDgvReagentes()
        {
            reagente.Descricao = txtBusca.Text;
            dataSetReagentes = reagente.Consultar();

            if (dataSetReagentes == null)
            {
                txtMsg.Text = reagente.erro;
            }
            else
            {
                dgvReagentes.DataSource = dataSetReagentes.Tables[0];
                if (dgvReagentes.RowCount == 0)
                {
                    txtMsg.Text = "NÃO HÁ REAGENTES CADASTRADOS";
                    dgvReagentes.DataSource = null;
                }
                else
                {
                    dgvReagentes.Columns[0].Visible = dgvReagentes.Columns[2].Visible = false;
                    dgvReagentes.Columns[3].Visible = dgvReagentes.Columns[6].Visible = false;
                    dgvReagentes.Columns[1].HeaderText = "DESCRIÇÃO";
                    dgvReagentes.Columns[4].HeaderText = "EM ESTOQUE";
                    dgvReagentes.Columns[5].HeaderText = "UN. MEDIDA";
                    dgvReagentes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReagentes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void carregarDgvDados()
        {
            emprestimo.nomeReagente = txtBusca.Text;
            dataSetEmprestimo = emprestimo.Consultar();

            if (dataSetEmprestimo == null)
            {
                txtMsg.Text = emprestimo.erro;
            }
            else
            {
                dgvDados.DataSource = dataSetEmprestimo.Tables[0];
                if (dgvDados.RowCount == 0)
                {
                    txtMsg.Text = "NÃO HÁ EMPRÉSTIMOS CADASTRADOS";
                    dgvDados.DataSource = null;
                }
                else
                {
                    dgvDados.Columns[0].Visible = dgvDados.Columns[1].Visible = false;
                    dgvDados.Columns[2].Visible = dgvDados.Columns[3].Visible = false;
                    dgvDados.Columns[4].HeaderText = "REAGENTE";
                    dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDados.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDados.Columns[5].HeaderText = "DATA";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            carregarDgvDados();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (txtPeso.Text.Trim() == string.Empty || dgvReagentes.CurrentRow == null)
            {
                txtMsg.Text = "COMPLETE O CAMPO PESO E SELECIONE UM REAGENTE";
            }
            else
            {
                txtMsg.Text = string.Empty;
                if (operacao == "CADASTRO")
                {
                    reagente.ID = emprestimo.ID_Reagente = int.Parse(dgvReagentes.CurrentRow.Cells[0].Value.ToString());
                    emprestimo.ID_Usuario = usuario.ID;
                    reagente.QuantidadePeso = emprestimo.Peso = double.Parse(txtPeso.Text);

                    if (emprestimo.Peso > double.Parse(dgvReagentes.CurrentRow.Cells[4].Value.ToString()))
                    {
                        txtMsg.Text = "O PESO A SER RETIRADO NÃO PODE SER MAIOR QUE O DE ESTOQUE";
                    }
                    else if (emprestimo.Peso < 0)
                    {
                        txtMsg.Text = "O VALOR NÃO DEVE SER NEGATIVO";
                    }
                    else
                    {
                        if (emprestimo.Cadastrar())
                        {
                            emprestimo.EmprestimoReagente(reagente);
                            LimparCampo();
                            carregarDgvDados();
                            txtMsg.Text = "NOVO EMPRESTIMO CADASTRADO COM SUCESSO";
                        }
                        else
                        {
                            txtMsg.Text = emprestimo.erro;
                        }
                    }
                }
                else if (operacao == "EDIÇÃO")
                {
                    bool alterar = true;
                    emprestimo.ID_Usuario = usuario.ID;
                    if (emprestimo.ID_Reagente == int.Parse(dgvReagentes.CurrentRow.Cells[0].Value.ToString()))
                    {
                        emprestimo.ID_Reagente = int.Parse(dgvReagentes.CurrentRow.Cells[0].Value.ToString());
                        if (emprestimo.Peso > double.Parse(txtPeso.Text))
                        {
                            if (double.Parse(txtPeso.Text) < 0)
                            {
                                alterar = false;
                                txtMsg.Text = "O VALOR NÃO DEVE SER NEGATIVO";
                                txtPeso.Text = emprestimo.Peso.ToString();
                            }
                            else
                            {
                                reagente.ID = emprestimo.ID_Reagente;
                                reagente.QuantidadePeso = emprestimo.Peso - double.Parse(txtPeso.Text);
                                if (emprestimo.ExclusaoEmprestimo(reagente) == false)
                                {
                                    alterar = false;
                                    txtMsg.Text = emprestimo.erro;
                                }
                            }
                        }
                        else
                        {
                            double emprestimoPeso = double.Parse(txtPeso.Text) - emprestimo.Peso;

                            if (emprestimoPeso > double.Parse(dgvReagentes.CurrentRow.Cells[4].Value.ToString()))
                            {
                                txtMsg.Text = "O PESO A SER RETIRADO NÃO PODE SER MAIOR QUE O DE ESTOQUE";
                                alterar = false;
                                txtPeso.Text = emprestimo.Peso.ToString();
                            }
                            else
                            {
                                reagente.ID = emprestimo.ID_Reagente;
                                reagente.QuantidadePeso = emprestimoPeso;
                                if (emprestimo.EmprestimoReagente(reagente) == false)
                                {
                                    alterar = false;
                                    txtMsg.Text = emprestimo.erro;
                                }
                            }
                        }
                        emprestimo.Peso = double.Parse(txtPeso.Text);
                    }
                    else
                    {
                        reagente.ID = emprestimo.ID_Reagente;
                        reagente.QuantidadePeso = emprestimo.Peso;
                        emprestimo.ExclusaoEmprestimo(reagente);
                        emprestimo.ID_Reagente = int.Parse(dgvReagentes.CurrentRow.Cells[0].Value.ToString());
                        emprestimo.Peso = double.Parse(txtPeso.Text);
                    }
                    if (alterar)
                    {
                        if (emprestimo.Alterar())
                        {
                            LimparCampo();
                            carregarDgvDados();
                            txtMsg.Text = "DADOS ALTERADOS";
                        }
                        else
                        {
                            txtMsg.Text = emprestimo.erro;
                        }
                    }
                }
                else if (operacao == "EXCLUSÃO")
                {
                    reagente.ID = int.Parse(dgvReagentes.CurrentRow.Cells[0].Value.ToString());
                    reagente.QuantidadePeso = int.Parse(txtPeso.Text);
                    if (emprestimo.Excluir())
                    {
                        emprestimo.ExclusaoEmprestimo(reagente);
                        LimparCampo();
                        carregarDgvDados();
                        txtMsg.Text = "EMPRÉSTIMO EXCLUÍDO";
                    }
                    else
                    {
                        txtMsg.Text = emprestimo.erro;
                    }
                }

            }
        }

        private void LimparCampo()
        {
            txtBusca.Text = txtMsg.Text = txtPeso.Text = string.Empty;
            carregarDgvReagentes();
            operacao = "CADASTRO";
            pnlExclusao.Visible = false;
            lblOperacao.Text = "Cadastro de Empréstimos";
            pnlDados.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultaReagente(int ID)
        {
            dataSetReagentes = reagente.Consultar(ID);

            if (dataSetReagentes == null)
            {
                txtMsg.Text = reagente.erro;
            }
            else
            {
                dgvReagentes.DataSource = dataSetReagentes.Tables[0];
                if (dgvReagentes.RowCount == 0)
                {
                    txtMsg.Text = "REAGENTE NÃO ENCONTRADO";
                    dgvReagentes.DataSource = null;
                }
                else
                {
                    dgvReagentes.Columns[0].Visible = dgvReagentes.Columns[2].Visible = false;
                    dgvReagentes.Columns[3].Visible = dgvReagentes.Columns[6].Visible = false;
                    dgvReagentes.Columns[1].HeaderText = "DESCRIÇÃO";
                    dgvReagentes.Columns[4].HeaderText = "EM ESTOQUE";
                    dgvReagentes.Columns[5].HeaderText = "UN. MEDIDA";
                    dgvReagentes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReagentes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            emprestimo.ID = int.Parse(dgvDados.CurrentRow.Cells[0].Value.ToString());
            emprestimo.ID_Usuario = int.Parse(dgvDados.CurrentRow.Cells[1].Value.ToString());
            emprestimo.ID_Reagente = int.Parse(dgvDados.CurrentRow.Cells[2].Value.ToString());
            emprestimo.Peso = double.Parse(txtPeso.Text = dgvDados.CurrentRow.Cells[3].Value.ToString());
            consultaReagente(emprestimo.ID_Reagente);

            pnlExclusao.Visible = true;
            lblOperacao.Text = "EDIÇÃO DE EMPRÉSTIMO";
            operacao = "EDIÇÃO";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = "EXCLUSÃO";
            pnlDados.Enabled = false;
        }

        private void txtFrascos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscaReagente_Click(object sender, EventArgs e)
        {
            carregarDgvReagentes();
        }

        private void btnAtualizarReagente_Click(object sender, EventArgs e)
        {
            carregarDgvReagentes();
        }

        private void dgvReagentes_SelectionChanged(object sender, EventArgs e)
        {
            txtObs.Text = dgvReagentes.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
