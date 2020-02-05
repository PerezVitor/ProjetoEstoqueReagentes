using ProjetoPOO.Classes;
using System.Windows.Forms;

namespace ProjetoPOO.Formularios
{
    public partial class FrmMenu : Form
    {
        ClsUsuario login = new ClsUsuario();
        public FrmMenu()
        {
            InitializeComponent();
            travarForm();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog(login, this);
        }

        private void travarForm()
        {
            btnUsuarios.Enabled = false;
            btnReagentes.Enabled = false;
            btnRelatorio.Enabled = false;
            btnEmprestimo.Enabled = false;
        }
        public void destravarForm()
        {
            btnUsuarios.Enabled = true;
            btnReagentes.Enabled = true;
            btnRelatorio.Enabled = true;
            btnEmprestimo.Enabled = true;
            txtUsuario.Text = "Usuário logado: " + login.Nome;
        }

        private void btnUsuarios_Click(object sender, System.EventArgs e)
        {
            bool found = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmUsuario)
                {
                    openForm.Focus();
                    found = true;
                }
            }
            if (!found)
            {
                FrmUsuario frmUsuario = new FrmUsuario(login.Nome, login.Tipo);
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            }            
        }

        private void btnReagentes_Click(object sender, System.EventArgs e)
        {
            bool found = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmRegente)
                {
                    openForm.Focus();
                    found = true;
                }
            }
            if (!found)
            {
                FrmRegente frmRegente = new FrmRegente();
                frmRegente.MdiParent = this;
                frmRegente.Show();
            }            
        }

        private void btnEmprestimo_Click(object sender, System.EventArgs e)
        {
            bool found = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmEmprestimo)
                {
                    openForm.Focus();
                    found = true;
                }
            }
            if (!found)
            {
                FrmEmprestimo frmEmprestimo = new FrmEmprestimo(login.ID);
                frmEmprestimo.MdiParent = this;
                frmEmprestimo.Show();
            }            
        }

        private void btnRelatorio_Click(object sender, System.EventArgs e)
        {
            bool found = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmRelatorio)
                {
                    openForm.Focus();
                    found = true;
                }
            }
            if (!found)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio();
                frmRelatorio.MdiParent = this;
                frmRelatorio.Show();
            }            
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog(login, this);
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
