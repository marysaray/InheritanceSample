using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Book : Product
    {
        /* Constructors */

        public Book(string productName) : base(productName) // inherits the base class constructor
        {
            throw new InvalidOperationException("ISBN is required to add book.");
        }

        public Book(string productName, string isbn) : base(productName) // overload methods with isbn required &  inherits the base class constructor
        {
            Isbn = isbn;
        }

        /* Properties */

        /// <summary>
        /// 13 digit serial code associated with the book.
        /// </summary>
        public string Isbn { get; set; }

        /// <summary>
        /// Name of Author for a specific book.
        /// </summary>
        public string Author { get; set; }
    }
}