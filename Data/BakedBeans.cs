﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing baked beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// prices for different size beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
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
        /// calories for different size beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
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
            return $"{Size.ToString()} Baked Beans";
        }
    }
}
