--DROP PROCEDURE dbo.CreateTableWith4Columns
--DROP PROCEDURE dbo.InsertTenRows
DROP PROCEDURE dbo.CallTwoOtherSPs

DROP TABLE dbo.Interns

--EXEC dbo.CreateTableWith4Columns 'Interns'
--EXEC dbo.InsertTenRows 'Interns'
EXEC dbo.CallTwoOtherSPs

Rollback Transaction SP2

select * from Interns

--INSERT INTO dbo.Interns
--([FullName], [PhoneNumber])
--VALUES
--('o', 216598764)


--------Functions using DATE
declare @JoinDate1 datetime;
set @JoinDate1 = (SELECT JoinDate from Interns where InternId = 1);
print @JoinDate1;

SELECT DATEDIFF(minute, @JoinDate1, GETDATE()) AS StudyTime;
SELECT DATEADD(month, 3, @JoinDate1) AS InternshipEnding;
Select CONVERT(VARCHAR(8),@JoinDate1,22) AS SomethingConverted;


--------Functions using STRING
declare @Name1 varchar(50);
set @Name1 = (SELECT FullName from Interns where InternId = 7);
declare @Name2 varchar(50);
set @Name2 = (SELECT FullName from Interns where InternId = 10);

SELECT DIFFERENCE(@Name1, @Name2) as Resemblance;
SELECT SUBSTRING(@Name1 , 5 , 4)​ AS SomethingInTheMiddle
SELECT STUFF(@Name2,6,5,'Nicolaevich') as SomeoneRandom


--------Functions using Numbers
SELECT AVG(PhoneNumber) AS UselessNumber FROM Interns;
declare @Number varchar(50);
set @Number = (SELECT MAX(PhoneNumber) AS LargestNumber FROM Interns);
print @Number;
SELECT SQRT(@Number) as SquareRootOfSomeNumber
set @Number = (SELECT SQRT(@Number) as SquareRootOfSomeNumber);
SELECT FLOOR(@Number) AS FloorValue;


