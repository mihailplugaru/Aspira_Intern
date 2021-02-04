using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ShopContext context)
            : base(context)
        {
        }

        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
        public IEnumerable<Product> GetCheapestProducts()
        {
            return ShopContext.Product
                .Where(x => x.Price.Equals(ShopContext.Product.Min(y => y.Price))).ToList();
        }

        public IEnumerable<Product> GetMostExpensiveProducts()
        {
            return ShopContext.Product
                .Where(x => x.Price.Equals(ShopContext.Product.Max(y => y.Price))).ToList();
        }
    }
}
