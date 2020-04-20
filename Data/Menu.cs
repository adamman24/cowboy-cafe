using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// creates lists of menu items 
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// list of entree items in cafe
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            var chicken = new AngryChicken();
            entrees.Add(chicken);
            var chili = new CowpokeChili();
            entrees.Add(chili);
            var dakota = new DakotaDoubleBurger();
            entrees.Add(dakota);
            var peco = new PecosPulledPork();
            entrees.Add(peco);
            var ribs = new RustlersRibs();
            entrees.Add(ribs);
            var triple = new TexasTripleBurger();
            entrees.Add(triple);
            var trail = new TrailBurger();
            entrees.Add(trail);

            return entrees;
        }

        /// <summary>
        /// list of sides 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            var beans = new BakedBeans();
            sides.Add(beans);
            var fries = new ChiliCheeseFries();
            sides.Add(fries);
            var dodgers = new CornDodgers();
            sides.Add(dodgers);
            var campo = new PanDeCampo();
            sides.Add(campo);

            return sides;
        }

        /// <summary>
        /// list of drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            var coffee = new CowboyCoffee();
            drinks.Add(coffee);
            var soda = new JerkedSoda();
            drinks.Add(soda);
            var tea = new TexasTea();
            drinks.Add(tea);
            var water = new Water();
            drinks.Add(water);

            return drinks;
        }

        /// <summary>
        /// creates full menu list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var entree = Entrees();
            var sides = Sides();
            var drinks = Drinks();

            List<IOrderItem> menu = new List<IOrderItem>();
            foreach(IOrderItem item in entree)
            {
                menu.Add(item);
            }
            foreach(IOrderItem item in sides)
            {
                menu.Add(item);
            }
            foreach(IOrderItem item in drinks)
            {
                menu.Add(item);
            }
            return menu;
        }
    }
}
