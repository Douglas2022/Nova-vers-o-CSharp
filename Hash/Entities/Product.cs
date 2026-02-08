using System;
using System.Collections.Generic;
using Hash.Entities;

namespace Hash.Entities
{
    class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(string name, int v, string price)
        {
            Name = name;
            Price = price;
        }
    }
}
