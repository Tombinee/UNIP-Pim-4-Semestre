
CREATE TABLE funcionario(
CPF varchar(20) primary key,
Nome varchar(100) NOT NULL,
Endereço varchar(100) NOT NULL,
Bairro varchar(50) NOT NULL,
CEP varchar(50) NOT NULL,
Telefone varchar(50) NOT NULL,
Cidade varchar(50) NOT NULL,
UF char(2) NOT NULL
); 


CREATE TABLE dadostrabalhista(
Id int identity primary key,
Cargo varchar(50) NOT NULL,
Salariobase float NOT NULL,
Horasdetrabalho int NOT NULL,
Insalubridade varchar(5), 
Pis varchar(20) NOT NULL, 
Periculosidade bit NOT NULL, 
Dataadmissao varchar(20) NOT NULL, 
Datademissao varchar(20) NOT NULl,
CpfFunc varchar(20) foreign key references funcionario(CPF) on delete cascade
);


CREATE TABLE usuario(
id int identity primary key,
usuario varchar(50) NOT NULL,
senha varchar(20) NOT NULL
);



