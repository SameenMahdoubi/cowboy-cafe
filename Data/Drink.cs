/* Drink.cs
 * Author: Max Maus
 * Last modified: 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This is a base class which defines a base drink to be used as a parent to unique drinks.
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Defines the drink's name
        /// </summary>
        public string Name { get => ToString(); }

        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Size"));
                InvokePropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Defines the price of a given drink
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// The amount of calories in the drink
        /// </summary>
        public abstract uint Calories
        {
            get;
        }


        private bool ice = true;
        /// <summary>
        /// Whether or not the drink contains ice
        /// </summary>
        public virtual bool Ice
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
        /// Special instructions for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// A method to invoke the property changed event handler, created for readability.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InvokePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, e);
        }
    }
}
