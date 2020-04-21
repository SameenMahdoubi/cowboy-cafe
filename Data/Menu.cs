/* Menu.cs
 * Author: Max Maus
 * Last Modified 4/20/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This represents the menu for Cowboy Cafe. It is a static class because only one Menu must ever be created.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// A list that contains every entree. These are manually created because I cannot think of a way to enumerate through every entree without an existing list.
        /// </summary>
        public static IEnumerable<IOrderItem> entrees = new List<IOrderItem> {
            new TrailBurger(),
            new DakotaDoubleBurger(),
            new TexasTripleBurger(),
            new AngryChicken(),
            new RustlersRibs(),
            new CowpokeChili(),
            new PecosPulledPork()
        };

        /// <summary>
        /// A list that contains every drink.
        /// </summary>
        private static IEnumerable<IOrderItem> drinks = new List<IOrderItem>{
            new CowboyCoffee(),
            new JerkedSoda(),
            new TexasTea(),
            new Water()
        };

        /// <summary>
        /// A list that contains every side.
        /// </summary>
        private static IEnumerable<IOrderItem> sides = new List<IOrderItem> {
            new BakedBeans(),
            new ChiliCheeseFries(),
            new CornDodgers(),
            new PanDeCampo()
        };

        /// <summary>
        /// Returns the entrees list while preserving data hiding.
        /// </summary>
        /// <returns>A list of every entree.</returns>
        public static IEnumerable<IOrderItem> Entrees
        {
            get { return entrees; }
        }
        
        /// <summary>
        /// Returns the sides list while preserving data hiding.
        /// </summary>
        /// <returns>A list of every side.</returns>
        public static IEnumerable<IOrderItem> Sides
        {
            get { return sides;}
        }

        /// <summary>
        /// Returns the drinks list while preserving data hiding.
        /// </summary>
        /// <returns>A list of every drink.</returns>
        public static IEnumerable<IOrderItem> Drinks
        {
            get { return drinks; }
        }

        /// <summary>
        /// returns the full Cowboy Cafe menu.
        /// </summary>
        /// <returns>The menu.</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();

            foreach(Entree entree in entrees)
            {
                fullMenu.Add(entree);
            }

            foreach (Side side in sides)
            {
                fullMenu.Add(side);
            }

            foreach (Drink drink in drinks)
            {
                fullMenu.Add(drink);
            }

            return fullMenu;
        }


    }
}
