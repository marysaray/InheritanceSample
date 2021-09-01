using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Gadget")
            {
                ProductId = 1,
                Price = 9.99
            };

            Book b = new Book("Murach's C#", "1563245689754", "Joel Murach")
            {
                ProductId = 2,
                Price = 39.99,
            };

            Software s = new Software("Visual Studio 2019")
            {
                ProductId = 3,
                Price = 500,
                Productkey = "student@email.edu",
                Version = "16.7.1"
            };

            DisplayProduct(p);
            DisplayProduct(b);
            DisplayProduct(s);

            Console.ReadKey(); // keeps the program open
        }

        /// <summary>
        /// This method will display text details for a specific product
        /// passed in the parameter.
        /// </summary>
        /// <param name="product"></param>
        private static void DisplayProduct(Product product)
        {
            Console.WriteLine(product.GetDisplayText());
        }
    }
}