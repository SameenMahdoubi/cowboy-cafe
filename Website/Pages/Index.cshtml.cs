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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Contains the filtered menu
        /// </summary>
        public IEnumerable<IOrderItem> FilteredMenu { get; protected set; }

        /// <summary>
        /// A property containing whatever the user enters into the search bar.
        /// </summary>
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The minimum number of calories to filter by, as determined by user input.
        /// </summary>
        public uint? CalorieMin { get; set; }

        /// <summary>
        /// The maximum number of calories to filter by, as determined by user input.
        /// </summary>
        public uint? CalorieMax { get; set; }

        /// <summary>
        /// The minimum price to filter by, as determined by user input.
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price to filter by, as determined by user input.
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// The filtered item types (side, entree, drink)
        /// </summary>       
        public string[] ItemTypes { get; set; }

        public void OnGet(string SearchTerms, uint? CalorieMin, uint? CalorieMax, double? PriceMin, double? PriceMax, string[] ItemTypes)
        {
            this.SearchTerms = SearchTerms;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.ItemTypes = ItemTypes;

            FilteredMenu = Menu.All();

            if(SearchTerms != null){
                FilteredMenu = FilteredMenu.Where(menuItem => menuItem.Name.Contains(SearchTerms,
                    StringComparison.InvariantCultureIgnoreCase));
            }

            if(CalorieMin != null)
            {
                FilteredMenu = FilteredMenu.Where(menuItem => menuItem.Calories != null && menuItem.Calories >= CalorieMin);
            }

            if (CalorieMax != null)
            {
                FilteredMenu = FilteredMenu.Where(menuItem => menuItem.Calories != null && menuItem.Calories <= CalorieMax);
            }

            if (PriceMin != null)
            {
                FilteredMenu = FilteredMenu.Where(menuItem => menuItem.Price >= PriceMin);
            }

            if (PriceMax != null)
            {
                FilteredMenu = FilteredMenu.Where(menuItem => menuItem.Price <= PriceMax);
            }

            if(ItemTypes != null && ItemTypes.Length != 0)
            {
                List<IOrderItem> tempList = new List<IOrderItem>();
                // This part is a bit messy
                // If Entree is not selected, we remove every entree from the list.
                // This is done because I couldn't find a way to remove things from the list based on type otherwise
                if (!ItemTypes.Contains("Entree"))
                {
                    FilteredMenu = FilteredMenu.Where(menuItem => !Menu.Entrees.Contains(menuItem));
                }
                // And the same for Drinks
                if (!ItemTypes.Contains("Drink"))
                {
                    FilteredMenu = FilteredMenu.Where(menuItem => !Menu.Drinks.Contains(menuItem));
                }
                // And again for Sides
                if (!ItemTypes.Contains("Side"))
                {
                    FilteredMenu = FilteredMenu.Where(menuItem => !Menu.Sides.Contains(menuItem));
                }
            }
        }
    }
}
