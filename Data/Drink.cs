using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing drinks
    /// </summary>
    public abstract class Drink
    { 
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual SodaFlavor SodaFlavor { get; set; }

        /// <summary>
        /// abstract class for drink prices
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// abstract class for drink calories
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// public class for if theres ice or not
        /// </summary>
        public bool Ice { get; set; } = false;
        
        /// <summary>
        /// abstract list for special instrutions 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
