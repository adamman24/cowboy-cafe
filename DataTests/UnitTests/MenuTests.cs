using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        public void EntreeMenuContainsAllEntrees(Type type)
        {
            var list = new List<Type>();
            foreach(IOrderItem item in Menu.Entrees)
            {
                list.Add(item.GetType());
            }
            Assert.Contains(type, list);
        }

        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SideMenuContainsAllSides(Type type)
        {
            var list = new List<Type>();
            foreach (IOrderItem item in Menu.Sides)
            {
                list.Add(item.GetType());
            }
            Assert.Contains(type, list);
        }

        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinkMenuContainsAllDrinks(Type type)
        {
            var list = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks)
            {
                list.Add(item.GetType());
            }
            Assert.Contains(type, list);
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void FullCompletedMenuReturned(Type type)
        {
            var list = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteMenu)
            {
                list.Add(item.GetType());
            }
            Assert.Contains(type, list);
        }

        [Theory]
        [InlineData("Angry Chicken")]
        [InlineData("Cowpoke Chili")]
        [InlineData("Dakota Double Burger")]
        [InlineData("Pecos Pulled Pork")]
        [InlineData("Rustler's Ribs")]
        [InlineData("Texas Triple Burger")]
        [InlineData("Trail Burger")]
        [InlineData("Small Baked Beans")]
        [InlineData("Small Chili Cheese Fries")]
        [InlineData("Small Corn Dodgers")]
        [InlineData("Small Pan de Campo")]
        [InlineData("Small Cowboy Coffee")]
        [InlineData("Small Cream Soda Jerked Soda")]
        [InlineData("Small Texas Sweet Tea")]
        [InlineData("Small Water")]
        public void SearchingFunctionWorksAsExpected(string search)
        {
            
            Assert.True(searchTest(search));
        }

        public bool searchTest (string s)
        {
            bool exists = false;

            foreach (var item in Menu.SearchMenu(Menu.CompleteMenu, s))
            {
                if (item.ToString() == s)
                {
                    exists = true;
                }
            }
            return exists;
        }

        [Theory]
        [InlineData(12, 1)]
        [InlineData(null, 1)]
        [InlineData(12, null)]
        [InlineData(null, null)]

        public void PriceFilterWorksCorrectly(double? max, double? min)
        {
            IEnumerable<IOrderItem> menu = Menu.CompleteMenu;
            IEnumerable<IOrderItem> itemList = Menu.PriceFilter(menu, max, min);
            foreach(IOrderItem item in itemList)
            {
                if(min == null && max == null)
                {
                    Assert.Contains(item, menu);
                }else if (min == null)
                {
                    Assert.True(item.Price <= max);
                }else if (max == null)
                {
                    Assert.True(item.Price >= min);
                }else
                {
                    Assert.True(item.Price >= min && item.Price <= max);
                }
            }
        }

        [Theory]
        [InlineData(500, 100)]
        [InlineData(null, 100)]
        [InlineData(500, null)]
        [InlineData(null, null)]

        public void CalorieFilterWorksCorrectly(int? max, int? min)
        {
            IEnumerable<IOrderItem> menu = Menu.CompleteMenu;
            IEnumerable<IOrderItem> itemList = Menu.CalorieFilter(menu, max, min);
            foreach (IOrderItem item in itemList)
            {
                if (min == null && max == null)
                {
                    Assert.Contains(item, menu);
                }
                else if (min == null)
                {
                    if (item is Entree entree)
                    {
                        Assert.True(entree.Calories <= max);
                    }
                }
                else if (max == null)
                {
                    if (item is Entree entree)
                    Assert.True(entree.Calories >= min);
                }
                else
                {
                    if (item is Entree entree)
                    Assert.True(entree.Calories >= min && entree.Calories <= max);
                }
            }
        }



        [Theory]
        [InlineData("Entree", "Sides", "Drinks")]
        [InlineData(null , "Sides", "Drinks")]
        [InlineData("Entree", null, "Drinks")]
        [InlineData("Entree", "Sides", null)]
        [InlineData(null, null, null)]
        public void CategoryFilterSortsCorrectly(params string[] category)
        {
            IEnumerable<IOrderItem> itemList = Menu.CategoryFilter(Menu.CompleteMenu, category);
            foreach(IOrderItem item in itemList)
            {
                if(item is Entree)
                {
                    Assert.IsAssignableFrom<Entree>(item);
                }else if (item is Side)
                {
                    Assert.IsAssignableFrom<Side>(item);
                }else if (item is Drink)
                {
                    Assert.IsAssignableFrom<Drink>(item);
                }
            }
        }
    }
}
