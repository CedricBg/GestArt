CREATE PROCEDURE [dbo].[AllArticles]
	@Name VARCHAR(50)
AS
	SELECT * from Article where Name=@Name
RETURN 0
