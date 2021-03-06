﻿/* TexasTripleBurger.cs
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
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {

        private bool bun = true;
        /// <summary>
        /// Whether the Texas Triple Burger is served on a bun
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
        /// Whether the Texas Triple Burger contains ketchup
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
        /// Whether the Texas Triple Burger contains mustard
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
        /// Whether the Texas Triple Burger contains pickles
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
        /// Whether the Texas Triple Burger contains cheese
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
        /// Whether the Texas Triple Burger contains tomatoes
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

        private bool bacon = true;
        /// <summary>
        /// Whether the Texas Triple Burger contains bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Bacon"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;
        /// <summary>
        /// Whether the Texas Triple Burger contains eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Egg"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// The price of the Texas Triple Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the Texas Triple Burger
        /// </summary>
        public override uint? Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Texas Triple Burger
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
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string "Texas Triple Burger"</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
