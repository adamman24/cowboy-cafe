using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// details of dakota double buger entree
    /// </summary>
    public class DakotaDoubleBurger: Entree
    {
        /// <summary>
        /// price for dakota double is 5.20
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// calories in dakota double is 464
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
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

        public bool tomato = true;
        /// <summary>
        /// if dakota double has tomato
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        public bool lettuce = true;
        /// <summary>
        /// if dakota double has lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        public bool mayo = true;
        /// <summary>
        /// if dakota double has mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the dakota double
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
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                return instructions;
            }
        }

        /// <summary>
        /// returns Dakota double when button clicked
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
