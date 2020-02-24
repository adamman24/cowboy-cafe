using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing chili cheese fries
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// calories for each size of cheese fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// price for each size of cheese fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// prints name of item in order list
        /// </summary>
        public override string ToString()
        {
            return $"{Size.ToString()} Chili Cheese Fries";
        }
    }
}
