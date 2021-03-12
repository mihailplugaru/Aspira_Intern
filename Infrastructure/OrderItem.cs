using System;

namespace Infrastructure
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public DateTime DateTime { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}  Quantity : {Quantity}  DateTime : {DateTime}  ProductId : {ProductId}  PurchaseId: {PurchaseId}";
        }
    }
}
