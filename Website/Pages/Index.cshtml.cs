using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> EntreeItems
        {
            get;
            protected set;
        } = Menu.Entrees;
        
        public IEnumerable<IOrderItem> SideItems
        {
            get;
            protected set;
        } = Menu.Sides;

        public IEnumerable<IOrderItem> DrinkItems
        {
            get;
            protected set;
        } = Menu.Drinks;

        [BindProperty]
        public string SearchItems { get; set; }

        [BindProperty]
        public string[] Category { get; set; }

        [BindProperty]
        public double? MinPrice { get; set; }

        [BindProperty]
        public double? MaxPrice { get; set; }

        [BindProperty]
        public int? MaxCalories { get; set; }

        [BindProperty]
        public int? MinCalories { get; set; }

        public void OnPost()
        {
            EntreeItems = Menu.SearchMenu(EntreeItems, SearchItems);
            SideItems = Menu.SearchMenu(SideItems, SearchItems);
            DrinkItems = Menu.SearchMenu(DrinkItems, SearchItems);
            EntreeItems = Menu.CategoryFilter(EntreeItems, Category);
            SideItems = Menu.CategoryFilter(SideItems, Category);
            DrinkItems = Menu.CategoryFilter(DrinkItems, Category);
            EntreeItems = Menu.PriceFilter(EntreeItems, MaxPrice, MinPrice);
            SideItems = Menu.PriceFilter(SideItems, MaxPrice, MinPrice);
            DrinkItems = Menu.PriceFilter(DrinkItems, MaxPrice, MinPrice);
            EntreeItems = Menu.CalorieFilter(EntreeItems, MaxCalories, MinCalories);
            SideItems = Menu.CalorieFilter(SideItems, MaxCalories, MinCalories);
            DrinkItems = Menu.CalorieFilter(DrinkItems, MaxCalories, MinCalories);

        }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

    }
}
