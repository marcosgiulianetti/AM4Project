using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Bookstore
{
    public partial class Informacoes : Form
    {
        // Responsável pela conexão com o banco
        public MySqlConnection connection;
        // Reponsável pelas instruções a serem executadas
        public MySqlCommand command;

        // Variável de imagem
        string imgLocation = " ";

        // Método construtor que mostrar todos os dados do livro selecionado
        public Informacoes(bool admin, string id, Image parameter, string title, string isbn, string publisher, string author, string synopsis, DateTime date)
        {
            InitializeComponent();
            
            // Informa os dados do livro
            picbImage.Image = parameter;
            txtTitle.Text = title;
            txtISBN.Text = isbn;
            txtPublisher.Text = publisher;
            txtAuthor.Text = author;
            txtSynopsis.Text = synopsis;
            dtpDate.Value = date;
            lblID.Text = id;

            // Exibe/esconde as opções de administrador na tela
            if (!admin)
            {
                btnRemoveBook.Visible = false;
                btnEditBook.Visible = false;
                txtSynopsis.ReadOnly = true;
                btnImage.Visible = false;
            }
        }

        // Método para remover o livro selecionado
        public void RemoveBook()
        {
            // Declarando a classe User para manipular os dados do usuário
            int tempID = Convert.ToInt32(lblID.Text);

            try
            {
                // Linha de comando que conecta ao banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Linhas de comando que executa a função de remover os dados do livro selecionado
                MySqlCommand cmd;
                string sqlQuery = "delete from books where idBooks = '" + tempID + "';";
                cmd = new MySqlCommand(sqlQuery, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        // Botão para remover o livro do banco de dados
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja remover este livro?", "Remover livro", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                RemoveBook();
                this.Close();
            }           
        }

        // Botão para mudar as informações do livro selecionado no banco de dados
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Método que realiza a conexão com o banco de dados
                string strCon = @"server=localhost;user id=root;database=bookstore";
                connection = new MySqlConnection(strCon);
                connection.Open();

                // Instancia as variaveis de comando que serão utilizadas nos processos abaixo
                MySqlCommand cmd;
                string sqlQuery;

                // Atribuindo os valores de campo para as variáveis
                string title = txtTitle.Text;
                string isbn = txtISBN.Text;
                string publisher = txtPublisher.Text;
                string author = txtAuthor.Text;
                string synopsis = txtSynopsis.Text;

                // Declara as variaveis que serão utilizadas para manipular os dados de imagem
                DateTime date = dtpDate.Value;
                byte[] images = null;

                // Caso não seja realizada nenhuma alteração na imagem
                if (imgLocation == " ")
                {
                    sqlQuery = "update books set title = @title, date = @date, isbn = @isbn, publisher = @publisher, author = @author, synopsis = @synopsis where idBooks = '" + lblID.Text + "';";
                }
                // Caso seja realizada alguma alteração na imagem
                else
                {
                    // Método para salvar a imagem                  
                    FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);
                    sqlQuery = "update books set image = @images, title = @title, date = @date, isbn = @isbn, publisher = @publisher, author = @author, synopsis = @synopsis where idBooks = '" + lblID.Text + "';";
                }
                // Configurando parâmetros para serem utilizados na query MySql
                cmd = new MySqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new MySqlParameter("@images", images));
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.Parameters.Add(new MySqlParameter("@title", title));
                cmd.Parameters.Add(new MySqlParameter("@isbn", isbn));
                cmd.Parameters.Add(new MySqlParameter("@publisher", publisher));
                cmd.Parameters.Add(new MySqlParameter("@author", author));
                cmd.Parameters.Add(new MySqlParameter("@synopsis", synopsis));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Informações do livro alteradas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados! Detalhes: " + ex);
            }
        }

        // Botão que faz o usuário realizar o upload da imagem
        private void btnImage_Click(object sender, EventArgs e)
        {
            // Abre a tela para o usuário navegar nos diretórios
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Pega o local da imagem
                imgLocation = dialog.FileName.ToString();
                picbImage.ImageLocation = imgLocation;
            }
        }
    }
}
