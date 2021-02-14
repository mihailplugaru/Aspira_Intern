using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class Purchase
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public List<OrderItem> OrderedItems { get; set; }

        public Purchase()
        {
            this.OrderedItems = new List<OrderItem>();
        }

        public override string ToString()
        {
            return $"Id : {Id}  DateTime : {DateTime}  PaymentMethodId : {PaymentMethodId} \n OrderedItems : {String.Join<OrderItem>(", ", OrderedItems)}";
        }
    }
}
