CREATE TABLE [dbo].[EmployeeSystem]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Firstname] VARCHAR (50) NOT NULL,
	[Lastname] VARCHAR (50) NOT NULL,
	[City] VARCHAR (50) NOT NULL,
	[Contact] VARCHAR (50) NOT NULL,
	[Gender] VARCHAR (50) NOT NULL,
)
