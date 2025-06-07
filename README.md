# PrimeiraApp
Um aplicativo web ASP.NET Core MVC para gerenciamento de alunos, utilizando Entity Framework Core para persistência de dados.

##  Sobre o Projeto
Este projeto demonstra uma aplicação web simples desenvolvida com ASP.NET Core MVC, focada no CRUD (Criar, Ler, Atualizar, Deletar) de informações de alunos. Ele utiliza Entity Framework Core para interagir com o banco de dados, facilitando a manipulação dos dados de forma orientada a objetos.

## Estrutura do Projeto
* Controllers: Contém as classes controladoras que lidam com as requisições HTTP e a lógica da aplicação.
* Data: Contém o AppDbContext, a classe de contexto do Entity Framework Core que mapeia seus modelos para o banco de dados.
* Migrations: Armazena as migrações do Entity Framework Core, que são arquivos de código que representam as alterações no esquema do banco de dados.
* Models: Define as classes de modelo (entidades) que representam os dados da sua aplicação (ex: Aluno).
* Properties: Contém arquivos de configuração do projeto.
* ViewComponents: Componentes reutilizáveis para a lógica de UI.
* Views: Contém os arquivos Razor (HTML com C#) que definem a interface do usuário da aplicação.
* wwwroot: Armazena arquivos estáticos como CSS, JavaScript e imagens.
* PrimeiraApp.csproj: O arquivo de projeto C# do seu aplicativo.
* Program.cs: O ponto de entrada da aplicação, onde a aplicação é configurada e iniciada.
* appsettings.json: Arquivo de configuração principal da aplicação.
* appsettings.Development.json: Arquivo de configuração específico para o ambiente de desenvolvimento.

## Funcionalidades
* Listagem de Alunos (Index).
* Criação de novos Alunos (Create).
* Visualização de detalhes de um Aluno (Details).
* Edição de informações de um Aluno (Edit).
 
##  Tecnologias Utilizadas
* ASP.NET Core MVC: Framework para construção de aplicações web.
* Entity Framework Core: ORM (Object-Relational Mapper) para interagir com bancos de dados.
* SQL Server LocalDB: Banco de dados leve e ideal para desenvolvimento.
* Bootstrap: Para estilização e responsividade da interface.
* C#: Linguagem de programação principal.



##  Pré-requisitos
* .NET SDK (versão compatível com a sua versão do ASP.NET Core utilizada no projeto).
* Visual Studio (recomendado) ou Visual Studio Code com as extensões C#.
* SQL Server LocalDB (geralmente instalado com o Visual Studio).

## Exemplo de appsettings.json (ou appsettings.Development.json):

![image](https://github.com/user-attachments/assets/73f6a3c2-cc83-4663-9103-99d3c7b7af86)


Importante: Note que o nome da instância padrão do LocalDB é mssqllocaldb, não msqllocadb.

## Aplicar Migrações do Banco de Dados:
As migrações do Entity Framework Core são essenciais para criar e atualizar seu esquema de banco de dados. 
No Package Manager Console do Visual Studio (ou via CLI dotnet ef no terminal na pasta do projeto PrimeiraApp.csproj), execute:
* Add-Migration Aluno
* Update-Database
 
