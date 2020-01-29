using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        private bool bread = true;
        /// <summary>
        /// Whether the Pecos Pulled Pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }


        /// <summary>
        /// Whether the Pecos Pulled Pork contains pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The price of the Pecos Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Pecos Pulled Pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Pecos Pulled Pork
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
