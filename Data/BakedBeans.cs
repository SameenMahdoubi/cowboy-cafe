﻿/* BakenBeans.cs
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
    /// A class representing the Baked Beans side
    /// </summary>
    public class BakedBeans : Side 
    { 


        /// <summary>
        /// The amount of calories in the baked beans
        /// </summary>
        public override uint? Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
        
        /// <summary>
        /// The price of the baked beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "[size of the item] Baked Beans"</returns>
        public override string ToString()
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Size.ToString());
            tempString.Append(" Baked Beans");
            return tempString.ToString();
        }
    }
}
