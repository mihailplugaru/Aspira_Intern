using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get; }
        IStockRepository Stock { get; }
        IOrderItemRepository OrderItem { get; }

        int Complete();
    }
}
