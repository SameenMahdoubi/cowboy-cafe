/* CowboyCoffee.cs
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
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        

        /// <summary>
        /// The amount of calories in the Coffee
        /// </summary>
        public override uint? Calories
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

        private bool decaf = false;
        /// <summary>
        /// Whether or not the Coffee is decaffienated
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Decaf"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = false;
        /// <summary>
        /// Whether or not the Coffee contains ice
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

        private bool roomForCream = false;
        /// <summary>
        /// Whether or not room should be left in the cup for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("RoomForCream"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
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

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] [Decaf, if decaf, otherwise blank] Cowboy Coffee"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());
            if (Decaf == true)
            {
                tempString.Append(" Decaf");
            }
            tempString.Append(" Cowboy Coffee");
            return tempString.ToString();
        }
    }
}
