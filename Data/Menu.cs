using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;

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

                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var beans = new BakedBeans();
                    var fries = new ChiliCheeseFries();
                    var dodgers = new CornDodgers();
                    var campo = new PanDeCampo();

                    beans.Size = size;
                    fries.Size = size;
                    dodgers.Size = size;
                    campo.Size = size;

                    sides.Add(beans);
                    sides.Add(fries);
                    sides.Add(dodgers);
                    sides.Add(campo);
                }

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

                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var coffee = new CowboyCoffee();
                    coffee.Size = size;
                    drinks.Add(coffee);
                    var soda = new JerkedSoda();
                    soda.Size = size;
                    drinks.Add(soda);
                    var tea = new TexasTea();
                    tea.Size = size;
                    drinks.Add(tea);
                    var water = new Water();
                    water.Size = size;
                    drinks.Add(water);
                }
                    

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
        /*public static IEnumerable<IOrderItem> SearchMenu(IEnumerable<IOrderItem> itemList, string term)
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
        */

        public static IEnumerable<IOrderItem> CategoryFilter(IEnumerable<IOrderItem> itemList, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return itemList;

            var result = itemList;
           
            if (category.Contains("Entree"))
            {
                var item = itemList.OfType<Entree>();
                result = item;
            }
            if (category.Contains("Sides"))
            {
                var item = itemList.OfType<Side>();
                result = item;
            }
            if (category.Contains("Drinks"))
            {
                var item = itemList.OfType<Drink>();
                result = item;
            }

            if (category.Contains("Entree") && category.Contains("Side"))
            {
                result = itemList.Where(item => category.Contains("Entree") && (item is Entree || item is Side)).Where(item => category.Contains("Side") &&
                    (item is Side || item is Entree));
            }

            if (category.Contains("Entree") && category.Contains("Drink"))
            {
                result = itemList.Where(item => category.Contains("Entree") && (item is Entree || item is Drink)).Where(item => category.Contains("Drink") &&
                    (item is Drink || item is Entree));
            }

            if (category.Contains("Side") && category.Contains("Drink"))
            {
                result = itemList.Where(item => category.Contains("Side") && (item is Side || item is Drink)).Where(item => category.Contains("Drink") &&
                    (item is Drink  || item is Side));
            }

            if (category.Contains("Entree") && category.Contains("Side") && category.Contains("Drink"))
            {
                result = itemList.Where(item => category.Contains("Entree")).Where(item => category.Contains("Side")).Where(item => category.Contains("Drink"));
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
        /*
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
        */

        /// <summary>
        /// allows filtering price
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        /*
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
        */


    }
}
