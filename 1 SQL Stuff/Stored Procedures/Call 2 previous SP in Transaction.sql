CREATE PROCEDURE dbo.CallTwoOtherSPs -- always use schema prefix
AS
BEGIN -- use body wrappers around whole body
  SET NOCOUNT ON; 

  BEGIN TRANSACTION 

  EXEC dbo.CreateTableWith4Columns 'Interns'

  EXEC dbo.InsertTenRows 'Interns'

  COMMIT
END
GO