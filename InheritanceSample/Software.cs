using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Software : Product
    {
        /* Constructors */
        public Software(string productName) : base(productName) // inherits the base class constructor
        {
            // inherits from product class
        }

        /* Properties */

        /// <summary>
        /// Semantic version of software ex: 3.0.2
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Email associated to the downloadable software application.
        /// </summary>
        public string Productkey { get; set; }

        public override string GetDisplayText() // override changes the behavior of the base method.
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}