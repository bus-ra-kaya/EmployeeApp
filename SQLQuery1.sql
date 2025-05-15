CREATE TABLE users (
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(100) NOT NULL,
password VARCHAR(100) NOT NULL,
registerDate DATE NOT NULL
);

Create table employees (
id INT PRIMARY KEY,
full_name VARCHAR(100) NOT NULL,
gender VARCHAR (50) NOT NULL,
phone_number INT NOT NULL,
position VARCHAR(50) NOT NULL,
salary DECIMAL(18,2) NULL,
image VARCHAR(255) NULL,
added_date DATE NOT NULL,
update_date DATE NULL,
branch VARCHAR(50) NOT NULL
);
GO

Select* from employees;
