using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// details of dakota double buger entree
    /// </summary>
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// price for dakota double is 5.20
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// calories in dakota double is 464
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// if dakota double has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// if dakota double has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// if dakota double has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if dakota double has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// if dakota double has bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// if dakota double has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// if dakota double has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// if dakota double has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the dakota double
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Bun) { instructions.Add("hold bun"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                return instructions;
            }
        }
    }
}
