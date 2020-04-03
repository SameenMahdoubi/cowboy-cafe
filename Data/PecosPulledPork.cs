/* PecosPulledPork.cs
 * Author: Max Maus
 * Last modified 2/19/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        

        private bool bread = true;
        /// <summary>
        /// Whether the Pecos Pulled Pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { 
                bread = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Bread"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool pickle = true;
        /// <summary>
        /// Whether the Pecos Pulled Pork contains pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Pickle"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// The price of the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
