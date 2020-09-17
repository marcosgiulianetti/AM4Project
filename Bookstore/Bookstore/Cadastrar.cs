using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        // Realiza o cadastro de um novo usuário comum no banco de dados
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Checa se todos os campos foram preenchidos
            if ((!string.IsNullOrWhiteSpace(txtName.Text)) && (!string.IsNullOrWhiteSpace(txtLogin.Text)) && (!string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                User u = new User();
                u.AddUser(txtName.Text, txtLogin.Text, txtPassword.Text);
                this.Close();
            }
            // Caso um dos campos não sejam preenchidos cai no else
            else{
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
