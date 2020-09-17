using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Bookstore
{
    public partial class CadastrarLivros : Form
    {
        // Variável que salva o local da imagem
        string imgLocation = " ";

        public CadastrarLivros()
        {
            InitializeComponent();
        }

        // Realiza o cadastro de um novo livro no banco de dados
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Executa o método que vai enviar os parâmetros necessários para o registro de novos livros e os registra no banco de dados
            // Verifica se a PictureBox contém imagem ou não
            if (picbImage.Image != null)
            {
                Books b = new Books();
                b.AddBook(imgLocation, txtTitle.Text, txtISBN.Text, txtPublisher.Text, txtAuthor.Text, txtSynopsis.Text, dtpDate.Value);
                this.Close();
            }
            // Caso a PictureBox não tenha imagem
            else
            {
                MessageBox.Show("Insira a imagem de capa do livro!");
            }
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // Abre o painel do diretório para o usuário selecionar a imagem desejada
            OpenFileDialog dialog = new OpenFileDialog();
            // Fitros de formatos de imagem permitidos
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picbImage.ImageLocation = imgLocation;
            }
        }
    }
}
