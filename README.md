# AM4Project
Development of requested CRUD

! IMPORTANTE !

**** O código para criar o banco de dados MySql e alimenta-lo, está disponível no arquivo BookstoreData.sql

**** O caminho para conexão no banco esta com as seguintes configurações:
server = localhost
user id = root
database = bookstore

**** O usuário de administrador é:
Login: admin
Senha: admin

** Para acessar as informações específicas do livro basta clicar em um dos elementos do DataGridView na tela 'Principal'

** Para filtrar de 'A-Z' e 'Z-A' basta clicar no header (primeira linha da tabela) do DataGridView

****  Usuários comuns (permission '0') tem a permissão de:
-> Consultar livros no banco de dados
-> Realizar pesquisa por filtro

****  Administradores (permission '1') tem a permissão de:
-> Cadastrar novos usuários
-> Excluir usuários
-> Editar dados dos usuários
-> Cadastrar novos livros
-> Excluir livros
-> Editar dados dos livros
-> Realizar pesquisa por filtro 

** Na pasta 'Imagens para cadastrar novos livros' está com imagens de capas de livros para realizar o cadastro de novos livros.

** O programa aceita imagens .png e .jpg, antes de realizar o upload de uma imagem, verifique se está selecionado a opção de All Files(*.*)
