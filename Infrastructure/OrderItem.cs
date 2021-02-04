﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }

        public DateTime DateTime { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}  Quantity : {Quantity}  DateTime : {DateTime}  ProductId : {ProductId}";
        }
    }
}