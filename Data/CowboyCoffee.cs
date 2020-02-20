using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing cowboy coffee class
    /// </summary>
    public class CowboyCoffee : Drink
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
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
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
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// holds if there is room for cream in coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;


        /// <summary>
        /// if the coffee should be decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        

        /// <summary>
        /// return list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;

            }
        }
    }
}
