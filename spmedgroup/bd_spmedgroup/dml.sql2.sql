

insert into tipo_usuario (tipo)
values ('administrador'),('medico'),('paciente')

insert into endereco_clinica (endereco,telefone)
values ('alameda barao limeira ,539','1234-5678'),
	   ('rocha miranda ,78' , '8765-4321')

		
insert into especialidades (nome_especialidade) 
values  ('OTORRINOLARINGOLOGISTA'),
		('oftalmologista'),
		('ortopedista')

			
insert into usuario ( email,senha,data_nascimento,telefone,endereco, id_tipo_usuario)
values  ('carlos@gmaiil.com','1234'	,'21/12/1998','76746766','v.paulista',2),
	    ('vitor@gmail.com','5678','29/04/1987','88776554','garulhos',2),
    	('maria@gmail.com','5432','07/08/1984','12344321','diadema'	,3),
		('carla@gmail.com',	'6543'	,'17/08/1974',	'23442355','itaquera',1),
		('bete@gamil.com','4312','22/12/1994','44234324','diadema',3),
		('joao@gmail.com','1344','12/08/1976','32342423','são bernardo',	2),
		('eduardo@gmail.com',	'7654',	'11/08/1987',	'43242425'	,'av.paulista',	3),
		('tiago@gmail.com','3211','03/03/1992','32423443','itapevi',3)

insert into dados_paciente (nome_paciente,rg,cpf,id_usuario)			
values  ('maria','34234354','534543',3),
		('bete','6456534','545656',5),
		('eduardo','7898989','978989',7),
		('tiago','97898978','678788',8)

insert into dados_medico (nome_medico,crm ,id_especialidades,id_usuario)			
values  	('carlos','23381',1,1),
			('vitor','12594',2,2),
			('joao','27427',3,6)

insert into consulta (situacao,descricao,data_consulta,id_dados_medico,id_dados_paciente,id_endereco_clinica)
values
		('agendada','paciente com dor no ouvido','15/02/2020',3,3,2),
		('realizada','paciente com problema de visao','08/11/2019',2,1,1),
		('cancelada','paciente quebrou a perna','11/02/2020',1,2,1)


insert into clinica(cnpj, razao_social, nome_fantasia,horario_abre,horario_fecha,id_consulta,id_endereco_clinica)
values  ('232134','FUNDAÇÃO WALDEMAR BARNSLEY PESSOA','barnsley pessoa','09:00','14:00',2,1),
('43242',' Hospital de Clínicas da Universidade Federal do Triângulo Mineiro','hospital das clinicas','09:00','15:00',1,2)
		


	



