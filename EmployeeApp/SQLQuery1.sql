CREATE TABLE users (
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(100) NOT NULL,
password VARCHAR(100) NOT NULL,
registerDate DATE NOT NULL
)

USE employeedb;
GO
Select * from users;

Delete from users where username = 'testing';