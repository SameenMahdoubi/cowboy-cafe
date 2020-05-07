/* Entree.cs
 * Author: Nathan Bean
 * Last modified 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Defines a base Entree class to use as the parent to all other entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
        {

        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Defines the entree's name
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// Defines the price of a given entree
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// The amount of calories in the entree
        /// </summary>
        public abstract uint? Calories
        {
            get;
        }

        /// <summary>
        /// Special instructions for the preparation of the entree
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
