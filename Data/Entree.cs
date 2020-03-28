/* Entree.cs
 * Author: Nathan Bean
 * Last modified 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Defines a base Entree class to use as the parent to all other entrees
    /// </summary>
    public abstract class Entree : IOrderItem
        { 
        /// <summary>
        /// Defines the entree's name
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// Defines the price of a given entree
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// The amount of calories in the entree
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }
    }
}
