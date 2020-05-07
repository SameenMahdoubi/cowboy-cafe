/* ChiliCheeseFries.cs
 * Author: Nathan Bean
 * Last modified 2/21/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili CHeese Fries side
    /// </summary>
    public class ChiliCheeseFries:Side
    {
        
        /// <summary>
        /// The amount of calories in the Chili Cheese Fries
        /// </summary>
        public override uint? Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] Chili Cheese Fries"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());
            tempString.Append(" Chili Cheese Fries");
            return tempString.ToString();
        }
    }
}
