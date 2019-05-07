USE romanbd;

INSERT INTO TIPOSUSUARIO (TIPO_USUARIO)
VALUES					 ('ADMINISTRADOR'),
						 ('PROFESSOR');

INSERT INTO EQUIPES (EQUIPE)
VALUES				('DESENVOLVIMENTO'),
					('REDES'),
					('MULTIMÍDIA')

INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID)
VALUES				 ('admin', 'admin@admin.com', 'admin12345', 1)

INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID, EQUIPE_ID)
VALUES				 ('Fernando', 'fernando@email.com', '12345', 2, 1),
					 ('Helena', 'helena@email.com', '12345', 2, 1),
					 ('Barbara', 'barbara@email.com', '12345', 2, 1),
					 ('Gabriel', 'Gabriel@email.com', '12345', 2, 1),
					 ('Saulo', 'Saulo@email.com', '12345', 2, 1)

INSERT INTO TEMAS (TEMA, ATIVO)
VALUES			  ('HQs', 1),
				  ('Gestão', 1),
				  ('Finanças', 0)

INSERT INTO PROJETOS (NOME, DESCRICAO, TEMA_ID)
VALUES				 ('Personagens', 'Projeto para listar personagens', 1),
					 ('Carfel', 'Projeto para controle de ponto digital', 2),
					 ('Finança de mesa', 'Projeto para gerenciar finanças pessoais', 3)