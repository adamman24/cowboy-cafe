using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing jerked soda class
    /// </summary>
    public class JerkedSoda : Drink
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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// what flavor the soda is
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
            }
        }


        /// <summary>
        /// if has ice
        /// </summary>
        //public bool Ice { get; set; } = true;

        /// <summary>
        /// calories for different size drinks
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
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

                if (!Ice) instructions.Add("Hold Ice");
                return instructions;

            }
        }

        /// <summary>
        /// prints name of item in order list
        /// </summary>
        public override string ToString()
        {
            if (Flavor == SodaFlavor.CreamSoda)
            {
                return $"{Size.ToString()} Cream Soda Jerked Soda";
            }else if (Flavor == SodaFlavor.RootBeer)
            {
                return $"{Size.ToString()} Root Beer Jerked Soda";
            }else if (Flavor == SodaFlavor.BirchBeer)
            {
                return $"{Size.ToString()} Birch Beer Jerked Soda";
            }else if (Flavor == SodaFlavor.Sarsparilla)
            {
                return $"{Size.ToString()} Sarsparilla Jerked Soda";
            }else
            {
                return $"{Size.ToString()} Orange Soda Jerked Soda";
            }
        }
    }
}
