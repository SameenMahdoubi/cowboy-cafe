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
        public int? CalorieMin { get; set; }

        /// <summary>
        /// The maximum number of calories to filter by, as determined by user input.
        /// </summary>
        public int? CalorieMax { get; set; }

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

        public void OnGet(string SearchTerms, int? CalorieMin, int? CalorieMax, double? PriceMin, double? PriceMax, string[] ItemTypes)
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
                
            }
        }
    }
}
