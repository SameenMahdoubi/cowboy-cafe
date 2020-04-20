/* Side.cs
 * Author: Nathan Bean
 * Last modified 4/20/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Defines the side's name
        /// </summary>
        public string Name { get => ToString(); }

        private Size size = Size.Medium;
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
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for preparation of the side (always empty)
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<String>();
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
