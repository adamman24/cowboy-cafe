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
            EntreeItems = Menu.CategoryFilter(EntreeItems, Category);
            SideItems = Menu.CategoryFilter(SideItems, Category);
            DrinkItems = Menu.CategoryFilter(DrinkItems, Category);

            if (SearchItems != null)
            {
                EntreeItems = EntreeItems.Where(entree => entree.ToString().Contains(SearchItems, StringComparison.CurrentCultureIgnoreCase));
                SideItems = SideItems.Where(side => side.ToString().Contains(SearchItems, StringComparison.CurrentCultureIgnoreCase));
                DrinkItems = EntreeItems.Where(drink => drink.ToString().Contains(SearchItems, StringComparison.CurrentCultureIgnoreCase));

            }

            //prices area
            if (MinPrice != null && MinPrice != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Price >= MinPrice);
                SideItems = SideItems.Where(item => item.Price >= MinPrice);
                DrinkItems = DrinkItems.Where(item => item.Price >= MinPrice);
            }
            if (MaxPrice != null && MaxPrice != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Price <= MaxPrice);
                SideItems = SideItems.Where(item => item.Price <= MaxPrice);
                DrinkItems = DrinkItems.Where(item => item.Price <= MaxPrice);
            }
            if (MinPrice != null && MinPrice != 0 && MaxPrice != null && MaxPrice != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Price >= MinPrice && item.Price <= MaxPrice);
                SideItems = SideItems.Where(item => item.Price >= MinPrice && item.Price <= MaxPrice);
                DrinkItems = DrinkItems.Where(item => item.Price >= MinPrice && item.Price <= MaxPrice);
            }

            //Calories area
            if (MinCalories != null && MinCalories != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Calories >= MinCalories);
                SideItems = SideItems.Where(item => item.Calories >= MinCalories);
                DrinkItems = DrinkItems.Where(item => item.Calories >= MinCalories);
            }
            if (MaxCalories != null && MaxCalories != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Calories <= MaxCalories);
                SideItems = SideItems.Where(item => item.Calories <= MaxCalories);
                DrinkItems = DrinkItems.Where(item => item.Calories <= MaxCalories);
            }
            if (MinCalories != null && MinCalories != 0 && MaxCalories != null && MaxCalories != 0)
            {
                EntreeItems = EntreeItems.Where(item => item.Calories >= MinCalories && item.Calories <= MaxCalories);
                SideItems = SideItems.Where(item => item.Calories >= MinCalories && item.Calories <= MaxCalories);
                DrinkItems = DrinkItems.Where(item => item.Calories >= MinCalories && item.Calories <= MaxCalories);
            }
        }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

    }
}
