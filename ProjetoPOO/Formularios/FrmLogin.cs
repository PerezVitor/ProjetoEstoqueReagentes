using System;
using System.Windows.Forms;
using ProjetoPOO.Classes;

namespace ProjetoPOO.Formularios
{
    public partial class FrmLogin : Form
    {
        ClsUsuario novoLogin;
        FrmMenu frmMenu;
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        //EVENTO QUE FAZ AUTENTICAÇÃO DO USUARIO PARA EFETUAR O LOGIN
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            novoLogin.Nome = txtLogin.Text;
            novoLogin.Senha = txtPassword.Text;

            if (novoLogin.Autenticar())
            {
                this.Close();
                frmMenu.destravarForm();
            }
            else
            {
                lblErro.Text = "Login ou Senha Incorretos";

                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;

                txtLogin.Focus();
            }
        }

        //SHOWDIALOG PARA RECEBER USUARIO E O FORM MENU PARA RETORNAR O USUÁRIO LOGADO
        internal void ShowDialog(ClsUsuario login, FrmMenu frmMenu)
        {
            this.frmMenu = frmMenu;
            novoLogin = login;
            this.ShowDialog();
        }

        //BLOQUEIO DE LETRAS PARA A SENHA
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if((char)Keys.Enter == e.KeyChar)
            {
                BtnLogar_Click(null, null);
            }
        }
    }
}
