using System;
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
                    ProductId = apaOM.Id
                };

                unitOfWork.Product.Add(apaOM);
                unitOfWork.Product.Add(paineNeagra);
                unitOfWork.Product.Add(lapteAlba);

                unitOfWork.Stock.Add(stock1);
                unitOfWork.OrderItem.Add(orderItem1);
                unitOfWork.Complete();


                var allProds = unitOfWork.Product.GetAll();

                foreach (var prod in allProds)
                {
                    Console.WriteLine(prod);
                }

                var prod1 = unitOfWork.Product.Find(x => x.Type == "Fainoase");

                foreach (var prod in prod1)
                {
                    Console.WriteLine(prod);
                }

                var expensiveProduct = unitOfWork.Product.GetMostExpensiveProducts();

                foreach (var prod in expensiveProduct)
                {
                    Console.WriteLine(prod);
                }

                Console.WriteLine(unitOfWork.OrderItem.GetMostRecentOrder());

                unitOfWork.Complete();
                Console.ReadKey();
            }
        }
    }
}


//using (var shopDb = new ShopContext())
//{
//    var product = new Product()
//    {
//        Name = "Apa minerala OM",
//        Type = "Bauturi nealcoolice",
//        Price = 10.50F
//    };

//    var stock = new Stock()
//    {
//        Quantity = 5,
//        Product = product,
//        ProductId = product.Id
//    };

//    var orderItem1 = new OrderItem()
//    {
//        Quantity = 1,
//        Product = product,
//        ProductId = product.Id
//    };

//    shopDb.Product.Add(product);
//    shopDb.Stock.Add(stock);
//    shopDb.OrderItem.Add(orderItem1);
//    shopDb.SaveChanges();
//}
