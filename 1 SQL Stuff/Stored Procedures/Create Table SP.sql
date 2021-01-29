CREATE PROCEDURE dbo.CreateTableWith4Columns -- always use schema prefix
    @TABLENAME SYSNAME
AS
BEGIN -- use body wrappers around whole body
  SET NOCOUNT ON; 

  DECLARE @SQL NVARCHAR(MAX);

  SELECT @SQL = 'CREATE TABLE dbo.' + QUOTENAME(@TABLENAME) + '('
    + 'InternId        INT    NOT NULL IDENTITY  PRIMARY KEY,
       FullName        [NVARCHAR](50)  NOT NULL CHECK(FullName NOT LIKE ''%[^A-Z]''),
       PhoneNumber     BIGINT    NOT NULL UNIQUE,
       JoinDate        datetime DEFAULT GETDATE()
       );';

  EXEC sp_executesql @sql;
END
GO