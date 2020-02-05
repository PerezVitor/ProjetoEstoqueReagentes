using ProjetoPOO.Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ProjetoPOO.Formularios
{
    public partial class FrmRelatorio : Form
    {
        ClsEmprestimo emprestimo = new ClsEmprestimo();
        DataSet dataSet;
        public FrmRelatorio()
        {
            InitializeComponent();
            dtpInicio.Value = dtpFim.Value = DateTime.Now.AddDays(-1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet = emprestimo.Relatorio(DateTime.Parse(dtpInicio.Text), DateTime.Parse(dtpFim.Text));
                if (dataSet == null)
                {
                    txtMsg.Text = emprestimo.erro;
                }
                else
                {
                    dgvDados.DataSource = dataSet.Tables[0];
                    if (dgvDados.RowCount == 0)
                    {
                        txtMsg.Text = "NÃO HÁ EMPRÉSTIMOS CADASTRADOS";
                        dgvDados.DataSource = null;
                    }
                    else
                    {
                        txtMsg.Text = string.Empty;
                        dgvDados.Columns[0].Visible = false;
                        dgvDados.Columns[1].Visible = false;
                        dgvDados.Columns[2].HeaderText = "USUÁRIO";
                        dgvDados.Columns[3].HeaderText = "REAGENTE";
                        dgvDados.Columns[4].HeaderText = "PESO RETIRADO";
                        dgvDados.Columns[5].HeaderText = "UNIDADE DE MEDIDA";
                        dgvDados.Columns[6].HeaderText = "DATA";

                        for (int i = 2; i < 7; i++)
                        {
                            dgvDados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvDados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.Message;
            }
        }

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmEmprestimo)
                {
                    openForm.Close();
                }
            }
            int ID_Emprestimo = int.Parse(dgvDados.CurrentRow.Cells[0].Value.ToString());
            int ID_Usuario = int.Parse(dgvDados.CurrentRow.Cells[1].Value.ToString());

            FrmEmprestimo frmEmprestimo = new FrmEmprestimo(ID_Usuario, ID_Emprestimo);
            frmEmprestimo.MdiParent = MdiParent;
            frmEmprestimo.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            if (dgvDados.RowCount == 0)
            {
                MessageBox.Show("Realize a pesquisa previamente");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                        {
                            var document = new iTextSharp.text.Document();
                            var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fileStream);
                            document.Open();

                            var paragraph = new iTextSharp.text.Paragraph("RELATÓRIO DE EMPRÉSTIMOS");
                            paragraph.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                            document.Add(paragraph);

                            paragraph = new iTextSharp.text.Paragraph("DE: " + dtpInicio.Text + " ATÉ: " + dtpFim.Text);
                            paragraph.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                            document.Add(paragraph);

                            paragraph = new iTextSharp.text.Paragraph("\n");
                            document.Add(paragraph);

                            for (int i = 0; i < dgvDados.RowCount; i++)
                            {
                                DateTime data = DateTime.Parse(dgvDados.Rows[i].Cells[6].Value.ToString());
                                
                                paragraph = new iTextSharp.text.Paragraph(dgvDados.Rows[i].Cells[2].Value.ToString() + "         " +
                                                                          dgvDados.Rows[i].Cells[3].Value.ToString() + "         " +
                                                                          dgvDados.Rows[i].Cells[4].Value.ToString() + "         " +
                                                                          dgvDados.Rows[i].Cells[5].Value.ToString() + "         " +
                                                                          data.ToString("d"));
                                paragraph.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                                document.Add(paragraph);
                            }
                            document.Close();
                            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ATENÇÃO");
                    }
                }
            }
        }

        private void dtpInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
