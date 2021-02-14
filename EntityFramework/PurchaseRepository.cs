using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;


namespace EntityFramework
{
    class PurchaseRepository : Repository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(ShopContext context)
            : base(context)
        {
        }

        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
