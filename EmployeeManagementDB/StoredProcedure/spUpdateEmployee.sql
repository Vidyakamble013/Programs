CREATE PROCEDURE [dbo].[spUpdateEmployee]
	@EmployeeId INTEGER,
    @Firstname varchar(50),
    @Lastname varchar(50),
    @City varchar(50),
    @Contact varchar(50),
    @Gender varchar(50)
AS
	BEGIN
UPDATE EmployeeSystem
SET Firstname = @Firstname,

    Lastname = @Lastname,
	City = @City,
	Contact = @Contact,
	Gender = @Gender
	WHERE EmployeeId = @EmployeeId
END
RETURN 0
