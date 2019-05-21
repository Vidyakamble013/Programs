CREATE PROCEDURE [dbo].[spDeleteEmployee]
	@EmployeeId INT
AS
	BEGIN
DELETE FROM EmployeeSystem WHERE EmployeeId = @EmployeeId
END
RETURN 0

