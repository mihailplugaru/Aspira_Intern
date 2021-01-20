/*
DROP TABLE dbo.Purchase
DROP TABLE dbo.OrderItems
DROP TABLE dbo.Stock
DROP TABLE dbo.Product
DROP TABLE dbo.ProductType
DROP TABLE dbo.Discount
*/

/*
INSERT INTO dbo.Discount
   ([Description],[Amount])
VALUES
   ( N'No Discount',0),
   ( N'Low',7),
   ( N'Medium',12),
   ( N'High',18),
   ( N'Loyal Customer',22)
GO

Select * from dbo.Discount 

INSERT INTO dbo.ProductType
   (ProdType,Specifications,TVATaxes,ExciseTaxes)
VALUES
   ( N'Bread & Bakery', N'No specifications here',5,0),
   ( N'Meat & Seafood', N'No specifications here',20,0),
      ( N'Fruits & Vegetables', N'No specifications here',20 , 0),
	     ( N'Beer, Wine & Spirits', N'Be aware of time of the day and customers age',20 , 10),
		 ( N'Tobacco', N'Be aware of customers age',20 , 15)
GO

Select * from dbo.ProductType 


INSERT INTO dbo.Product
   (Name,ProductType,BasePrice,DiscountID)
VALUES
   ( N'Simple Bread',N'Bread & Bakery',11.99,1),
   ( N'Fresh Beef',N'Meat & Seafood',12.99,2),
   ( N'Black Cucumber',N'Fruits & Vegetables',13.99,3),
   ( N'Beer with Wine',N'Beer, Wine & Spirits',14.99,4),
   ( N'Some Cigarettes',N'Tobacco',15.99,5)
GO
Select * from dbo.Product 

INSERT INTO dbo.Stock
   (ProductID,Quantity)
VALUES
   ( 1, 100),
      ( 1, 16),
	     ( 2, 32),
		    ( 3, 64),
			   ( 4, 16),
			      ( 5, 0)
GO
Select * from dbo.Stock 

INSERT INTO dbo.Purchase
   (PaymentType)
VALUES
   ( N'Cash'),
   ( N'Cash'),
   ( N'Cash'),
   ( N'Cash'),
   ( N'Card'),
   ( N'Card')
GO

Select * from Purchase

INSERT INTO dbo.OrderItems
   (ProductID,PurchaseID,Quantity,Cost)
VALUES
   ( 1,1,8,2),
   ( 5,1,2,7),
   ( 2,2,6,4.7),
   ( 4,1,15,88.9),
   ( 1,4,1,4.11),
   ( 3,3,2,3.09),
   ( 2,5,1,2.63),
   ( 5,2,3,1.12),
   ( 4,4,1,4.7),
   ( 3,3,1,5.23)
GO

Select * from OrderItems
*/
select * from ProductType