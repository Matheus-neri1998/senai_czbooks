USE CZ_Books

INSERT INTO TiposUsuarios (TipoUsuario)
VALUES					  ('Administrador')
						 ,('Autor')
						 ,('Cliente');

INSERT INTO Usuarios (IdTipoUsuario, Email, Senha)
VALUES				 (3, 'mthneri@gmail.com', 'mth@132')
					,(3, 'sergio@gmail.com', 'sergio@132')
					,(3, 'maria@gmail.com', 'maria@132')
					,(2, 'Gorwell@gmail.com', 'gorwell@132')
					,(2, 'Rdomingos@gmail.com', 'rdomingos@132')
					,(2, 'PedroBandeira@gmail.com', 'pedrobandeira@132')
					,(1, 'Sauloadm@gmail.com', 'adm@132');

INSERT INTO Instituicao (Instituicao)
VALUES                  ('Biblioteca Pública Ricardo Ramos'),
						('Biblioteca Affonso Taunay'),
						('Biblioteca Publica Cassiano Ricardo');

INSERT INTO Categoria (Categoria)
VALUES				  ('Ficção'),
					  ('Financeiro'),
					  ('Terror');

INSERT INTO Livros (IdInstituicao, IdCategoria, Titulo, Sinopse, DataPublicacao, Preco)
VALUES			   (1, 1, '1984', 'O livro narra a história de Winston Smith, homem de meia idade e membro do Partido Externo', '08/06/1949', '25,90'),
			       (2, 2, 'Sabedoria financeira', 'Em Sabedoria financeira, Reinaldo pontua os conceitos expostos no best-seller Terapia financeira com lições extraídos da Bíblia e de personagens bíblicos', '24/01/1949', '23,92'),
				   (3, 3, 'Anjo da morte', 'O professor de teatro de Calu, de origem judaica, é assassinado pouco antes da estreia de sua nova peça. A única pista é um ameaçador folheto neonazista', '24/01/1949', '18,49');

INSERT INTO Autor(IdUsuario, IdLivro, NomeAutor)
VALUES            (1, 1, 'George Orwell'),
				  (2, 2, 'Reinaldo Domingos'),
				   (3, 3, 'Pedro Bandeira');