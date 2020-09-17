using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Login : Form
    {
        public Login()
        {
            // Inicializa os componentes do Formulário
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Abre a tela de cadastrar novo usuário
            Cadastrar c = new Cadastrar();
            c.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Declaração da classe usuário
            User u = new User();

            // Criar booleano para reconhecer se é administrador ou não
            bool admin;

            // Caso seja usuário comum
            if (u.ValidateUser(txtLogin.Text, txtPassword.Text) == 1)
            {
                admin = false;
                Principal p = new Principal(admin);
                p.ShowDialog();
            }
            // Caso seja administrador
            if (u.ValidateUser(txtLogin.Text, txtPassword.Text) == 2)
            {
                admin = true;
                Principal p2 = new Principal(admin);
                p2.ShowDialog();
            }
            // Caso o nome ou senha estiverem incorretos
            if(u.ValidateUser(txtLogin.Text, txtPassword.Text) != 1 && u.ValidateUser(txtLogin.Text, txtPassword.Text) != 2)
            {
                MessageBox.Show("Nome de usuário ou senha incorretos!");
            }
        }
    }
}
