CREATE TABLE dbo.Discount
(
   ID                INT    NOT NULL  IDENTITY(1,1)    PRIMARY KEY , -- primary key, AUTOINCREMENT column
   Description       [NVARCHAR](50)  NOT NULL,
   Amount            INT	        NOT NULL CHECK(Amount BETWEEN 0 and 100)
);

CREATE TABLE dbo.ProductType
(
   ProdType            [NVARCHAR](50)  NOT NULL  UNIQUE,
   Specifications      [NVARCHAR](150) NOT NULL,
   TVATaxes            [numeric](8,2)  NOT NULL DEFAULT(20.00),
   ExciseTaxes         [numeric](8,2)  NOT NULL DEFAULT(10.00)
);

CREATE TABLE dbo.Product
(
   ID              INT    NOT NULL  IDENTITY(1,1)    PRIMARY KEY , 
   Name            [NVARCHAR](50)  NOT NULL UNIQUE,
   ProductType     [NVARCHAR](50)  FOREIGN KEY REFERENCES ProductType(ProdType),
   BasePrice       numeric(8,2) not null CHECK (BasePrice > 0.01),
   DiscountID        INT FOREIGN KEY REFERENCES Discount(ID)
);

CREATE TABLE dbo.Stock
(
   ID               INT    NOT NULL  IDENTITY(1,1)    PRIMARY KEY , 
   ProductID        INT  FOREIGN KEY REFERENCES Product(ID),
   Quantity         SMALLINT  NOT NULL DEFAULT (0)
);

CREATE TABLE dbo.Purchase
(
   ID                  INT    NOT NULL  IDENTITY(1,1)    PRIMARY KEY , 
   TotalAmount         numeric(8,2) not null DEFAULT(0.01),
   PurchaseDate        datetime DEFAULT GETDATE(),
   PaymentType         nvarchar(20) not null check(PaymentType in ('Cash','Card'))
);

CREATE TABLE dbo.OrderItems
(
   ID                  INT    NOT NULL  IDENTITY(1,1)    PRIMARY KEY , 
   ProductID           INT  FOREIGN KEY REFERENCES Product(ID),
   PurchaseID          INT  FOREIGN KEY REFERENCES Purchase(ID),
   Quantity            numeric(8,2) not null check(Quantity >0),
   Cost                numeric(8,2) not null check(Cost >0.01)
);
