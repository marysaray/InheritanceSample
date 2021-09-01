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
            Product p = new Product()
            {
                ProductId = 1,
                Name = "Gadget",
                Price = 9.99
            };

            Book b = new Book()
            {
                ProductId = 2,
                Name = "Murach's C#",
                Price = 39.99,
                Author = "Joel Murach",
                Isbn = "1563245689754"
            };

            Software s = new Software()
            {
                ProductId = 3,
                Name = "Visual Studio 2019",
                Price = 500,
                Productkey = "student@email.edu",
                Version = "16.7.1"
            };
        }
    }
}