/* Water.cs
 * Author: Max Maus
 * Last modified 2/21/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents drinking water
    /// </summary>
    public class Water:Drink
    {
        

        private bool lemon = false;
        /// <summary>
        /// Whether or not lemon should be added
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Lemon"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Whether or not the water contains ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Ice"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The amount of calories in the water
        /// </summary>
        public override uint? Calories
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


        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] Water"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());
            tempString.Append(" Water");
            return tempString.ToString();
        }
    }
}
