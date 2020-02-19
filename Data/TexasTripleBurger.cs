/* TexasTripleBurger.cs
 * Author: Max Maus
 * Last modified 2/19/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// Whether the Texas Triple Burger is served on a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains tomatoes
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Whether the Texas Triple Burger contains eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// The price of the Texas Triple Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the Texas Triple Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Texas Triple Burger
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
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "Texas Triple Burger"</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
