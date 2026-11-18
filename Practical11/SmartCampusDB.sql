USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'SmartCampusDB')
BEGIN
    CREATE DATABASE SmartCampusDB;
END
GO

USE SmartCampusDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ServiceRequests' AND xtype='U')
BEGIN
    CREATE TABLE ServiceRequests
    (
        RequestId INT IDENTITY(1,1) PRIMARY KEY,
        StudentName NVARCHAR(100) NOT NULL,
        Department NVARCHAR(100) NOT NULL,
        ServiceType NVARCHAR(50) NOT NULL,
        Description NVARCHAR(500) NOT NULL,
        Priority NVARCHAR(20) NOT NULL DEFAULT 'Medium',
        Status NVARCHAR(20) NOT NULL DEFAULT 'Pending',
        RequestDate DATETIME NOT NULL DEFAULT GETDATE()
    );

    INSERT INTO ServiceRequests
    (StudentName, Department, ServiceType, Description, Priority, Status)
    VALUES
    ('Rahul Patel', 'Computer Engineering', 'IT Support', 'Wi-Fi connectivity issue', 'High', 'Pending'),
    ('Priya Shah', 'Computer Engineering', 'Library', 'Request for library access', 'Medium', 'In Progress'),
    ('Amit Mehta', 'Information Technology', 'Maintenance', 'Classroom projector issue', 'Low', 'Completed');
END
GO
