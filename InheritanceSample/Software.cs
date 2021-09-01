using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Software : Product
    {
        /* Properties */

        /// <summary>
        /// Semantic version of software ex: 3.0.2
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Email associated to the downloadable software application.
        /// </summary>
        public string Productkey { get; set; }
    }
}