using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    interface IStockRepository : IRepository<Stock>
    {
        IEnumerable<Stock> GetEmptyStocks();
    }
}
