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
        public static List<IOrderItem> entrees = new List<IOrderItem> {
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
        private static List<IOrderItem> drinks = new List<IOrderItem>{
            new CowboyCoffee(),
            new JerkedSoda(),
            new TexasTea(),
            new Water()
        };

        /// <summary>
        /// A list that contains every side.
        /// </summary>
        private static List<IOrderItem> sides = new List<IOrderItem> {
            new BakedBeans(),
            new ChiliCheeseFries(),
            new CornDodgers(),
            new PanDeCampo()
        };

        /// <summary>
        /// Returns the entrees list while preserving data hiding.
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> GetEntrees()
        {
            return entrees;
        }

        /// <summary>
        /// Returns the sides list while preserving data hiding.
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> GetSides()
        {
            return sides;
        }

        /// <summary>
        /// Returns the drinks list while preserving data hiding.
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> GetDrinks()
        {
            return drinks;
        }




    }
}
