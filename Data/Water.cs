/* Water.cs
 * Author: Max Maus
 * Last modified 2/16/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents drinking water
    /// </summary>
    public class Water:Drink
    {
        /// <summary>
        /// Whether or not lemon should be added
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The amount of calories in the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice == false)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon == true)
                {
                    instructions.Add("Add Lemon");
                }

                return instructions;
            }
        }

    }
}
