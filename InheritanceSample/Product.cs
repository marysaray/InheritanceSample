using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    /// <summary>
    /// Represents a salable object.
    /// </summary>
    public class Product
    {
        /* Constructors */

        public Product(string productName)
        {
            Name = productName;
        }

        /* Properties */

        /// <summary>
        /// Primary Key for product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Name of product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of product.
        /// </summary>
        public double Price { get; set; }

        /* Methods */

        /// <summary>
        /// Return a display string that represents current product.
        /// </summary>
        /// <returns></returns>
        // block syntax
        public virtual string GetDisplayText() // virtual keyword allows to be changeable by derived class.
        {
            return $"{Name} costs {Price}.";
        }

        /* -- expression-bodied syntax:
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
         
            public string GetDisplayText()
                => $"{Name} costs {Price}";
        */
    }
}