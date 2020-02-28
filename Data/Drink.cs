/* Drink.cs
 * Author: Max Maus
 * Last modified: 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This is a base class which defines a base drink to be used as a parent to unique drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Defines the drink's name
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Defines the price of a given drink
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// The amount of calories in the drink
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// Whether or not the drink contains ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }
    }
}
