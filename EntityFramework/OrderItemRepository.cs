using Infrastructure;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ShopContext context)
            : base(context)
        {
        }

        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }

        public OrderItem GetMostRecentOrder()
        {
            return ShopContext.OrderItem.OrderByDescending(x => x.DateTime)
            .FirstOrDefault();
        }
    }
}
