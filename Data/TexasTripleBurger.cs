using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing textas triple entree
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// price of texas triple is 645
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// calories of texas triple is 645
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// if texas triple has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// if texas triple has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// if texas triple has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if texas triple has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// if texas triple has bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// if texas triple has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// if texas triple has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// if texas triple has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// if texas triple has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// if texas triple has egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the texas triple
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
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }
                return instructions;
            }
        }
    }
}
