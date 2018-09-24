-- Deletando DATABASE LivrariaHbsis j� existente para criar-se um novo do in�cio
use master;

-- Limpo o cache da inst�ncia do SQL Server para poder deletar o Database LivrariaHbsis caso ele esteja em uso
DBCC FREEPROCCACHE;

-- Deletando as Tabelas do meu Database LivrariaHbsis, caso ele exista, e posteriormente, deleto o Database LivrariaHbsis
if exists(select * from sys.databases where name='LivrariaHbsis') drop table LivrariaHbsis.dbo.EXEMPLARY;
if exists(select * from sys.databases where name='LivrariaHbsis') drop table LivrariaHbsis.dbo.BOOK;
if exists(select * from sys.databases where name='LivrariaHbsis') drop database LivrariaHbsis;

-- Criando o DATABASE LivrariaHbsis
create database LivrariaHbsis;
go
use LivrariaHbsis;
go
create table BOOK
(
	book_id						int primary key identity not null,
	book_title					varchar(200) not null unique,
	book_description			varchar(255) not null,
	book_author					varchar(200) not null,
	book_publishing_company		varchar(200) not null,
	book_price					float not null
);
create table EXEMPLARY
(
	exemplary_id		int primary key identity not null,
	book_id				int references BOOK not null,
	exemplary_count		int default 1
);


-- Inserindo dados na Tabela BOOK para testes do banco de dados
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro Z', 'Descrição do Livro Z', 'Erase', 'Ed. Apagar Livro', 428.75);
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro B', 'Descrição do Livro B', 'Carlos', 'Ed. Engenharia Para Todos', 536.43);
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro E', 'Descrição do Livro E', 'Henrique', 'Ed. Novo Horizonte', 764.67);
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro D', 'Descrição do Livro D', 'Alex', 'Ed. Mundo Globalizado', 68.45);
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro A', 'Descrição do Livro A', 'Eduardo', 'Ed. Computação', 635.34);
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro C', 'Descrição do Livro C', 'Espinoza', 'Ed. Geração XXI', 28.55);

USE [LivrariaHbsis]
GO

INSERT INTO [LivrariaHbsis].[BOOK]
           ([book_title]
           ,[book_description]
           ,[book_author]
           ,[book_publishing_company]
           ,[book_price])
     VALUES
           ('Livro Z'
           ,'Descrição do Livro Z'
           ,'Erase'
           ,'Ed. Apagar Livro'
           ,428.75)
GO




{
	"Book_Title": "Livro Z",
	"Book_Description": "Descricao Z",
	"Book_Author": "Autor Z",
	"Book_Publishing_Company": "Editora Z",
	"Book_Price": "454.4"
}

{
	"Book_Title": "Livro B",
	"Book_Description": "Descrição do Livro B",
	"Book_Author": "Carlos",
	"Book_Publishing_Company": "Ed. Engenharia Para Todos",
	"Book_Price": "536.43"
}

{
	"Book_Title": "Livro C",
	"Book_Description": "Descricao A",
	"Book_Author": "Autor A",
	"Book_Publishing_Company": "Editora A",
	"Book_Price": "452.43"
}

{
	"Book_Title": "Livro A",
	"Book_Description": "Descricao A",
	"Book_Author": "Autor A",
	"Book_Publishing_Company": "Editora A",
	"Book_Price": "452.43"
}

{
	"Book_Title": "Livro A",
	"Book_Description": "Descricao A",
	"Book_Author": "Autor A",
	"Book_Publishing_Company": "Editora A",
	"Book_Price": "452.43"
}

-- Deletando registros - Teste de Query
delete from BOOK where book_id = 1;


-- Inserindo mais um dado na Tabela BOOK
insert into BOOK (book_title, book_description, book_author, book_publishing_company, book_price) values ('Livro F', 'Descri��o do Livro F', 'Junior', 'Ed. Pensadores', 428.75);


-- Inserindo dados na Tabela EXEMPLARY para testes do banco de dados
insert into EXEMPLARY (book_id) values (6);
insert into EXEMPLARY (book_id, exemplary_count) values (2, 2);
insert into EXEMPLARY (book_id) values (3);
insert into EXEMPLARY (book_id, exemplary_count) values (4, 0);
insert into EXEMPLARY (book_id, exemplary_count) values (5, 4);


-- Listando livros ordenados pelo t�tulo
select * from BOOK order by book_title;


-- Atualizando um livro
update BOOK set book_description = 'Descri��o do Livro D editado com update' where book_id = 4;


-- Criando uma Query para listar dados de exibi��o no momento de adicionar exemplares
select b.book_id, b.book_title, e.exemplary_count from BOOK b inner join EXEMPLARY e on b.book_id = e.book_id order by b.book_title;


-- Criando uma Query para listar dados de exibi��o no momento que estiver na Home
select * from BOOK b inner join EXEMPLARY e on b.book_id = e.book_id order by b.book_title;



-- NAO UTILIZADOS

--if exists(select * from sys.databases where name='LivrariaHbsis') drop view vwBookExemplary;


-- Resetando contador do incremento para a gera��o do ID
-- dbcc checkident ('[BOOK]', reseed, 0);

/*-- Criando uma View para listar dados de exibi��o no momento de adicionar exemplares
create view vwBookExemplary as 
	select 
		b.book_id,
		b.book_title,
		e.exemplary_count
	from
		BOOK b inner join EXEMPLARY e
			on b.book_id = e.book_id;*/