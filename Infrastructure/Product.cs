using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}  Name : {Name}  Type : {Type}  Price : {Price}";
        }
    }
}
