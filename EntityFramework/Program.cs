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
                var product = new Product()
                {
                    Name = "Apa minerala Om",
                    Type = "Bauturi nealcoolice",
                    Price = 10.40F
                };

                var allProds = unitOfWork.Product.GetAll();

                var prod1 = unitOfWork.Product.Find(x => x.Id == 3);

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
