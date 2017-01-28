IF EXISTS(select * from sys.procedures where name = 'USP_SEL_LIVROS')
BEGIN
	 DROP PROC USP_SEL_LIVROS
END
GO

CREATE PROCEDURE USP_SEL_LIVROS
	 @Id INT = NULL
	,@Nome VARCHAR(100) = NULL
	,@Categoria VARCHAR(100) = NULL
	,@Preco MONEY = NULL
AS
BEGIN
	SELECT
		 Id 
		,Nome
		,Categoria
		,Preco
	FROM 
		TB_LIVROS
	WHERE
		Id = COALESCE(@Id, Id)
	OR
		Nome = COALESCE(@Nome, Nome)
	OR
		Categoria = COALESCE(@Categoria, Categoria)
	OR
		Preco = COALESCE(@Preco, Preco)
END
GO

	