using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    interface IOrderItemRepository : IRepository<OrderItem>
    {
        OrderItem GetMostRecentOrder();
    }
}
