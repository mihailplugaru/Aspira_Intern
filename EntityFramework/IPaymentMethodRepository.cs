﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace EntityFramework
{
    interface IPaymentMethodRepository : IRepository<PaymentMethod>
    {
    }
}