/* CowboyCoffee.cs
 * Author: Max Maus
 * Last modified 2/17/20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {  
        /// <summary>
        /// The amount of calories in the Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return .60;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
            }
        }

        /// <summary>
        /// Whether or not the Coffee is decaffienated
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Whether or not the Coffee contains ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Whether or not room should be left in the cup for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Special instructions for the preparation of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice == true)
                {
                    instructions.Add("Add Ice");
                }              
                if (RoomForCream == true)
                {
                    instructions.Add("Room for Cream");
                }

                return instructions;
            }
        }
    }
}
