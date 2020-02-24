using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// corndodgers class for all sizes
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// prices for different sizes dodgers
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// calories for different size of dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
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
            return $"{Size.ToString()} Corn Dodgers";
        }
    }
}
