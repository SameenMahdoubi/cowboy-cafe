/* TexasTea.cs
 * Author: Max Maus
 * Last modified 3/30/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        

        private bool sweet = true;
        /// <summary>
        /// Whether or not sweetener should be added
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Sweet"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Whether or not lemon should be added
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Lemon"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Calories"));

            }
        }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Texas Tea contains ice
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
        /// The amount of calories in the Tea
        /// </summary>
        public override uint? Calories
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

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] Texas [Plain or Sweet] Tea"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());
            tempString.Append(" Texas");
            if (Sweet == true)
            {
                tempString.Append(" Sweet");
            }
            else
            {
                tempString.Append(" Plain");
            }
            tempString.Append(" Tea");
            return tempString.ToString();
        }
    }
}
