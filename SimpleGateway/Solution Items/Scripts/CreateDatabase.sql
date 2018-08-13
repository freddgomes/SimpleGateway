USE master;
GO

-- [SimpleGatewayDb]
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'SimpleGatewayDb') 
BEGIN 
    EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'SimpleGatewayDb' 
    ALTER DATABASE [SimpleGatewayDb] SET SINGLE_USER WITH ROLLBACK IMMEDIATE 
    ALTER DATABASE [SimpleGatewayDb] SET SINGLE_USER 
    DROP DATABASE [SimpleGatewayDb] 
END 
GO

CREATE DATABASE [SimpleGatewayDb];
GO