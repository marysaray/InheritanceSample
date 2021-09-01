using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Book : Product
    {
        /* Fields */

        private string isbn;

        /* Constructors */

        public Book(string productName) : base(productName) // inherits the base class constructor
        {
            throw new InvalidOperationException("ISBN is required to add book.");
        }

        public Book(string productName, string isbn) : this(productName, isbn, null) // overload methods with isbn required &  inherits the base class constructor
        {
            // reduced redundancy
        }

        public Book(string productName, string isbn, string author) : base(productName)
        {
            Isbn = isbn;
            Author = author;
        }

        /* Properties */

        /// <summary>
        /// 13 digit serial code associated with the book.
        /// </summary>
        public string Isbn 
        {
            get
            {
                return isbn;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(Isbn)} cannot be null.");
                }
                isbn = value;
            }
        }

        /// <summary>
        /// Name of Author for a specific book.
        /// </summary>
        public string Author { get; set; }
    }
}