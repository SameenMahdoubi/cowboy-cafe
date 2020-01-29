using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        private bool bread = true;
        /// <summary>
        /// Whether the Angry Chicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread;  }
            set { bread = value; }
        }

        
        /// <summary>
        /// Whether the Angry Chicken contains pickles
        /// </summary>
        public bool Pickle { get; set; } = true; 

        /// <summary>
        /// The price of the chicken sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken sandwich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Angry Chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
