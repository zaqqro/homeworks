using System.Runtime.CompilerServices;

namespace homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    static void main()
        {
            Product p = new Product();

            p.Id = 1;
            p.Name = "Pizza";
            p.Price = 9.99m;
            p.Nuts = false;
            p.Image = "pizza.jpg";
            p.Vegetarian = true;
            p.Spiciness = 2;
            p.Category = "Fast food";


            p.info();
            p.Discount(10);
            Console.WriteLine("new price: " + p.Price);
            Console.WriteLine("Is spicy: " + p.Spiciness);
            p.changeCategory("Food");
            Console.WriteLine("New category: " + p.Category);

        }
    
    }
}
