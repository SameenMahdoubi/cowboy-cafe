/* DakotaDoubleBurger.cs
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
    /// A class representing the Dakota Double burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        

        private bool bun = true;
        /// <summary>
        /// Whether the Dakota Double Burger is served on a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Bun"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Ketchup"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Mustard"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains pickles
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

        private bool cheese = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Cheese"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains tomatoes
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Tomato"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Lettuce"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Whether the Dakota Double Burger contains mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Mayo"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Dakota Double Burger
        /// </summary>
        public override uint? Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "Dakota Double Burger"</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
