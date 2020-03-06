select situacao, descricao ,data_consulta,endereco_clinica.endereco, dados_paciente.nome_paciente ,usuario.telefone,
dados_medico.nome_medico ,especialidades.nome_especialidade  from consulta
inner join dados_medico on dados_medico.id_dados_medico = consulta.id_dados_medico
inner join especialidades on especialidades.id_especialidades= dados_medico.id_especialidades
inner join dados_paciente on dados_paciente.id_dados_paciente = consulta.id_dados_paciente
inner join usuario on usuario.id_usuario = dados_paciente.id_usuario
inner join endereco_clinica on endereco_clinica.id_endereco_clinica = consulta.id_endereco_clinica
where id_consulta = 2



select * from clinica
select * from endereco_clinica
select * from consulta
select * from tipo_usuario
