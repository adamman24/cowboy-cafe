using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing pecos pulled pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// price of pulled pork is 5.88
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// calories in pulled pork is 528
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// if pulled pork has bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// if pulled pork has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the pecos pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }
    }
}
