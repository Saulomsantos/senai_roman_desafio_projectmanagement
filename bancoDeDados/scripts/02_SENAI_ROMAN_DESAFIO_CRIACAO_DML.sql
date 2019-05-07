--DEFINE O BANCO DE DADOS QUE SER� UTILIZADO
USE romanbd;

--INSERE NA TABELA TIPOSUSUARIO DOIS TIPOS: ADMINISTRADOR E PROFESSOR
INSERT INTO TIPOSUSUARIO (TIPO_USUARIO)
VALUES					 ('ADMINISTRADOR'),
						 ('PROFESSOR');

--INSERE NA TABELA EQUIPES TR�S EQUIPES: DESENVOLVIMENTO, REDES E MULTIMIDIA
INSERT INTO EQUIPES (EQUIPE)
VALUES				('DESENVOLVIMENTO'),
					('REDES'),
					('MULTIM�DIA')

--INSERE NA TABELA DE USU�RIOS UM USU�RIO ADMINISTRADOR
INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID)
VALUES				 ('admin', 'admin@admin.com', 'admin12345', 1)

--INSERE NA TABELA DE USU�RIOS SEIS PROFESSORES
INSERT INTO USUARIOS (NOME, EMAIL, SENHA, TIPOUSUARIO_ID, EQUIPE_ID)
VALUES				 ('Fernando', 'fernando@email.com', '12345', 2, 1),
					 ('Helena', 'helena@email.com', '12345', 2, 1),
					 ('Barbara', 'barbara@email.com', '12345', 2, 1),
					 ('Gabriel', 'Gabriel@email.com', '12345', 2, 1),
					 ('Saulo', 'Saulo@email.com', '12345', 2, 1)

--INSERE NA TABELA DE TEMAS TR�S TEMAS: HQs, Gest�o E Finan�as
INSERT INTO TEMAS (TEMA, ATIVO)
VALUES			  ('HQs', 1),
				  ('Gest�o', 1),
				  ('Finan�as', 0)

--INSERE NA TABELA DE PROJETOS TR�S PROJETOS: Personagens, Carfel E Finan�a de mesa
INSERT INTO PROJETOS (NOME, DESCRICAO, TEMA_ID)
VALUES				 ('Personagens', 'Projeto para listar personagens', 1),
					 ('Carfel', 'Projeto para controle de ponto digital', 2),
					 ('Finan�a de mesa', 'Projeto para gerenciar finan�as pessoais', 3)