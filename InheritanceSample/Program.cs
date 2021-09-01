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
        }
    }
}