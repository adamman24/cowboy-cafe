using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the angry chicken entree
    /// </summary>
    public class AngryChicken: Entree
    {
        /// <summary>
        /// price of angry chicken is 5.99
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// calories in angry chicken 190
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        public bool pickle = true;
        /// <summary>
        /// if angry chicken should have pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// if angry chicken should have bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the angry chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Bread) { instructions.Add("hold bread"); }
                if (!pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }
    }
}
