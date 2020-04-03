/* JerkedSoda.cs
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
    /// A class representing the Jerked Soda drink.
    /// </summary>
    public class JerkedSoda : Drink
    {
        

        private SodaFlavor flavor;
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Flavor"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Jerked Soda contains ice
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
        /// The amount of calories in the Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Jerked Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Jerked Soda
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

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] [Flavor] Jerked Soda"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());           
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    tempString.Append(" Cream Soda");
                    break;
                case SodaFlavor.OrangeSoda:
                    tempString.Append(" Orange Soda");
                    break;
                case SodaFlavor.Sarsparilla:
                    tempString.Append(" Sarsparilla");
                    break;
                case SodaFlavor.RootBeer:
                    tempString.Append(" Root Beer");
                    break;
                case SodaFlavor.BirchBeer:
                    tempString.Append(" Birch Beer");
                    break;

                default:
                    break;
            }
            tempString.Append(" Jerked Soda");
            return tempString.ToString();
        }
    }
}
