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
    class Product
    {
        /* properties */

        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        /* methods */

        /// <summary>
        /// Return a display string that represents current product.
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            throw new NotImplementedException();
        }
    }
}