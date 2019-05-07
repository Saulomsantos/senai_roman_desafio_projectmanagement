--DEFINE O BANCO DE DADOS QUE SERÁ UTILIZADO
USE romanbd;

--INSERE NA TABELA TIPOSUSUARIO DOIS TIPOS: ADMINISTRADOR E PROFESSOR
INSERT INTO TIPOSUSUARIO (TIPO_USUARIO)
VALUES					 ('ADMINISTRADOR'),
						 ('PROFESSOR');

--INSERE NA TABELA EQUIPES TRÊS EQUIPES: DESENVOLVIMENTO, REDES E MULTIMIDIA
INSERT INTO EQUIPES (EQUIPE)
VALUES				('DESENVOLVIMENTO'),
					('REDES'),
					('MULTIMÍDIA')

--INSERE NA TABELA DE USUÁRIOS UM USUÁRIO ADMINISTRADOR
INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID)
VALUES				 ('admin', 'admin@admin.com', 'admin12345', 1)

--INSERE NA TABELA DE USUÁRIOS SEIS PROFESSORES
INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID, EQUIPE_ID)
VALUES				 ('Fernando', 'fernando@email.com', '12345', 2, 1),
					 ('Helena', 'helena@email.com', '12345', 2, 1),
					 ('Barbara', 'barbara@email.com', '12345', 2, 1),
					 ('Gabriel', 'Gabriel@email.com', '12345', 2, 1),
					 ('Saulo', 'Saulo@email.com', '12345', 2, 1)

--INSERE NA TABELA DE TEMAS TRÊS TEMAS: HQs, Gestão E Finanças
INSERT INTO TEMAS (TEMA, ATIVO)
VALUES			  ('HQs', 1),
				  ('Gestão', 1),
				  ('Finanças', 0)

--INSERE NA TABELA DE PROJETOS TRÊS PROJETOS: Personagens, Carfel E Finança de mesa
INSERT INTO PROJETOS (NOME, DESCRICAO, TEMA_ID)
VALUES				 ('Personagens', 'Projeto para listar personagens', 1),
					 ('Carfel', 'Projeto para controle de ponto digital', 2),
					 ('Finança de mesa', 'Projeto para gerenciar finanças pessoais', 3)