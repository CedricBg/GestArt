CREATE PROCEDURE [dbo].[EditArticle]
	@id int,
	@Name VARCHAR (50),
	@Price float,
	@Ean VARCHAR(255),
	@Description VARCHAR(255)
AS
BEGIN
	Update Article SET Name=@Name,Price=@Price,Ean=@Ean,Description=@Description Where Id=@id
END

