
create table tipo_usuario(
id_tipo_usuario int primary key  identity,
tipo varchar (255) not null unique
);
go 

create table endereco_clinica(
id_endereco_clinica int primary key identity,
endereco varchar (255) not null ,
telefone varchar (50) not null
);
go 
 
create table especialidades (
id_especialidades int primary key identity,
nome_especialidade varchar (255)not null
);
go 

create table usuario (
id_usuario int primary key identity,
email varchar (255) not null,
senha varchar (200)not null,
data_nascimento datetime2 not null,
telefone varchar (255) not null,
endereco varchar(255)  not null,
id_tipo_usuario int foreign key references tipo_usuario (id_tipo_usuario)
);
go 

create table dados_paciente(
id_dados_paciente int primary key identity,
nome_paciente varchar (255) not null,
rg varchar(255)not null unique,
cpf varchar (255)not null unique,
id_usuario int foreign key references usuario (id_usuario)
);
go 

create table dados_medico(
id_dados_medico int primary key identity,
nome_medico varchar (255)not null,
crm varchar (255) not null unique,
id_especialidades int foreign key references especialidades (id_especialidades),
id_usuario int foreign key references usuario (id_usuario)

);
go


create table consulta(
id_consulta int primary key identity,
situacao varchar (255) not null,
descricao varchar (255) ,
data_consulta datetime2 ,
id_dados_medico int foreign key references dados_medico (id_dados_medico),
id_dados_paciente int foreign key references dados_paciente (id_dados_paciente),
id_endereco_clinica int foreign key references endereco_clinica (id_endereco_clinica)
);
go




create table clinica (
id_clinica int primary key identity,
cnpj varchar (255) not null,
razao_social varchar(255) not null,
nome_fantasia varchar(255) not null,
horario_abre time not null,
horario_fecha time not  null,
id_consulta int foreign key references consulta (id_consulta),
id_endereco_clinica int foreign key references endereco_clinica (id_endereco_clinica)
);
go

