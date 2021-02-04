using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;
using System.Linq;

namespace EntityFramework
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(ShopContext context)
            : base(context)
        {
        }

        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }

        public IEnumerable<Stock> GetEmptyStocks()
        {
            return ShopContext.Stock
                .Where(x => x.Quantity.Equals(0))
                .ToList();
        }


    }
}
