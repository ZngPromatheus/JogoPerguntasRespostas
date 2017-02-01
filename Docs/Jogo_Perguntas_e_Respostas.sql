create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Jogador

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas(
    id int identity primary key,
    pergunta varchar(max),
    resposta_correta varchar(max),
    id_jogador int,
    data    datetime default getdate()
    )
    
select * from tb_Perguntas

inset into tb_Perguntas(pergunta, resposta_correta)
values ('Quanto é 2 + 2?','4')

select * from tb_Jogador 

delete from tb_Jogador where id = 11

insert into tb_Jogador(nome) values('Ramon')

--Limpa os dados da tabela e reinicia o campo identily
truncate table tb_Jogador

alter table tb_jogador add id_jogador int