﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing jerked soda class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// prices for different sizes drinks
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .12;
                    case Size.Medium:
                        return .12;
                    case Size.Large:
                        return .12;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// calories for different size drinks
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        //public bool Ice { get; set; } = true;

        public bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// return list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;

            }
        }

        /// <summary>
        /// prints name of item in order list
        /// </summary>
        public override string ToString()
        {
            return $"{Size.ToString()} Water";
        }
    }
}
