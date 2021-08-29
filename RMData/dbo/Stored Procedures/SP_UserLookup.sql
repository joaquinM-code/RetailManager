CREATE PROCEDURE [dbo].[SP_UserLookup]
	@Id nvarchar(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT FirstName, LastName, EmailAddress, CreatedDate 
	FROM [dbo].[User] 
	WHERE AuthUserId = @Id

END;
