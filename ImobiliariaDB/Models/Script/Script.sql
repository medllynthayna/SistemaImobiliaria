create database dbimovel;

use dbimovel;

CREATE TABLE Imovel(
  idimovel int AUTO_INCREMENT,
  descricao varchar(50)  NULL,
  ds_estado varchar(14) null,
  ds_cidade varchar(50)  NULL,
  ds_bairro varchar(50)  NULL,
  ds_logradouro varchar(100)  NULL,
  nr_endereco varchar(10)  NULL,
  ds_complemento varchar(50)  NULL,
  ds_nome_proprietario varchar(50)  NULL,
  ds_email varchar(30)  NULL,
  nr_cep varchar(15)  NULL,
  nr_telefone varchar(20)  NULL,
  vl_aluguel decimal  NULL,
  PRIMARY KEY (idimovel)
);

INSERT INTO `dbimovel`.`Imovel` (`idimovel`, `descricao`, `ds_estado`, `ds_cidade`, `ds_bairro`,`ds_logradouro`,`nr_endereco`,`ds_complemento`,`ds_nome_proprietario`,`ds_email`,`nr_cep`,`nr_telefone`,`vl_aluguel`) VALUES ('1', "casa", "MG",  "Belo Horzonte","Santo Antonio", "Rua Abre Campo","20","SEM COMPLEMENTO","Lucas","lucas@lucas.com",  "3003-9999",  "32569875", 2.000);
INSERT INTO `dbimovel`.`Imovel` (`idimovel`, `descricao`, `ds_estado`, `ds_cidade`, `ds_bairro`,`ds_logradouro`,`nr_endereco`,`ds_complemento`,`ds_nome_proprietario`,`ds_email`,`nr_cep`,`nr_telefone`,`vl_aluguel`) VALUES ('2', "casa", "MG","Belo Horizonte","São Pedro","Rua Lavras","70","Casa A",  "Igor","igor@igor.com","3332-9999","32569874",  1.500);
INSERT INTO `dbimovel`.`Imovel` (`idimovel`, `descricao`, `ds_estado`, `ds_cidade`, `ds_bairro`,`ds_logradouro`,`nr_endereco`,`ds_complemento`,`ds_nome_proprietario`,`ds_email`,`nr_cep`,`nr_telefone`,`vl_aluguel`) VALUES ('3',"apartamento",  "MG",  "Belo Horizonte", "Cruzeiro",  "Rua Bambuí", "93","SEM COMPLEMENTO",  "Pablo","pablo@pablo.com", "3333-9009",  "32569976", 2.000);
INSERT INTO `dbimovel`.`Imovel` (`idimovel`, `descricao`, `ds_estado`, `ds_cidade`, `ds_bairro`,`ds_logradouro`,`nr_endereco`,`ds_complemento`,`ds_nome_proprietario`,`ds_email`,`nr_cep`,`nr_telefone`,`vl_aluguel`) VALUES ('4',  "SITIO",  "MG","Caeté",  "Cidade Jardim",  "Rua Josafá Belo", "660", "SEM COMPLEMENTO",  "Mariana","MARINA@MARINA.COM", "3333-9999",  "32569875", 2.000);
INSERT INTO `dbimovel`.`Imovel` (`idimovel`, `descricao`, `ds_estado`, `ds_cidade`, `ds_bairro`,`ds_logradouro`,`nr_endereco`,`ds_complemento`,`ds_nome_proprietario`,`ds_email`,`nr_cep`,`nr_telefone`,`vl_aluguel`) VALUES ('5',  "APARTAMENTO", "MG","Belo Horizonte", "SION","Rua Chicago", "83", "BLOCO 2", "MATEUS", "MATEUS@MATEUS.COM",  "3353-7999", "27848888", 2.000);
