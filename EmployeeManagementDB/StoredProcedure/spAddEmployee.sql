CREATE PROCEDURE [dbo].[spAddEmployee]
	@Firstname varchar(50),
    @Lastname varchar(50),
    @City varchar(50),
    @Contact varchar(50),
    @Gender varchar(50)
AS
	BEGIN
INSERT INTO EmployeeSystem(Firstname,Lastname,City,Contact,Gender) 
VALUES (@Firstname, @Lastname,@City,@Contact,@Gender)
END
SELECT * FROM EmployeeSystem
RETURN 0
