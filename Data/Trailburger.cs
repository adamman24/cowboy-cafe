using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representign trailburger entree
    /// </summary>
    public class TrailBurger: Entree
    {
        /// <summary>
        /// price of Trailburger is 4.50
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// calories in trailburger is 288
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// if burger has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// if burger has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// if burger has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if burger has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        public bool Bun { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the trailburger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Bun) { instructions.Add("hold bun"); }
                return instructions;
            }
        }
    }
}
