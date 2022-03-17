CREATE PROCEDURE [dbo].[InsertArticle]
	@Name VARCHAR (50),
	@Price float,
	@Ean VARCHAR(255),
	@Description VARCHAR(255)
AS
BEGIN
	INSERT INTO Article (Name,Price, Ean, Description) 
	output inserted.Id
	VALUES(@Name, @Price,@Ean,@Description)
END

