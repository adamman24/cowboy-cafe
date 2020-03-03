using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// abstract entree base class
    /// </summary>
    public abstract class Entree: IOrderItem
    {
        /// <summary>
        /// abstract class for entrees prices
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// abstract class for entree calories
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// abstract class for special isntructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
