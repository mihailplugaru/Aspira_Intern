using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetMostExpensiveProducts();
        IEnumerable<Product> GetCheapestProducts();
    }
}
