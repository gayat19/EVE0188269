using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public Product()
        {
            
        }

        public Product(int id, string name, int quantity, double price, string description)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
        }
        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nPrice : ${Price}\nQuantity In Hand : {Quantity}\nDescription : {Description}";
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;//""
    }
}
