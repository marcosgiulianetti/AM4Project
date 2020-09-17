using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bookstore
{
    public partial class EditarUsers : Form
    {
        // Responsável pela conexão com o banco
        public  MySqlConnection connection;
        // Reponsável pelas instruções a serem executadas
        public  MySqlCommand command;
        // Adapter responsável por inserir dados em uma datatable
        public  MySqlDataAdapter adapter;
        // Responsável por ligar o banco de dados em controles com a propriedade DataSource 
        public  DataTable datTable;

        public EditarUsers()
        {
            InitializeComponent();
            
        }

        // Método que é executado quando o formulário é carregado
        private void Permissoes_Load(object sender, EventArgs e)
        {
            // Método que mostra a tabela de usuários cadastrados no sistema
            ShowUsers();
        }

        // Método que mostra a tabela de usuários cadastrados no sistema
        public void ShowUsers()
        {
            // Linha de comando que executa a função de consultar todos os dados da tabela usuários
            string customCommand = "select * from users;";

            // Linha de comando que conecta ao banco de dados
            connection = new MySqlConnection(@"server=localhost;user id=root;database=bookstore");
            command = new MySqlCommand(customCommand, connection);

            try
            {
                // Recebe todos os dados que vem do command MySql
                adapter = new MySqlDataAdapter(command);

                // Coloca os dados do Data Adapter dentro de um grid
                datTable = new DataTable();
                adapter.Fill(datTable);

                // Exibe os dados contidos dentro do DataTable no Data Grid View
                dgvUsers.DataSource = datTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Declarando a classe User para manipular os dados do usuário
            User u = new User();
            int tempID = Convert.ToInt32(txtUserID.Text);

            try
            {
                // Linha de comando que conecta ao banco de dados
                connection = new MySqlConnection(@"server=localhost;user id=root;database=bookstore");
                connection.Open();

                // Linhas de comando que executa a função de consultar os dados da tabela usuários
                command.Connection = connection;
                command.CommandText = "select name from users where idUsers = '" + tempID + "';";
                txtName.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "select login from users where idUsers = '" + tempID + "';";
                txtUsername.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "select password from users where idUsers = '" + tempID + "';";
                txtPassword.Text = Convert.ToString(command.ExecuteScalar());

                // Método que mostra a tabela de usuários cadastrados no sistema
                ShowUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        private void btnNotAdmin_Click(object sender, EventArgs e)
        {
            // Declara a classe usuário e chama o método que revoga as permissões de administrador do usuário
            User u = new User();
            u.RevokePermission(Convert.ToInt32(txtUserID.Text));

            // Método que mostra a tabela de usuários cadastrados no sistema
            ShowUsers();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Declarando a classe 'User' e atribuindo o Id no TextBox para ele
            User u = new User();
            u.ConcedePermission(Convert.ToInt32(txtUserID.Text));

            // Método que mostra a tabela de usuários cadastrados no sistema
            ShowUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Declarando a classe User para manipular os dados do usuário
            User u = new User();
            int tempID = Convert.ToInt32(txtUserID.Text);

            try
            {
                // Linha de comando que conecta ao banco de dados
                connection = new MySqlConnection(@"server=localhost;user id=root;database=bookstore");
                connection.Open();

                // Linhas de comando que executa a função de consultar os dados da tabela usuários e alterar os dados
                command.Connection = connection;
                command.CommandText = "update users set name = '" + txtName.Text + "' where idUsers = '" + tempID + "';";
                txtName.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "update users set login = '" + txtUsername.Text + "' where idUsers = '" + tempID + "';";
                txtUsername.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "update users set password = '" + txtPassword.Text + "' where idUsers = '" + tempID + "';";
                txtPassword.Text = Convert.ToString(command.ExecuteScalar());

                MessageBox.Show("Dados alterados com sucesso!");

                // Método que mostra a tabela de usuários cadastrados no sistema
                ShowUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja remover este usuário?", "Remover usuário", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Declarando a classe User para manipular os dados do usuário
                User u = new User();
                int tempID = Convert.ToInt32(txtUserID.Text);

                try
                {
                    // Linha de comando que conecta ao banco de dados
                    connection = new MySqlConnection(@"server=localhost;user id=root;database=bookstore");
                    connection.Open();

                    // Linhas de comando que executa a função de consultar os dados da tabela usuários
                    command.Connection = connection;
                    command.CommandText = "delete from users where idUsers = '" + tempID + "';";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuário removido com sucesso!");

                    // Método que mostra a tabela de usuários cadastrados no sistema
                    ShowUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
                }
            }           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Declarando o form 'Cadastrar' e exibindo ao usuário
            Cadastrar c = new Cadastrar();
            c.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Método que mostra a tabela de usuários cadastrados no sistema
            ShowUsers();
        }
    }
}
