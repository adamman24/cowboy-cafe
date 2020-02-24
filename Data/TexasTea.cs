using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing Texas tea class
    /// </summary>
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// if lemon in tea
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// if tea should be sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// if has ice
        /// </summary>
        public bool Ice { get; set; } = true;

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
            if (Sweet)
            {
                return $"{Size.ToString()} Texas Sweet Tea";
            }else 
            {
               return $"{Size.ToString()} Texas Plain Tea";
            }
            
        }
    }
}
