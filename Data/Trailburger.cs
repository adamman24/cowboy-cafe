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

        public bool ketchup = true;
        /// <summary>
        /// if dakota double has ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        public bool mustard = true;
        /// <summary>
        /// if dakota double has mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        public bool pickle = true;
        /// <summary>
        /// if dakota double has pickle
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
                NotifyOfPropertyChange("Pickle");
            }
        }

        public bool cheese = true;
        /// <summary>
        /// if dakota double has cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        public bool bun = true;
        /// <summary>
        /// if dakota double has bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        

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

        /// <summary>
        /// returns Trial Burger when button clicked
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
