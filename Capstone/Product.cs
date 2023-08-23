using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Location { get; }
        public string Category { get; }
        public string stringValue { get; }
        public int salesQuantity { get; set; } = 0;
        public int StockLevel { get; set; }

        public Product(string location, string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Location = location;
            Category = category;
            StockLevel = 5;

            switch(Category)
            {
                case "Chip":
                    stringValue = "Crunch Crunch, Yum!";
                    break;
                case "Candy":
                    stringValue = "Munch Munch, Yum!";
                    break;
                case "Drink":
                    stringValue = "Glug Glug, Yum!";
                    break;
                case "Gum":
                    stringValue = "Chew Chew, Yum!";
                    break;
            }
        }
    }
}