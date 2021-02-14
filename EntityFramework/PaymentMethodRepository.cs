using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace EntityFramework
{
    class PaymentMethodRepository : Repository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(ShopContext context)
            : base(context)
        {
        }

        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
