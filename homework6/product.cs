using System;
using System.Collections.Generic;
using System.Text;

namespace homework6
{
    internal class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public bool Nuts;
        public string Image;
        public bool Vegetarian; 
        public int Spiciness;
        public string Category; 


        public void info()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Category:" + Category);
        }
        public void Discount(decimal percentage)
        {
            Price = Price - (Price * percentage / 100);
        }
        
        public bool IsSpicey()
        {
            return Spiciness > 0;
        }
        public void changeCategory(string newCategory)
        {
            Category = newCategory;
        }


    }
}
