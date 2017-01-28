IF EXISTS(select * from sys.procedures where name = 'USP_INS_LIVROS')
BEGIN
	 DROP PROC USP_INS_LIVROS
END
GO

CREATE PROCEDURE USP_INS_LIVROS
	 @Id INT = NULL
	,@Nome VARCHAR(100)
	,@Categoria VARCHAR(100)
	,@Preco MONEY
AS
BEGIN
	IF @Id IS NULL
	BEGIN
		INSERT INTO TB_LIVROS
		(
			 Nome
			,Categoria
			,Preco
		)
		SELECT
			 @Nome 
			,@Categoria 
			,@Preco
	END
	ELSE
	BEGIN
		UPDATE TB_LIVROS SET
			 Nome = @Nome
			,Categoria = @Categoria
			,@Preco = Preco
		WHERE
			Id = @Id
	END
END
GO

	