using System;
using System.Collections.Generic;
using Infrastructure;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new ShopContext()))
            {
                var apaOM = new Product()
                {
                    Name = "Apa minerala Om",
                    Type = "Bauturi nealcoolice",
                    Price = 10.50F
                };
                var paineNeagra = new Product()
                {
                    Name = "Franzeluta Paine Neagra",
                    Type = "Fainoase",
                    Price = 5.20F
                };
                var lapteAlba = new Product()
                {
                    Name = "Alba Lapte 2,5",
                    Type = "Lactate",
                    Price = 9.75F
                };

                var stock1 = new Stock()
                {
                    Quantity = 5,
                    Product = apaOM,
                    ProductId = apaOM.Id
                };

                var orderItem1 = new OrderItem()
                {
                    Quantity = 1,
                    Product = apaOM,
                    ProductId = apaOM.Id,
                    PurchaseId = 1
                };

                var orderItem2 = new OrderItem()
                {
                    Quantity = 2,
                    Product = paineNeagra,
                    ProductId = paineNeagra.Id,
                    PurchaseId = 1
                };

                var paymentMethod1 = new PaymentMethod()
                {
                    PayMethod = "Cash"
                };

                var purchase1 = new Purchase()
                {
                    PaymentMethodId = 1,
                    PaymentMethod = paymentMethod1
                };
                purchase1.OrderedItems.Add(orderItem1);
                purchase1.OrderedItems.Add(orderItem2);

                unitOfWork.Product.Add(apaOM);
                unitOfWork.Product.Add(paineNeagra);
                unitOfWork.Product.Add(lapteAlba);

                unitOfWork.Stock.Add(stock1);
                unitOfWork.OrderItem.Add(orderItem1);
                unitOfWork.PaymentMethod.Add(paymentMethod1);
                unitOfWork.Purchase.Add(purchase1);
                unitOfWork.Complete();

                Console.WriteLine("All Products :");
                var allProds = unitOfWork.Product.GetAll();

                foreach (var prod in allProds)
                {
                    Console.WriteLine(prod);
                }

                Console.WriteLine("Product with Type = 'Fainoase' :");
                var prod1 = unitOfWork.Product.Find(x => x.Type == "Fainoase");

                foreach (var prod in prod1)
                {
                    Console.WriteLine(prod);
                }

                Console.WriteLine("Most Expensive Products :");
                var expensiveProduct = unitOfWork.Product.GetMostExpensiveProducts();

                foreach (var prod in expensiveProduct)
                {
                    Console.WriteLine(prod);
                }

                Console.WriteLine("Most recent order :");
                Console.WriteLine(unitOfWork.OrderItem.GetMostRecentOrder());

                Console.WriteLine("Get all Purchases :");
                var allPurchases = unitOfWork.Purchase.GetAll();
                foreach (var purchase in allPurchases)
                {
                    Console.WriteLine(purchase);
                }

                unitOfWork.Complete();
                Console.ReadKey();
            }
        }
    }
}


//var apaOM = new Product()
//{
//    Name = "Apa minerala Om",
//    Type = "Bauturi nealcoolice",
//    Price = 10.50F
//};
//var paineNeagra = new Product()
//{
//    Name = "Franzeluta Paine Neagra",
//    Type = "Fainoase",
//    Price = 5.20F
//};
//var lapteAlba = new Product()
//{
//    Name = "Alba Lapte 2,5",
//    Type = "Lactate",
//    Price = 9.75F
//};

//var stock1 = new Stock()
//{
//    Quantity = 5,
//    Product = apaOM,
//    ProductId = apaOM.Id
//};

//var orderItem1 = new OrderItem()
//{
//    Quantity = 1,
//    Product = apaOM,
//    ProductId = apaOM.Id,
//    PurchaseId = 1
//};

//var orderItem2 = new OrderItem()
//{
//    Quantity = 2,
//    Product = paineNeagra,
//    ProductId = paineNeagra.Id,
//    PurchaseId = 1
//};

//var paymentMethod1 = new PaymentMethod()
//{
//    PayMethod = "Cash"
//};

//var purchase1 = new Purchase()
//{
//    PaymentMethodId = 1,
//    PaymentMethod = paymentMethod1
//};
//purchase1.OrderedItems.Add(orderItem1);
//purchase1.OrderedItems.Add(orderItem2);

//unitOfWork.Product.Add(apaOM);
//unitOfWork.Product.Add(paineNeagra);
//unitOfWork.Product.Add(lapteAlba);

//unitOfWork.Stock.Add(stock1);
//unitOfWork.OrderItem.Add(orderItem1);
//unitOfWork.PaymentMethod.Add(paymentMethod1);
//unitOfWork.Purchase.Add(purchase1);
//unitOfWork.Complete();
