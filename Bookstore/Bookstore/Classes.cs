using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.IO;

namespace Bookstore
{
    // Classe usuário, feita para manipular os dados do usuário
    class User
    {
        // Responsável pela conexão com o banco
        public static MySqlConnection connection;
        // Reponsável pelas instruções a serem executadas
        public static MySqlCommand command;

        // Método que adiciona um novo usuário
        public void AddUser(string name, string username, string password)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into users(name, login, password, permission) values ('"+name+"','"+username+"','"+password+"','0');";
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }          
        }

        // Método que valida se o nome de usuário e a senha estão corretos
        public int ValidateUser(string username, string password)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select password from users where login = '" + username + "';";
                string tempPassword = Convert.ToString(command.ExecuteScalar());

                // Caso a senha informada pelo usuário seja igual a senha registrada no banco de dados
                if (tempPassword == password)
                {
                    // Método que lê qual a permissão que o usuário possui no sistema (0 - Usuário comum, 1 - Usuário administrador)
                    command.CommandText = "select permission from users where login = '" + username + "';";
                    int tempPermission = Convert.ToInt32(command.ExecuteScalar());

                    // Caso o usuário tenha permissão de administrador
                    if (tempPermission == 1)
                    {
                        return 2;
                    }
                    // Caso o usuário não tenha permissão de administrador
                    else
                    {
                        return 1;
                    }                   
                }
                // Caso a senha informada pelo usuário seja diferente diferente a senha registrada no banco de dados
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);

                return 0;
            }
        }

        public void ConcedePermission(int id)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update users set permission = '1' where idUsers = '" + id + "';";
                command.ExecuteNonQuery();
                MessageBox.Show("Permissão concedida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        public void RevokePermission(int id)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update users set permission = '0' where idUsers = '" + id + "';";
                command.ExecuteNonQuery();
                MessageBox.Show("Permissão concedida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

    }

    // Classe books, feita para manipular os dados dos livros
    class Books
    {
        // Responsável pela conexão com o banco
        public static MySqlConnection connection;
        // Reponsável pelas instruções a serem executadas
        public static MySqlCommand command;
        // Adapter responsável por inserir dados em uma datatable
        public static MySqlDataAdapter adapter;
        // Responsável por ligar o banco de dados em controles com a propriedade DataSource 
        public static DataTable datTable;

        // Método que adiciona um novo livro ao banco de dados
        public void AddBook(string imgLocation, string title, string isbn, string publisher, string author, string synopsis, DateTime date)
        {
            try
            {              
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                MySqlCommand cmd = new MySqlCommand();
                byte[] images = null;
                string sqlQuery;
                int N;

                // Caso não seja informada alguma imagem
                if (imgLocation != " ")
                {
                    FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);
                    sqlQuery = "insert into books (image, title, isbn, publisher, author, synopsis, date) values (@images,'" + title +
                        "','" + isbn + "','" + publisher + "','" + author + "','" + synopsis + "', @date);";
                    cmd = new MySqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new MySqlParameter("@images", images));
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    N = cmd.ExecuteNonQuery();
                }
                // Caso não seja informado nenhuma imagem
                else
                {
                    sqlQuery = "insert into books (title, isbn, publisher, author, synopsis, date) values ('" + title +
                        "','" + isbn + "','" + publisher + "','" + author + "','" + synopsis + "', @date);";
                    cmd = new MySqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    N = cmd.ExecuteNonQuery();
                }

                MessageBox.Show(N.ToString() + "Livro registrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        // Método que remove um livro do banco de dados
        public void RemoveBook(string title)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "delete from books where title = " + title;
                command.ExecuteNonQuery();
                MessageBox.Show("Remoção realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        // Método que edita os dados de um livro no banco de dados
        public void EditBook(string image, int id, string title, string isbn, string publisher, string author, string synopsis, DateTime date)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Método que insere os dados na tabela 'users' do MySql
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update 'books' set 'image' = " + image + "', 'title' = '"+ title + "', 'isbn' = '" + isbn + "', 'publisher' = '" + publisher + "', 'author' = '" + author + "', 'synopsis' = '" + synopsis + "', 'date' = '" + date + "where 'idBooks' = " + id + ";";
                command.ExecuteNonQuery();
                MessageBox.Show("Informações atualizadas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }
    }
}
