using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[4];
            products[0] = new Product()
            {
                Name = "iphone 7",
                Price = 33000
            };
            products[1] = new Product()
            {
                Name = "iphone 7+",
                Price = 36000
            };
            products[2] = new Product()
            {
                Name = "iphone 6",
                Price = 28000
            };
            products[3] = new Product()
            {
                Name = "iphone 7+",
                Price = 28900
            };
            Random random = new Random();
            List<Product> shoppingCart = new List<Product>();

            for(var count = 1; count <= 10; count ++)
            {
                var index = random.Next(0, products.Length); // 0 - 4 但是它產生 0-3 因為機率不會產生到100%
                shoppingCart.Add(products[index]);
                Console.ReadLine(products[index].Name);

        }
    }
}
