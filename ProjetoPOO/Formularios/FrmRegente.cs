using ProjetoPOO.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoPOO.Formularios
{
    public partial class FrmRegente : Form
    {
        ClsReagente reagente = new ClsReagente();
        string operacao = "CADASTRO";
        DataSet dataSet;

        public FrmRegente()
        {
            InitializeComponent();
            carregarDgvDados();
        }

        private void carregarDgvDados()
        {
            reagente.Descricao = txtBusca.Text;
            dataSet = reagente.Consultar();

            if (dataSet == null)
            {
                txtMsg.Text = reagente.erro;
            }
            else
            {
                dgvDados.DataSource = dataSet.Tables[0];
                if (dgvDados.RowCount == 0)
                {
                    txtMsg.Text = "NÃO HÁ REAGENTES CADASTRADOS";
                    dgvDados.DataSource = null;
                }
                else
                {
                    dgvDados.Columns[0].Visible = dgvDados.Columns[2].Visible = false;
                    dgvDados.Columns[3].Visible = dgvDados.Columns[4].Visible = false;
                    dgvDados.Columns[5].Visible = dgvDados.Columns[6].Visible = false;
                    dgvDados.Columns[1].HeaderText = "DESCRIÇÃO";
                    dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDados.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            carregarDgvDados();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (txtDescricao.Text.Trim() == string.Empty || txtCodInterno.Text.Trim() == string.Empty ||
                txtPeso.Text.Trim() == string.Empty)
            {
                txtMsg.Text = "COMPLETE TODOS OS CAMPOS";
            }
            else
            {
                txtMsg.Text = string.Empty;
                if (operacao == "CADASTRO")
                {
                    reagente.Descricao = txtDescricao.Text;
                    reagente.CodigoInterno = txtCodInterno.Text;
                    reagente.NumeroCas = txtNCAS.Text;
                    reagente.QuantidadePeso = double.Parse(txtPeso.Text);
                    reagente.UnidadeMedida = cbUnidadeMedida.Text;
                    reagente.Obs = txtObs.Text;

                    if (reagente.Cadastrar())
                    {
                        LimparCampo();
                        txtMsg.Text = "NOVO REAGENTE CADASTRADO COM SUCESSO";
                    }
                    else
                    {
                        txtMsg.Text = reagente.erro;
                    }

                }
                else if (operacao == "EDIÇÃO")
                {
                    reagente.Descricao = txtDescricao.Text;
                    reagente.CodigoInterno = txtCodInterno.Text;
                    reagente.NumeroCas = txtNCAS.Text;
                    reagente.QuantidadePeso = double.Parse(txtPeso.Text);
                    reagente.UnidadeMedida = cbUnidadeMedida.Text;
                    reagente.Obs = txtObs.Text;

                    if (reagente.Alterar())
                    {
                        LimparCampo();
                        txtMsg.Text = "DADOS ALTERADOS";
                    }
                    else
                    {
                        txtMsg.Text = reagente.erro;
                    }
                }
                else if (operacao == "EXCLUSÃO")
                {
                    if (reagente.Excluir())
                    {
                        LimparCampo();
                        txtMsg.Text = "REAGENTE EXCLUÍDO";
                    }
                    else
                    {
                        txtMsg.Text = reagente.erro;
                    }
                }
                carregarDgvDados();
            }
        }

        public void LimparCampo()
        {
            txtBusca.Text = txtDescricao.Text = txtNCAS.Text = txtMsg.Text = txtObs.Text = txtPeso.Text = txtCodInterno.Text = string.Empty;
            operacao = "CADASTRO";
            pnlExclusao.Visible = false;
            cbUnidadeMedida.Text = "ml";
            txtDescricao.Focus();
            lblOperacao.Text = "Cadastro de Reagentes";
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

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reagente.ID = int.Parse(dgvDados.CurrentRow.Cells[0].Value.ToString());
            reagente.Descricao = txtDescricao.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            reagente.CodigoInterno = txtCodInterno.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            reagente.NumeroCas = txtNCAS.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
            reagente.QuantidadePeso = double.Parse(txtPeso.Text = dgvDados.CurrentRow.Cells[4].Value.ToString());
            reagente.UnidadeMedida = cbUnidadeMedida.Text = dgvDados.CurrentRow.Cells[5].Value.ToString();
            reagente.Obs = txtObs.Text = dgvDados.CurrentRow.Cells[6].Value.ToString();
            pnlExclusao.Visible = true;
            lblOperacao.Text = "EDIÇÃO DE USUÁRIO";
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

        private void cbUnidadeMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
