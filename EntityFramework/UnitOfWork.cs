using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;

        public UnitOfWork(ShopContext context)
        {
            _context = context;
            Product = new ProductRepository(_context);
            Stock = new StockRepository(_context);
            OrderItem = new OrderItemRepository(_context);
            Purchase = new PurchaseRepository(_context);
            PaymentMethod = new PaymentMethodRepository(_context);
        }

        public IProductRepository Product { get; private set; }
        public IStockRepository Stock { get; private set; }
        public IOrderItemRepository OrderItem { get; private set; }
        public IPurchaseRepository Purchase { get; private set; }
        public IPaymentMethodRepository PaymentMethod { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
