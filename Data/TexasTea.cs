/* TexasTea.cs
 * Author: Max Maus
 * Last modified 2/16/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Whether or not sweetener should be added
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether or not lemon should be added
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The amount of calories in the Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        if (Sweet == true) return 36;
                        else return 18;
                    case Size.Medium:
                        if (Sweet == true) return 22;
                        else return 11;
                    case Size.Small:
                        if (Sweet == true) return 10;
                        else return 5;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
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
