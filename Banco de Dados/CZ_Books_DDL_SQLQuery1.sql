CREATE DATABASE CZ_Books -- Criando o banco de dados do projeto CZ Books

USE CZ_Books -- Define o banco a ser usado

CREATE TABLE TiposUsuarios -- Tabela da entidade TiposUsuarios
(
	IdTipoUsuario	INT PRIMARY KEY IDENTITY,
	TipoUsuario		VARCHAR (100) NOT NULL
);

CREATE TABLE Usuarios -- Tabela da entidade Usuarios
(
	IdUsuario		INT PRIMARY KEY IDENTITY,
	IdTipoUsuario	INT FOREIGN KEY REFERENCES TiposUsuarios (IdTipoUsuario)  -- Chave secundária fazendo referencia a tabela de TiposUsuarios
	,Email			VARCHAR (250) NOT NULL
	,Senha			VARCHAR (250) NOT NULL
);

CREATE TABLE Instituicao -- Tabela da entidade Instituicao
(
	IdInstituicao		INT PRIMARY KEY IDENTITY
	,Instituicao		VARCHAR (250) NOT NULL
);


CREATE TABLE Categoria -- Tabela da entidade Categoria
(
	IdCategoria		INT PRIMARY KEY IDENTITY,
	Categoria		VARCHAR (200) NOT NULL
);

CREATE TABLE Livros --	Tabela da entidade Livros
(
	IdLivro				INT PRIMARY KEY IDENTITY,
	IdInstituicao		INT FOREIGN KEY REFERENCES Instituicao (IdInstituicao),
	IdCategoria			INT FOREIGN KEY REFERENCES Categoria (IdCategoria),
	Titulo				VARCHAR (100) NOT NULL,
	Sinopse				VARCHAR (300) NOT NULL,
	DataPublicacao		DATE NOT NULL,
	Preco				VARCHAR (100) NOT NULL
);

CREATE TABLE Autor -- Tabela da entidade Autor
(
	IdAutor			INT PRIMARY KEY IDENTITY,
	IdUsuario		INT FOREIGN KEY REFERENCES Usuarios (IdUsuario), -- Chave secundária fazendo referencia a tabela de Usuarios
	IdLivro			INT FOREIGN KEY REFERENCES Livros (IdLivro),
	NomeAutor		VARCHAR (100) NOT NULL
);
