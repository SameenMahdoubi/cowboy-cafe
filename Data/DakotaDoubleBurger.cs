/* DakotaDoubleBurger.cs
 * Author: Max Maus
 * Last modified 2/19/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Whether the Dakota Double Burger is served on a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains tomatoes
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Whether the Dakota Double Burger contains mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Dakota Double Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "Dakota Double Burger"</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
