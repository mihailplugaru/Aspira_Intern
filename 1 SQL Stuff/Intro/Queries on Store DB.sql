--1. Display the products with discount>5% or which have no more stock
(Select p.ID from Product as p
INNER JOIN Discount as d
ON p.DiscountID = d.ID
where d.Amount > 5)
UNION
(Select p.ID from Product as p
INNER JOIN Stock as s
ON p.ID = s.ProductID
GROUP BY p.ID
HAVING Sum(s.Quantity) = 0)

--2. Display the products which names starts with "Fresh" and were at least one time purchased

Select p.ID, Name from Product as p
INNER JOIN OrderItems as o
ON p.ID = o.ProductID
where p.Name like 'Fresh%'

--3. Display the Purchases which have at least 2 products with Discount

Select o.PurchaseID  from OrderItems as o 
inner join Product pr
On o.ProductID = pr.ID
inner join Discount as d
ON pr.DiscountID = d.ID
where d.Amount > 0
Group By o.PurchaseID
Having Count(o.ProductID) >= 2



--4. Display the Purchase with maximum quantity of products with 'Tobacco' or 'Beer, Wine & Spirits' type
Select * from Purchase
Where ID in (
             Select PurchaseID from OrderItems
				where Quantity in (Select Max(Quantity) from OrderItems 
								  Where ProductID in (
										 Select ID from Product 
										 Where ProductType = 'Tobacco' or ProductType = 'Beer, Wine & Spirits')
								   )
	        )

--5. Display all product types with at leat one product that has Discount amount between 5 and 15.
Select * from ProductType
Where ProdType = Any(Select ProductType from Product 
                     Where DiscountID in (Select ID from Discount 
					                      Where Amount BETWEEN 5 AND 15)) 