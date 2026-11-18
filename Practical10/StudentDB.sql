USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'StudentAPI')
BEGIN
    CREATE DATABASE StudentAPI;
END
GO

USE StudentAPI;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Students' AND xtype='U')
BEGIN
    CREATE TABLE Students (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100) NOT NULL,
        Course NVARCHAR(100) NOT NULL
    );

    INSERT INTO Students (Name, Email, Course) VALUES
    ('Aarav Shah', 'aarav.shah@example.com', 'Computer Engineering'),
    ('Diya Patel', 'diya.patel@example.com', 'Information Technology'),
    ('Rohan Joshi', 'rohan.joshi@example.com', 'Data Science');
END
GO
