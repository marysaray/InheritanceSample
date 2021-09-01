using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Book : Product
    {
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