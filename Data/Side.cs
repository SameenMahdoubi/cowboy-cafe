/* Side.cs
 * Author: Nathan Bean
 * Last modified 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Defines the side's name
        /// </summary>
        public string Name { get => ToString(); }
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for preparation of the side (always empty)
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<String>();
        }
    }
}
