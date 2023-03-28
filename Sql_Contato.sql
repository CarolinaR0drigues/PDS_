create database app_contato_bd;
use app_contato_bd;

create table contato
(
id_con int not null auto_increment primary key,
nome_con varchar(100) not null,
data_nasc_con date not null,
sexo_con varchar(30) not null,
email_con varchar(100) not null,
telefone_con varchar(20) not null
);

insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (1, 'Henrie Woolmer', '2022-11-12', 'Female', 'hwoolmer0@oracle.com', '176-607-2598');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (2, 'Catriona Potell', '2022-04-03', 'Female', 'cpotell1@telegraph.co.uk', '696-700-1863');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (3, 'Julee Roddy', '2022-03-24', 'Female', 'jroddy2@gnu.org', '581-740-9624');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (4, 'Randee Konneke', '2023-01-02', 'Female', 'rkonneke3@networksolutions.com', '517-818-1413');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (5, 'Noreen Nicholas', '2022-07-04', 'Female', 'nnicholas4@usda.gov', '398-115-7415');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (6, 'Normand Worshall', '2022-05-14', 'Male', 'nworshall5@bizjournals.com', '923-645-8107');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (7, 'Hi Mulberry', '2022-11-24', 'Male', 'hmulberry6@shinystat.com', '620-743-8355');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (8, 'Donnie Forsyde', '2022-03-19', 'Male', 'dforsyde7@skype.com', '717-582-0944');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (9, 'Anton Finlator', '2022-05-28', 'Male', 'afinlator8@macromedia.com', '573-786-2353');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (10, 'Waylan Fillimore', '2023-02-24', 'Male', 'wfillimore9@cnbc.com', '225-542-6263');

select * from contato;