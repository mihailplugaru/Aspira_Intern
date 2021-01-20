CREATE PROCEDURE dbo.InsertTenRows -- always use schema prefix
    @TABLENAME SYSNAME
AS
BEGIN
  SET NOCOUNT ON; 
  DECLARE @SQL NVARCHAR(MAX); -- dynamic SQL should always be Unicode

  SELECT @SQL = 'INSERT INTO dbo.' + QUOTENAME(@TABLENAME) + '
                 ([FullName],[PhoneNumber])
				 VALUES
				 (''Albert Einstein''  , 121212123),
     		     (''Marie Curie''      , 131313134),
				 (''Isaac Newton''     , 141414145),
				 (''Charles Darwin''   , 151515156),
				 (''Nikola Tesla''     , 161616167),
				 (''Galileo Galilei''  , 171717178),
				 (''Ada Lovelace''     , 181818189),
				 (''Pythagoras''       , 191919190),
				 (''Rosalind Franklin'', 101010101),
	             (''Igor Dodon''       , 999000000);';

  EXEC sp_executesql @sql;
END
GO