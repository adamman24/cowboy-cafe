using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

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
        public static IEnumerable<IOrderItem> Entrees
        {
            get
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
        }

        /// <summary>
        /// list of sides 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides
        {
            get
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
        }

        /// <summary>
        /// list of drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
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
        }

        /// <summary>
        /// creates full menu list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu
        {
            get
            {
                var entree = Entrees;
                var sides = Sides;
                var drinks = Drinks;

                List<IOrderItem> menu = new List<IOrderItem>();
                foreach (IOrderItem item in entree)
                {
                    menu.Add(item);
                }
                foreach (IOrderItem item in sides)
                {
                    menu.Add(item);
                }
                foreach (IOrderItem item in drinks)
                {
                    menu.Add(item);
                }
                return menu;
            }
        }

        /// <summary>
        /// creates catagories of orderable things
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Sides",
                "Drinks"
            };
        }

        /// <summary>
        /// allows to search the menu for an item
        /// </summary>
        /// <param name="itemList">the items</param>
        /// <param name="term">string input</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> SearchMenu(IEnumerable<IOrderItem> itemList, string term)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            
            if (term == null || term =="")
            {
                return itemList;
            }else
            {
                foreach(IOrderItem item in itemList)
                {
                    if (item != null && item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase))
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }

        public static IEnumerable<IOrderItem> CategoryFilter(IEnumerable<IOrderItem> itemList, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return itemList;

            List<IOrderItem> result = new List<IOrderItem>();
            
            foreach(IOrderItem item in itemList)
            {
                if (item != null && item is Entree && category.Contains("Entree"))
                {
                    result.Add(item);
                }
                if (item != null && item is Side && category.Contains("Sides"))
                {
                    result.Add(item);
                }
                if (item != null && item is Drink && category.Contains("Drinks"))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// allows to filter by calories
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CalorieFilter (IEnumerable<IOrderItem> itemList, int? max, int? min)
        {
            var result = new List<IOrderItem>();

            if (min == null && max == null)
            {
                return itemList;
            }

            if (min == null)
            {
                foreach(IOrderItem item in itemList)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Calories <= max)
                        {
                            result.Add(item);
                        }
                    }
                }
                return result;
            }

            if (min == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Calories >= min)
                        {
                            result.Add(item);
                        }
                    }
                }
                return result;
            }

            foreach(IOrderItem item in itemList)
            {
                if (item is Entree entree)
                {
                    if (entree.Calories >= min && entree.Calories <= max)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// allows filtering price
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> PriceFilter(IEnumerable<IOrderItem> itemList, double? max, double? min)
        {
            var result = new List<IOrderItem>();

            if (min == null && max == null)
            {
                return itemList;
            }

            if (min == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item.Price <= max)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }

            if (min == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item.Price >= min)
                    {
                        result.Add(item);
                    }
                    
                }
                return result;
            }

            foreach (IOrderItem item in itemList)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    result.Add(item);
                }
             
            }
            return result;
        }


    }
}
