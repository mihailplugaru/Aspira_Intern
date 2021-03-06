﻿namespace Infrastructure
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public string Store { get; set; }
        public override string ToString()
        {
            return $"Id : {Id}  Name : {Name}  Type : {Type}  Price : {Price}";
        }
    }
}
